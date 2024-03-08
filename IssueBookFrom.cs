using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Timers;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Public_Libary_managment_System
{
    public partial class IssueBookFrom : Form
    {
        public IssueBookFrom()
        {
            InitializeComponent();
        }
        DBConnection1 con = new DBConnection1();
        string RederId;
        DateTime curentdate = DateTime.Now;
        DateTime currentRuturnDate = DateTime.Now.AddDays(14);



        /// <summary>
        /// ////
        /// </summary>
        /// 
        string BookID;
        int Qc1;
        void SerachQuntity()
        {
            BookID = textBookID.Text;
            string sql = $"SELECT Book_Quntity FROM  Book_Deatail Where Book_ID='{BookID}'";
            DataTable dt2 = con.search(sql);
            if (dt2.Rows.Count > 0)
            {
                string Quantity = dt2.Rows[0][0].ToString();
                Qc1 = Convert.ToInt32(Quantity);
            }
            else
            {
                MessageBox.Show("Book Id Is Wrong");

            }
        }

        void IssueLoad()
        {
            string sql = "SELECT R.Reader_ID ,R.[Reade Full_Name],R.[Book Avalible Count],b.Book_ID,b.[Book Name],b.Book_Quntity,IT.Issue_ID,IT.IssueDate,IT.Due_Date,IT.ReternDate ,Ur.FRIST_NAME,Ur.UserRole,IT.Fines From Issu_book I  join Book_Deatail b on b.Book_ID= I.BookId join ReaderDeatail R On R.Reader_ID=I.Reder_id join IssuTabale IT On IT.Issue_ID=I.IssuID join UserTable Ur On Ur.USER_ID=I.LibrianId  ORDER BY IT.Issue_ID DESC;";
            DataTable dt = con.search(sql);
            dataGridView1.DataSource = dt;
        }
        private void IssueBookFrom_Load(object sender, EventArgs e)
        {
            IssueLoad();
            panel1.Visible = false;
            countbdisplaytext.Enabled = false;
            textBox2.Text = curentdate.ToString("dd-MMMM-yyyy");
            textBox1.Text=curentdate.ToString("dd-MMMM-yyyy");
            textBox2.Enabled = false;
            Retrundatetext.Text = currentRuturnDate.ToString("dd-MMMM-yyyy");
            Retrundatetext.Enabled = false;
            textBox1.Enabled = false;
        }

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
                    string RVbook = dt.Rows[0][0].ToString();
                    int readerAB = Convert.ToInt32(RVbook);
                    if (readerAB > 0) 
                                {
                                    panel1.Visible=true;
                                    nextbtn.Visible=false;
                                    countbdisplaytext.Text = RVbook;
                                }
                                else
                                {
                                    countbdisplaytext.Text = "The Reader Not Return Book" ;

                                }


                }
                else
                {
                    MessageBox.Show("Reader Id is Not Regiterd Our Sustem");
                }


            }
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            DashBord dashBord = new DashBord();
            dashBord.Show();
            this.Close();
        }


        
        int nowbookCount;
        void BookQuntitysql()
        {  
            string sql = $"SELECT Book_Quntity FROM  Book_Deatail Where Book_ID='{BookID}'";
            DataTable dt2 = con.search(sql);
            string Quantity;
            if (dt2.Rows.Count > 0)
            {
                 Quantity = dt2.Rows[0][0].ToString();
                int  Qc = Convert.ToInt32(Quantity);
                nowbookCount = Qc - 1;
            }
            else
            {

                MessageBox.Show("Book Id Is Wrong");
            }

           
            INSERTISSUTABALE();


        }
        int PresentIssueID;
        
        void IssueIDSql()
        {
            string sql = $"SELECT Top 1  Issue_ID,Due_Date FROM  IssuTabale ORDER BY Issue_ID DESC";
            DataTable dt2 = con.search(sql);
            if (dt2.Rows.Count > 0)
            {
                string IssueIDString = dt2.Rows[0][0].ToString();

                int Qc2 = Convert.ToInt32(IssueIDString);
                PresentIssueID = Qc2 + 1;
            }else
            {
                PresentIssueID = 1234 + 1;
            }
            

        }
        string DueDate1;
        string Today1;
        void dateAject()
        {
            string date2 = textBox1.Text;

            var date = Convert.ToDateTime(date2);


            int year = date.Year;
            int month = date.Month;
            int day = date.Day;


            var Today = new DateTime(year, month, day);
            DateTime DueDate = Today.AddDays(14);
            DueDate1 = DueDate.ToString();
            Today1 = Today.ToString();
            textBox1.Text = Today1;
            Retrundatetext.Text = DueDate1;
        }
        
        void INSERTISSUTABALE()
        {
            IssueIDSql();
            dateAject();


            string sql3 = $"INSERT INTO IssuTabale VALUES ('{PresentIssueID}','{RederId}','{Today1}','{DueDate1}','2023-01-01','Rs 00.00')";
            bool result = con.exuxquary(sql3);
            if (result)
            {
                IssueBOOK();
            }
            else
            {
                MessageBox.Show("unsucsessfull");
            }
        }
        void BookQuntityUpdate()
        {
           
            string sql = $"UPDATE Book_Deatail SET Book_Quntity='{nowbookCount}' WHERE  Book_ID='{BookID}' ";
            bool result = con.exuxquary(sql);
            if (result)
            {
                REderAB();
               

            }
            else
            {
                MessageBox.Show("Issue sucssful   " + BookID + "And  " + BookID + "Quantity  Is Update unsucssful");

            }

        }
        void IssueBOOK()
        {
            string UserId = Systemcs.loggedUSER_ID;
            string sql = $"INSERT INTO Issu_book VALUES ('{PresentIssueID}','{BookID}','{UserId}','{RederId}')";
            bool result = con.exuxquary(sql);
            if (result)
            {
                BookQuntityUpdate();
                MessageBox.Show("Your Issue ID Is  " + PresentIssueID);
            }
            else
            {
                MessageBox.Show("Book Issue Failed");
            }
        }

    
        void REderAB()
        {
            RederId = textReaderid.Text;
            string Sql = $"SELECT [Book Avalible Count] FROM ReaderDeatail WHERE Reader_ID='{RederId}'";
            DataTable dt = con.search(Sql);
            string DatabaseAvalibale = dt.Rows[0][0].ToString();
            int DatabaseAvalibale2 =Convert.ToInt32(DatabaseAvalibale);
            int NRAB = DatabaseAvalibale2 - 1;
            string Sql2 = $"UPDATE ReaderDeatail SET [Book Avalible Count] = '{NRAB}' WHERE Reader_ID='{RederId}';";
            bool result = con.exuxquary(Sql2);
            if (result)
            {
                MessageBox.Show("Successful Issue , The "+BookID+"  Conut Is Update  "+nowbookCount +" And  " +RederId +" Count IS  Update  " +NRAB);
                textBookID.Text = "";
                textReaderid.Text = "";
                countbdisplaytext.Text = "";
                panel1.Visible = false;
                nextbtn.Visible = true;
                IssueLoad();
            }
            else
            {
                MessageBox.Show("Not Update Reader Book Avalible Count");
            }

        }

        private void SumitBtn_Click(object sender, EventArgs e)
        {  if (string.IsNullOrWhiteSpace(textBookID.Text))
            {
                MessageBox.Show("Please Enter Book Id");
            }
            else
            {
                SerachQuntity();
                if (Qc1 > 0)
                {
                    BookQuntitysql();

                }
                else
                {
                    MessageBox.Show("You Cant Issu This Book Because " + BookID + "Quntity Is " + Qc1);
                }

            }


        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            BookManagement bookManagement = new BookManagement();
            bookManagement.Show();
            this.Close();
        }

        private void AuthorManagmntbtn_Click(object sender, EventArgs e)
        {
            AuthorManagment authorManagment = new AuthorManagment();
            authorManagment.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reader_Managment reader_Managment   = new Reader_Managment();
            reader_Managment.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReturnBook returnBook = new ReturnBook();
            returnBook.Show();
            this.Close();
        }

        void Clear()
        {
            textBookID.Text = "";
           
          
            textReaderid.Text = "";
          
            countbdisplaytext.Text = "";
            textBox1.Text = curentdate.ToString("dd-MMMM-yyyy");
            Retrundatetext.Text = currentRuturnDate.ToString("dd-MMMM-yyyy");

            nextbtn.Visible = true;
            panel1.Visible = false;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            dateAject();
        }
    }
}
