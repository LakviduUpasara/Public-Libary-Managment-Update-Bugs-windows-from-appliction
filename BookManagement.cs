using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Public_Libary_managment_System
{
    public partial class BookManagement : Form
    {
        public BookManagement()
        {
            InitializeComponent();
        }
        DBConnection1 con = new DBConnection1();

        private void BookManagement_Load(object sender, EventArgs e)
        {
            
            Savebtn.Enabled = true;
            Addbookbtn.Enabled = false;
            EditBookbtn.Enabled = true;
            textfill.Visible = false;
            refesh2btn.Visible = false;
            FillDatabtn.Visible = false; 
            Savebtn.Visible = true;
            Updatebtn.Visible = false;
            Update2btn.Visible = false; 
            LoadBookDeatail();
            

        }


        void LoadBookDeatail()
        {
            String Sql = "SELECT b.*, ai.AuthorName, pd.PubliserName ,ai.[Author othe Name],pd.[Publiser other Name] FROM Book_Deatail b JOIN AuthorInfomation ai ON b.Author_ID = ai.AuthorID JOIN PubliserDetail pd ON b.Publisher_ID = pd.PubliserID  ORDER BY b.Book_ID DESC;";
            DataTable dt = con.search(Sql);
            DataGriedVewBookDeatail.DataSource = dt;
        }
        private void Addbookbtn_Click(object sender, EventArgs e)
        {
            Savebtn.Visible = true;
            Updatebtn.Visible = false;
            Addbookbtn.Enabled = false;
            EditBookbtn.Enabled = true;
            textfill.Visible = false;
            refesh2btn.Visible = false;
            FillDatabtn.Visible = false;
            Update2btn.Visible = false;
            LoadBookDeatail();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            DashBord dashBord = new DashBord();
            dashBord.Show();
            

        }

        private void Refeshbtn_Click(object sender, EventArgs e)
        {
            LoadBookDeatail();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textbookId.Text) ||
             string.IsNullOrWhiteSpace(textbookName.Text) ||
             string.IsNullOrWhiteSpace(textBookPrice.Text) ||
             string.IsNullOrWhiteSpace(textBookQuntity.Text) ||
             string.IsNullOrWhiteSpace(textbooktypeNo.Text) ||
             string.IsNullOrWhiteSpace(textNumberOfPages.Text) ||
             string.IsNullOrWhiteSpace(textAuthorId.Text) ||
             string.IsNullOrWhiteSpace(textPublisherId.Text)
                )

            {
                if (string.IsNullOrWhiteSpace(textbookId.Text))
                {
                    if (string.IsNullOrWhiteSpace(textbookName.Text))
                    {
                        MessageBox.Show("Enter Book Id and Book Name");
                    }
                    else if (string.IsNullOrWhiteSpace(textBookPrice.Text))
                    {
                        MessageBox.Show("Enter Book Id and Book Price ");
                    }
                    else if (string.IsNullOrWhiteSpace(textBookQuntity.Text))
                    {
                        MessageBox.Show("Enter Book Id and Book Quntity ");
                    }
                    else if (string.IsNullOrWhiteSpace(textbooktypeNo.Text))
                    {
                        MessageBox.Show("Enter Book Id and Book Type No ");
                    }
                    else if (string.IsNullOrWhiteSpace(textNumberOfPages.Text))
                    {
                        MessageBox.Show("Enter Book Id and Number Of pages ");
                    }
                    else
                    {
                        MessageBox.Show("Enter Book Id ");

                    }

                }
                else if (string.IsNullOrWhiteSpace(textbookName.Text))
                {


                    if (string.IsNullOrWhiteSpace(textBookPrice.Text))
                    {
                        MessageBox.Show("Enter Book Name and Book Price ");
                    }
                    else if (string.IsNullOrWhiteSpace(textBookQuntity.Text))
                    {
                        MessageBox.Show("Enter Book Name and Book Quntity ");
                    }
                    else if (string.IsNullOrWhiteSpace(textbooktypeNo.Text))
                    {
                        MessageBox.Show("Enter Book Name and Book Type No ");
                    }
                    else if (string.IsNullOrWhiteSpace(textNumberOfPages.Text))
                    {
                        MessageBox.Show("Enter Book Name and Number Of pages ");
                    }
                    else
                    {
                        MessageBox.Show("Enter Book Name ");

                    }




                }
                else if (string.IsNullOrWhiteSpace(textBookPrice.Text))
                {


                    if (string.IsNullOrWhiteSpace(textBookQuntity.Text))
                    {
                        MessageBox.Show("Enter Book Price and Book Quntity ");
                    }
                    else if (string.IsNullOrWhiteSpace(textbooktypeNo.Text))
                    {
                        MessageBox.Show("Enter Book Price and Book Type No ");
                    }
                    else if (string.IsNullOrWhiteSpace(textNumberOfPages.Text))
                    {
                        MessageBox.Show("Enter Book Price and Number Of pages ");
                    }
                    else
                    {
                        MessageBox.Show("Enter Book Price ");

                    }

                }
                else if (string.IsNullOrWhiteSpace(textBookQuntity.Text))
                {
                    if (string.IsNullOrWhiteSpace(textbooktypeNo.Text))
                    {
                        MessageBox.Show("Enter Book Quntity and Book Type No ");
                    }
                    else if (string.IsNullOrWhiteSpace(textNumberOfPages.Text))
                    {
                        MessageBox.Show("Enter Book Quntity and Number Of pages ");
                    }
                    else
                    {
                        MessageBox.Show("Enter Book Quntity ");

                    }
                }
                else if (string.IsNullOrWhiteSpace(textbooktypeNo.Text))
                {
                    if (string.IsNullOrWhiteSpace(textNumberOfPages.Text))
                    {
                        MessageBox.Show("Enter Book Type No and Number Of pages ");
                    }
                    else
                    {
                        MessageBox.Show("Enter Book Type No ");

                    }
                }
                else
                {
                    MessageBox.Show("Enter   Number Of pages ");
                }

            }
           
            else if (string.IsNullOrWhiteSpace(textPublisherId.Text))

            {
                if (string.IsNullOrWhiteSpace(textPublisherId.Text))
                {
                    MessageBox.Show("please enter Authot Id and Publisher id");
                }

            }
            else if (string.IsNullOrWhiteSpace(textPublisherId.Text))
            {
                MessageBox.Show("please Enter Publisher Id");
            }
            else
            {   //Sql Quary   for insert book deatail  

                string BOOKId /*123*/ = textbookId.Text; //123 
                string bookName = textbookName.Text;
                string bookprice = textBookPrice.Text;
                string bookQuntity = textBookQuntity.Text;
                string bookotherName = textOtherName.Text;
                string TypeNo = textbooktypeNo.Text;
                string NumberOfpages = textNumberOfPages.Text;
                string AuthorId_01 = textAuthorId.Text;

                string publisherId_01 = textPublisherId.Text;






                string Sql = $"INSERT INTO Book_Deatail VALUES ('{BOOKId /*123*/}','{TypeNo}', '{bookName}', '{bookotherName}','{bookprice}','{NumberOfpages}','{bookQuntity}','{AuthorId_01}','{publisherId_01}')";
                bool result = con.exuxquary(Sql);

                if (result)
                {
                    MessageBox.Show("sucssful");
                    textbookId.Text = "";
                    textbookName.Text = "";
                    textBookPrice.Text = "";
                    textBookQuntity.Text = "";
                    textOtherName.Text = "";
                    textbooktypeNo.Text = "";
                    textNumberOfPages.Text = "";
                    textAuthorId.Text = "";
                    textPublisherId.Text = "";
                    LoadBookDeatail();




                }
                else
                {
                    MessageBox.Show("unsucssful");
                }
            }




        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            textbookId.Text = "";
            textbookName.Text = "";
            textOtherName.Text = "";
            textBookPrice.Text = "";
            textBookQuntity.Text = "";
            textbooktypeNo.Text = "";
            textNumberOfPages.Text = "";
            textAuthorId.Text = "";
            textPublisherId.Text = "";
            LoadBookDeatail();



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string SearchKey = textsearxh.Text;
            string Sql = $"SELECT b.*,ai.AuthorName,ai.[Author othe Name],pd.PubliserName,pd.[Publiser other Name] FROM Book_Deatail b JOIN AuthorInfomation ai ON b.Author_ID = ai.AuthorID  JOIN PubliserDetail pd ON b.Publisher_ID = pd.PubliserID WHERE b.Book_ID LIKE'%{SearchKey}%' OR b.[Type NO] LiKE '%{SearchKey}%' OR b.[Book Name] LIKE '%{SearchKey}%' OR b.[Other Book Name] LIKE '%{SearchKey}%' OR b.[Book Price]Like'%{SearchKey}%' OR Book_Quntity Like'%{SearchKey}%'OR ai.AuthorName Like '%{SearchKey}%' OR  ai.[Author othe Name] Like '%{SearchKey}%' OR pd.PubliserID LIKE '%{SearchKey}%' OR pd.PubliserName Like '%{SearchKey}%'OR pd.[Publiser other Name] Like '%{SearchKey}%' ";
            DataTable dt = con.search(Sql);
            DataGriedVewBookDeatail.DataSource = dt;
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
           
                string BOOKId = textbookId.Text;
                string bookName = textbookName.Text;
                string bookprice = textBookPrice.Text;
                string bookQuntity = textBookQuntity.Text;
                string bookotherName = textOtherName.Text;
                string TypeNo = textbooktypeNo.Text;
                string NumberOfpages = textNumberOfPages.Text;
                string AuthorId_01 = textAuthorId.Text;

                string publisherId_01 = textPublisherId.Text;






                string Sql = $"UPDATE Book_Deatail SET [Type NO]='{TypeNo}',[Book Name]= '{bookName}', [Other Book Name]='{bookotherName}',[Book Price]='{bookprice}',[Number of Pages]='{NumberOfpages}',Book_Quntity='{bookQuntity}',Author_ID='{AuthorId_01}',Publisher_ID='{publisherId_01}'WHERE  Book_ID ='{BOOKId}'";
                bool result = con.exuxquary(Sql);

                if (result)
                {
                    MessageBox.Show("sucssful");
                    textbookId.Text = "";
                    textbookName.Text = "";
                    textBookPrice.Text = "";
                    textBookQuntity.Text = "";
                    textOtherName.Text = "";
                    textbooktypeNo.Text = "";
                    textNumberOfPages.Text = "";
                    textAuthorId.Text = "";
                    textPublisherId.Text = "";
                    LoadBookDeatail();



                }
                else
                {
                    MessageBox.Show("unsucssful");
                }
            
            Updatebtn.Visible = false;
            Update2btn.Visible = true;


        }

        private void EditBookbtn_Click(object sender, EventArgs e)
        {

            LoadBookDeatail();

        }

        private void refesh2btn_Click(object sender, EventArgs e)
        {
            LoadBookDeatail();
 
           
        }

        private void FillDatabtn_Click(object sender, EventArgs e)
        {
            string fillData = textfill.Text;
            string Sql = $"SELECT b.*,ai.AuthorName,ai.[Author othe Name],pd.PubliserName,pd.[Publiser other Name] FROM Book_Deatail b JOIN AuthorInfomation ai ON b.Author_ID = ai.AuthorID  JOIN PubliserDetail pd ON b.Publisher_ID = pd.PubliserID WHERE b.Book_ID ={fillData}";
            DataTable dt = con.search(Sql);
            if (dt.Rows.Count > 0)
            {
                textbookId.Text = dt.Rows[0][0].ToString();
                textbooktypeNo.Text= dt.Rows[0][1].ToString();
                textbookName.Text= dt.Rows[0][2].ToString();
                textOtherName.Text = dt.Rows[0][3].ToString();
                textBookPrice.Text= dt.Rows[0][4].ToString();
                textNumberOfPages.Text= dt.Rows[0][5].ToString();
                textBookQuntity.Text = dt.Rows[0][6].ToString();
                textAuthorId.Text= dt.Rows[0][7].ToString();
                textPublisherId.Text = dt.Rows[0][8].ToString();

                DataGriedVewBookDeatail.DataSource = dt;
            }
        }

        private void Update2btn_Click(object sender, EventArgs e)
        {
            Update2btn.Visible = false;
            Updatebtn.Visible = true;
        }

        private void DataGriedVewBookDeatail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGriedVewBookDeatail.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                string EnterId = DataGriedVewBookDeatail.Rows[e.RowIndex].Cells[0].Value.ToString();
                textfill.Text = EnterId;
            }
        }

        private void textbookName_MouseClick(object sender, MouseEventArgs e)
        {

            string FillUpdate = textbookId.Text;
            string Sql = $"SELECT * FROM Book_Deatail Where Book_ID ='{FillUpdate}'";
            DataTable dt = con.search(Sql);
            if (dt.Rows.Count > 0)
            {
                textbookId.Text = dt.Rows[0][0].ToString();
                textbooktypeNo.Text = dt.Rows[0][1].ToString();
                textbookName.Text = dt.Rows[0][2].ToString();
                textOtherName.Text = dt.Rows[0][3].ToString();
                textBookPrice.Text = dt.Rows[0][4].ToString();
                textNumberOfPages.Text = dt.Rows[0][5].ToString();
                textBookQuntity.Text = dt.Rows[0][6].ToString();
                textAuthorId.Text = dt.Rows[0][7].ToString();
                textPublisherId.Text = dt.Rows[0][8].ToString();

                DataGriedVewBookDeatail.DataSource = dt;
            }
        }

        private void textsearxh_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
