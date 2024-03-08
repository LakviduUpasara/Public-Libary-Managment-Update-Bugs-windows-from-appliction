using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Public_Libary_managment_System
{
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
        }
        DBConnection1 con =new DBConnection1();
        private void ReturnBook_Load(object sender, EventArgs e)
        {
            BookIssu();
            countbdisplaytext.Enabled = false;
            issuId.Enabled = true;
            panel1.Visible = false;
            textTotalDays.Enabled = false;
            textfines.Enabled = false;
            texttday.Enabled = false;
            nextbtn.Visible = true;
            texttday.Text = DateTime.Now.ToString();

        }
        private void button5_Click(object sender, EventArgs e)
        {
            IssueBookFrom issueBookFrom = new IssueBookFrom();
            issueBookFrom.Show();
            this.Close();
        }
        void BookIssu()
        {   DateTime  Today = DateTime.Now;
            string sql = $"SELECT R.Reader_ID ,R.[Reade Full_Name],R.[Book Avalible Count],b.Book_ID,b.[Book Name],b.Book_Quntity,IT.IssueDate,IT.Due_Date,IT.ReternDate,IT.Fines ,Ur.USERNAME,Ur.UserRole From Issu_book I join Book_Deatail b on b.Book_ID= I.BookId join ReaderDeatail R On R.Reader_ID=I.Reder_id join IssuTabale IT On IT.Issue_ID=I.IssuID join UserTable Ur On Ur.USER_ID=I.LibrianId Where Due_Date='{Today}' ORDER BY IT.IssueDate DESC";
            DataTable dt = con.search(sql);
            dataGridView1.DataSource = dt;
        }
        string RederId;
        int readerAB;
        private void nextbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textReaderid.Text))
            {
                MessageBox.Show("Please Enter User Id ");
            }
            else
            {
                 RederId = textReaderid.Text;
                 string Sql = $"SELECT [Book Avalible Count] FROM ReaderDeatail WHERE Reader_ID='{RederId}'";
                 DataTable dt = con.search(Sql);
                


                if (dt.Rows.Count > 0)
                {

                    string avalibleBook = dt.Rows[0][0].ToString();

                    readerAB = Convert.ToInt32(avalibleBook);
                    if (readerAB<2 )
                    {


                        panel1.Visible = true;
                        nextbtn.Visible = false;
                        countbdisplaytext.Text = avalibleBook;
                    }
                    else
                    {
                        countbdisplaytext.Text = "Reder Haven't A book";

                    }


                }
                else
                {
                    MessageBox.Show("Reader Id is Not Regiterd Our Sustem");
                }


            }
        }
        string ISSEID;
        double fines;
        string Inputday;
        private void SumitBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBookID.Text))
            {
                MessageBox.Show("Please Enter Book Id");
            }else
            {
                issuId.Enabled= true;
                string issueId = issuId.Text;
                string BookID = textBookID.Text;
                string sql = $"SELECT IssuID From Issu_book WHERE IssuID ='{issueId}' And BookId={BookID} And Reder_id={RederId} ORDER BY IssuID DESC ";
                DataTable dt = con.search(sql);
                if (dt.Rows.Count > 0)
                {
                    ISSEID = dt.Rows[0][0].ToString();
                   // MessageBox.Show("issu Id    " + ISSEID); Working

                    string duedateSql = $"SELECT Due_Date From IssuTabale WHERE Issue_ID={ISSEID} ";
                    DataTable dt2 = con.search(duedateSql);
                    if (dt2.Rows.Count > 0)
                    {
                        string DueDate1 = dt2.Rows[0][0].ToString();
                       // MessageBox.Show ("Due Date " +  DueDate1);  Working
                        var date = Convert.ToDateTime(DueDate1);

                        int year = date.Year;
                        int month = date.Month;
                        int day = date.Day;


                        var dueDate = new DateTime(year, month, day);
                        issuId.Text = year + "/" + month + "/" + day.ToString();// Working
                        var today = DateTime.Now;
                        texttday.Text = today.ToString();
                        Inputday = today.ToString();

                        //get difference of two dates
                        var diffOfDates = today - dueDate;



                        if (diffOfDates.Days > 0)
                        {
                            if (diffOfDates.Days > 31)
                            {
                                if (diffOfDates.Days > 91)
                                {
                                    if (diffOfDates.Days > 181)
                                    {
                                        // Console.WriteLine("up days 180");

                                        int MinesDate = Math.Abs(diffOfDates.Days) - 180;
                                        int Days01_30 = 30;
                                        int Days91_180 = 90 * 80;
                                        int Days60_90 = 60 * 40;
                                        int Days180Up = MinesDate * 100;
                                        int Total = Days01_30 + Days91_180 + Days60_90 + Days180Up;
                                        textfines.Text = "Rs " + Total + "00";
                                        textTotalDays.Text = diffOfDates.Days.ToString();
                                        MessageBox.Show("Total late Days Is = " + diffOfDates.Days.ToString() + "Fines  = " + Total);
                                        //  Console.WriteLine("RS " + Total);

                                    }
                                    else
                                    {

                                        // Console.WriteLine("Days 91 to 181    " + diffOfDates.Days);
                                        int MinesDate = Math.Abs(diffOfDates.Days) - 90;
                                        int Days01_30 = 1 * 30;
                                        int Days91_180 = MinesDate * 80;
                                        int Days60_90 = 60 * 40;

                                        int Total = Days01_30 + Days91_180 + Days60_90;
                                        // Console.WriteLine("RS " + Total);
                                        textfines.Text = "Rs " + Total + "00";
                                        textTotalDays.Text = diffOfDates.Days.ToString();
                                        MessageBox.Show("Total late Days Is = " + diffOfDates.Days.ToString() + "Fines  = " + Total);

                                    }

                                }
                                else
                                {
                                    //Console.WriteLine("31 to 90     " + diffOfDates.Days);
                                    int MinesDate = Math.Abs(diffOfDates.Days) - 30;
                                    int Days31t091 = MinesDate * 40;

                                    int Total = Days31t091 + 30;
                                    //Console.WriteLine("RS " + X1);
                                    textfines.Text = "Rs " + Total + "00";
                                    textTotalDays.Text = diffOfDates.Days.ToString();
                                    MessageBox.Show("Total late Days Is = " + diffOfDates.Days.ToString() + "Fines  = Rs  " + Total);
                                }


                            }
                            else
                            {
                                // Console.WriteLine("0 to 31 Days Calcutation    " + diffOfDates.Days);

                                int AB = Math.Abs(diffOfDates.Days);
                                int panelty = Math.Abs(diffOfDates.Days) * 1;

                                //Console.WriteLine("Your panalty is : Rs." + panelty);


                                textfines.Text = "Rs " + panelty + "00";
                                textTotalDays.Text = diffOfDates.Days.ToString();
                                MessageBox.Show("Total late Days Is = " + diffOfDates.Days.ToString() + "Fines  = Rs  " + panelty);
                            }

                        }
                        else
                        {

                            textTotalDays.Text = Math.Abs(diffOfDates.Days).ToString();
                            MessageBox.Show(("You're " + Math.Abs(diffOfDates.Days) + " Days Early"));

                        }



                        bookcountupdate();
                        ReturnDateUpdate();
                    }
                    else
                    {
                         MessageBox.Show("Some think Is Wrong");
                    }

                }
                else
                {
                    MessageBox.Show("book Id Or Reder Id Is Wrong ");
                }

            }
        }



        void Clear()
        {
            textBookID.Text = "";
            textfines.Text = "";
            textTotalDays.Text = "";
            textReaderid.Text = "";
            issuId.Text = "";
            countbdisplaytext.Text = "";
            nextbtn.Visible = true;
            panel1.Visible = false;
            BookIssu();


        }
        void ReturnDateUpdate()
        {   DateTime tday = DateTime.Now;
            var date = Convert.ToDateTime(tday);

            int year = date.Year;
            int month = date.Month;
            int day = date.Day;


            var today1 = new DateTime(year, month, day);
            string tday1= today1.ToString();

            string sql = $"Update IssuTabale Set ReternDate = '{tday1}',Fines ='{"Rs"+ fines }'Where Issue_ID='{ISSEID}'";
            bool result = con.exuxquary(sql);
            if (result)
            {
                MessageBox.Show("Successful Retrun Book");
            } else
            {
                MessageBox.Show("Unsuccessful");
            }
        }

        void UpdateReaderBook()
        {
            string BookID = textBookID.Text;
            int nowAvalibalebook = readerAB + 1;
            string NABR = nowAvalibalebook.ToString();
            string Sql2 = $"UPDATE ReaderDeatail SET [Book Avalible Count] = '{NABR}' WHERE Reader_ID='{RederId}';";
            bool result = con.exuxquary(Sql2);
            if (result)
            {
                MessageBox.Show("Reader Avalibale Count Is Update =   " + nowAvalibalebook + "And  Book Quantity Also Update " + BookID + "   =  " + nowAvalibalebook);
                Clear();
            }
            else
            {
                MessageBox.Show("Reader Avalibale Count Is Not Update  =  " + readerAB);

            }
        }
        int nowbookCount;
       
         void SearchbookCount()
        { //NO ISSU
            string BookID = textBookID.Text;
            string sql = $"SELECT Book_Quntity FROM  Book_Deatail Where Book_ID='{BookID}'";
            DataTable dt2 = con.search(sql);
            string Quantity = dt2.Rows[0][0].ToString();
            int bookCount = Convert.ToInt32(Quantity);
            nowbookCount = bookCount + 1;

        }
        void bookcountupdate()
        {
            SearchbookCount();
            string BookID = textBookID.Text;
            string sql = $"UPDATE Book_Deatail SET Book_Quntity='{nowbookCount}' WHERE  Book_ID='{BookID}' ";
            bool result = con.exuxquary(sql);
            if (result)
            {
                UpdateReaderBook();


            }
            else
            {
                MessageBox.Show("Issue sucssful   " + BookID + "And  " + BookID + "Quantity  Is Update unsucssful");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reader_Managment reader_Managment = new Reader_Managment();
            reader_Managment.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BookManagement bookManagement  = new BookManagement();
            bookManagement.Show();
            this.Close();
        }

        private void AuthorManagmntbtn_Click(object sender, EventArgs e)
        {
            AuthorManagment authorManagment = new AuthorManagment(); 
            authorManagment.Show();
            this.Close();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            DashBord dashBord = new DashBord();
            dashBord.Show();this.Close();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Clear();
            BookIssu();
        }

        private void textReaderid_TextChanged(object sender, EventArgs e)
        {

        }

        private void textfines_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
