using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Public_Libary_managment_System
{
    public partial class AuthorManagment : Form
    {
        public AuthorManagment()
        {
            InitializeComponent();
        }
        DBConnection1 Con = new DBConnection1();

        private void AuthorManagment_Load(object sender, EventArgs e)
        {
            ConFrombtn.DoubleClick += ConFrombtn_DoubleClick;
            loadauthor();
            AddAuthorbtn.Enabled = false ;
            editAuthor.Enabled = true ;
            DeleteAuthor.Enabled = true ;
            textfill.Visible = false ;
            button1.Visible = false ;
            Updatebtn.Visible = false ; 
            Savebtn.Visible = true;
            deletebtn.Visible = false ;
            ConFrombtn.Visible = false ;
        }

        private void ConFrombtn_DoubleClick(object sender, EventArgs e)
        {
            
            string AuthorId = TextAuthorId.Text;
            string Sql = $"DELETE FROM AuthorInfomation  Where AuthorID ='{AuthorId}'";
            bool result = Con.exuxquary(Sql);

            if (result)
            {
                MessageBox.Show("sucssful");
                TextAuthorId.Text = "";
                textAuthorName.Text = "";
                textAuthorOtherName.Text = "";
                textfill.Text = "";
                loadauthor();



            }
            else
            {
                MessageBox.Show("unsucssful");
            }
            ConFrombtn.Visible = false;
            deletebtn.Visible = true;
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            DashBord dashBord = new DashBord();
            dashBord.Show();
            this.Hide();
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            TextAuthorId.Text = "";
            textAuthorName.Text = "";
            textAuthorOtherName.Text = "";
            textfill.Text = "";


        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(TextAuthorId.Text))
            {
                if(string.IsNullOrWhiteSpace(textAuthorName.Text))
                {
                    MessageBox.Show("Please Enter Author ID And Name");
                }
                else
                {
                    MessageBox.Show("please Enter Author Id");
                }
            
            }else if (string.IsNullOrWhiteSpace(textAuthorName.Text))
            {
                MessageBox.Show("Please Enter Author Name ");
            }else
            {
               string AuthorId = TextAuthorId.Text;
                string AuthorName = textAuthorName.Text;
                string OtherName = textAuthorOtherName.Text;

                string Sql = $"INSERT INTO AuthorInfomation VALUES ('{AuthorId}' ,'{AuthorName}', '{OtherName}')";
                bool result = Con.exuxquary(Sql);

                if (result)
                {
                    MessageBox.Show("sucssful");
                    TextAuthorId.Text= "";
                    textAuthorName.Text = "";
                    textAuthorOtherName.Text= "";
                    loadauthor();


                }
                else
                {
                    MessageBox.Show("unsucssful");
                }
            }
        }
        void loadauthor()
        {
            String Sql = "SELECT Top 100* FROM AuthorInfomation ORDER BY AuthorID DESC;";
            DataTable dt = Con.search(Sql);
            AuthorGridView1.DataSource = dt;
        }

        private void Refeshbtn_Click(object sender, EventArgs e)
        {
            loadauthor();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           String Sql;
            string searchKey = textsearch.Text;
            if (int.TryParse(searchKey, out int searchId))
            {
                Sql = $"SELECT * From AuthorInfomation WHERE AuthorID={searchId}";
            }
            else
            {
                Sql = $"SELECT * From AuthorInfomation WHERE AuthorName LIKE '%{searchKey}%' OR [Author othe Name] LIKE '%{searchKey}%' ";
            }

            DataTable dt = Con.search(Sql);

            AuthorGridView1.DataSource = dt;
        }

        private void textfill_MouseClick(object sender, MouseEventArgs e)
        {
            textfill.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        { if (string.IsNullOrWhiteSpace(textfill.Text))
            {
                MessageBox.Show("please Enter Author Id");
            }
            string ENTERID = textfill.Text.Trim();
            string sql = $"SELECT * FROM AuthorInfomation Where AuthorID='{ENTERID}' ";
            DataTable dt = Con.search(sql);
            if(dt.Rows.Count > 0)
            {
                string Id = dt.Rows[0][0].ToString();
                string Name = dt.Rows[0][1].ToString();
                string otherName = dt.Rows[0][2].ToString();
                TextAuthorId.Text = Id;
                textAuthorName.Text = Name;
                textAuthorOtherName.Text = otherName;

            }else
            {
                MessageBox.Show("please Enter Valid Id");
            }

        }

        private void editAuthor_Click(object sender, EventArgs e)
        {
            button1.Visible=true; textfill.Visible = true;
            Updatebtn.Visible = true;
            AddAuthorbtn.Enabled = true;
            DeleteAuthor.Enabled = true;
            editAuthor.Enabled = false;
            Savebtn.Visible = false;
            deletebtn.Visible = false;
            loadauthor();
        }

        private void AddAuthorbtn_Click(object sender, EventArgs e)
        {
            loadauthor();
            AddAuthorbtn.Enabled = false;
            editAuthor.Enabled = true;
            DeleteAuthor.Enabled = true;
            textfill.Visible = false;
            button1.Visible = false;
            Updatebtn.Visible = false;
            Savebtn.Visible = true;
            deletebtn.Visible = false;
            ConFrombtn.Visible = false;
        }

        private void AuthorGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (AuthorGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
               string EnterId = AuthorGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textfill.Text = EnterId;
            }
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextAuthorId.Text))
            {
                if (string.IsNullOrWhiteSpace(textAuthorName.Text))
                {
                    MessageBox.Show("Please Enter Author ID And Name");
                }
                else
                {
                    MessageBox.Show("please Enter Author Id");
                }

            }
            else if (string.IsNullOrWhiteSpace(textAuthorName.Text))
            {
                MessageBox.Show("Please Enter Author Name ");
            }
            else
            {
                string AuthorId = TextAuthorId.Text;
                string AuthorName = textAuthorName.Text;
                string OtherName = textAuthorOtherName.Text;

                string Sql = $"UPDATE AuthorInfomation SET AuthorName ='{AuthorName}', [Author othe Name]='{OtherName}'Where  AuthorID ='{AuthorId}'";
                bool result = Con.exuxquary(Sql);

                if (result)
                {
                    MessageBox.Show("sucssful");
                    TextAuthorId.Text = "";
                    textAuthorName.Text = "";
                    textAuthorOtherName.Text = "";
                    textfill.Text = "";
                    loadauthor();

                }
                else
                {
                    MessageBox.Show("unsucssful");
                }
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            string AuthorId = TextAuthorId.Text;
            string sql =$"SELECT * FROM AuthorInfomation Where AuthorID ='{AuthorId}' ";
            DataTable dt = Con.search(sql);
            if (dt.Rows.Count > 0)
            {
                string Id = dt.Rows[0][0].ToString();
                string Name = dt.Rows[0][1].ToString();
                string otherName = dt.Rows[0][2].ToString();
                TextAuthorId.Text = Id;
                textAuthorName.Text = Name;
                textAuthorOtherName.Text = otherName;
                AuthorGridView1.DataSource = dt;
                deletebtn.Visible = false;
                ConFrombtn.Visible = true;

            }
            else
            {
                MessageBox.Show("please Enter Valid Id");
            }
        }



        private void DeleteAuthor_Click(object sender, EventArgs e)
        {
            textfill.Visible = true; button1.Visible = true;
            deletebtn.Visible=true; ConFrombtn.Visible = false;
            DeleteAuthor.Enabled = false;
            AddAuthorbtn.Enabled = true;
            editAuthor.Enabled = true;
            Updatebtn.Visible = false;
        }

        private void publishermanagmentbtn_Click(object sender, EventArgs e)
        {
            PublisherManagment publisherManagment = new PublisherManagment();
            publisherManagment.Show();
        }

        private void ConFrombtn_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            BookManagement bookManagement = new BookManagement();
            bookManagement.Show();
            
        }

        private void ReaderManagment_Click(object sender, EventArgs e)
        {
            ViewReaderfrom viewReaderfrom = new ViewReaderfrom();
            viewReaderfrom.Show();
           
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            PublisherManagment publisherManagment = new PublisherManagment();
            publisherManagment.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            BookManagement bookManagement  =new BookManagement();
            bookManagement.Show();this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IssueBookFrom issueBookFrom = new IssueBookFrom();
            issueBookFrom.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReturnBook returnBook = new ReturnBook();
            returnBook.Show();
            this.Close();
        }

        private void Redermanagmentbtn_Click(object sender, EventArgs e)
        {
            Reader_Managment reader_Managment = new Reader_Managment();
            reader_Managment.Show();
            this.Close();
        }
    }
}
