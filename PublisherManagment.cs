using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Public_Libary_managment_System
{
    public partial class PublisherManagment : Form
    {
        public PublisherManagment()
        {
            InitializeComponent();
        }
        DBConnection1 con= new DBConnection1(); 
        private void PublisherManagment_Load(object sender, EventArgs e)
        {
            ConFrombtn.DoubleClick += ConFrombtn_DoubleClick;   
            loadpublisher();
            AddPublisher.Enabled = false;
            textfill.Visible = false;
            button1.Visible = false;
            deletebtn.Visible = false;
            ConFrombtn.Visible = false;
            Updatebtn.Visible = false;
            loadpublisher();

        }

        private void ConFrombtn_DoubleClick(object sender, EventArgs e)
        {
            string ID = TextpublisherId.Text;
            string Sql = $"DELETE FROM PubliserDetail  Where PubliserID ='{ID}'";
            bool result = con.exuxquary(Sql);

            if (result)
            {
                MessageBox.Show("sucssful");
                TextpublisherId.Text = "";
                textpublisherName.Text = "";
                textpublisherothername.Text = "";
                loadpublisher();



            }
            else
            {
                MessageBox.Show("unsucssful");
            }
            ConFrombtn.Visible = false;
            deletebtn.Visible = true;
        }

        void loadpublisher()
        {
            String Sql = "SELECT Top 10* FROM PubliserDetail ORDER BY PubliserID DESC;";
            DataTable dt = con.search(Sql);
            PublisherGridView1.DataSource = dt;
        }

        private void Search_Click(object sender, EventArgs e)
        { if(string.IsNullOrWhiteSpace(textfill.Text))
            {
                MessageBox.Show("Please Enter Deatail");
            }
            else 
            {
                String Sql;
                string searchKey = textsearch.Text;
                if (int.TryParse(searchKey, out int searchId))
                {
                    Sql = $"SELECT * From PubliserDetail WHERE PubliserID={searchId}";
                }
                else
                {
                    Sql = $"SELECT * From PubliserDetail WHERE PubliserName LIKE '%{searchKey}%' OR [Publiser other Name] LIKE '%{searchKey}%' ";
                }

                DataTable dt = con.search(Sql);

                PublisherGridView1.DataSource = dt;

            }

        }

        private void Refeshbtn_Click(object sender, EventArgs e)
        {
            loadpublisher();
        }

        private void AddPublisher_Click(object sender, EventArgs e)
        {
            loadpublisher();
            AddPublisher.Enabled = false;
            textfill.Visible = false;
            button1.Visible = false;
            deletebtn.Visible = false;
            ConFrombtn.Visible = false;
            Updatebtn.Visible = false;
            Savebtn.Visible = true;
            editPublisher.Enabled = true;
            DeletePublisher.Enabled = true;
        }

        private void editPublisher_Click(object sender, EventArgs e)
        {
            loadpublisher();
            AddPublisher.Enabled = true;
            textfill.Visible = true;
            button1.Visible = true;
            deletebtn.Visible = false;
            ConFrombtn.Visible = false;
            Updatebtn.Visible = true;
            Savebtn.Visible = false ;
            editPublisher.Enabled = false;
            DeletePublisher.Enabled = true;
        }

        private void DeletePublisher_Click(object sender, EventArgs e)
        {
            loadpublisher();
            AddPublisher.Enabled = true;
            textfill.Visible = true;
            button1.Visible = true;
            deletebtn.Visible = true;
            ConFrombtn.Visible = false;
            Updatebtn.Visible = false;
            Savebtn.Visible = false;
            editPublisher.Enabled = true;
            DeletePublisher.Enabled = false;
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextpublisherId.Text))
            {
                if (string.IsNullOrWhiteSpace(textpublisherName.Text))
                {
                    MessageBox.Show("Please Enter Publisher ID And Name");
                }
                else
                {
                    MessageBox.Show("please Enter Publisher Id");
                }

            }
            else if (string.IsNullOrWhiteSpace(textpublisherName.Text))
            {
                MessageBox.Show("Please Enter Publisher Name ");
            }
            else
            {
                string Id = TextpublisherId.Text;
                string Name = textpublisherName.Text;
                string OtherName = textpublisherothername.Text;

                string Sql = $"UPDATE PubliserDetail SET PubliserName ='{Name}', [Publiser other Name]='{OtherName}'Where  PubliserID ='{Id}'";
                bool result = con.exuxquary(Sql);

                if (result)
                {
                    MessageBox.Show("sucssful");
                    TextpublisherId.Text= "";
                    textpublisherName.Text = "";
                    textpublisherothername.Text = "";
                    textfill.Text = "";

                    loadpublisher();


                }
                else
                {
                    MessageBox.Show("unsucssful");
                }
            }
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            DashBord dashBord   = new DashBord();
            dashBord.Show();
            this.Hide();
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            TextpublisherId.Text = "";
            textpublisherName.Text = "";
            textpublisherothername.Text = "";
            textfill.Text = "";


        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextpublisherId.Text))
            {
                if (string.IsNullOrWhiteSpace(textpublisherName.Text))
                {
                    MessageBox.Show("Please Enter Publisher ID And Name");
                }
                else
                {
                    MessageBox.Show("please Enter Publisher Id");
                }

            }
            else if (string.IsNullOrWhiteSpace(textpublisherName.Text))
            {
                MessageBox.Show("Please Enter Publisher Name ");
            }
            else
            {
                string Id = TextpublisherId.Text;
                string Name = textpublisherName.Text;
                string OtherName = textpublisherothername.Text;

                string Sql = $"INSERT INTO PubliserDetail VALUES ('{Id}' ,'{Name}', '{OtherName}')";
                bool result = con.exuxquary(Sql);

                if (result)
                {
                    MessageBox.Show("sucssful");
                    textpublisherName.Text = "";
                    textpublisherothername.Text = "";
                    TextpublisherId.Text = "";
                    loadpublisher();

                }
                else
                {
                    MessageBox.Show("unsucssful");
                }
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextpublisherId.Text))
            {
                MessageBox.Show("please Enter Publisher Id");
            }
            else
            {
                string PublisherID = TextpublisherId.Text.Trim();
                string sql = $"SELECT * FROM PubliserDetail Where PubliserID='{PublisherID}' ";
                DataTable dt = con.search(sql);
                if (dt.Rows.Count > 0)
                {
                    string Id = dt.Rows[0][0].ToString();
                    string Name = dt.Rows[0][1].ToString();
                    string otherName = dt.Rows[0][2].ToString();
                    TextpublisherId.Text = Id;
                    textpublisherName.Text = Name;
                    textpublisherothername.Text = otherName;
                    ConFrombtn.Visible = true;
                    deletebtn.Visible = false;

                }
                else
                {
                    MessageBox.Show("please Enter Valid Id");
                }
            }
        }

        private void textfill_MouseClick(object sender, MouseEventArgs e)
        {
            textfill.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textfill.Text))
            {
                MessageBox.Show("please Enter Publisher Id");
            }
            string ENTERID = textfill.Text.Trim();
            string sql = $"SELECT * FROM PubliserDetail Where PubliserID='{ENTERID}' ";
            DataTable dt = con.search(sql);
            if (dt.Rows.Count > 0)
            {
                string Id = dt.Rows[0][0].ToString();
                string Name = dt.Rows[0][1].ToString();
                string otherName = dt.Rows[0][2].ToString();
                TextpublisherId.Text = Id;
                textpublisherName.Text = Name;
                textpublisherothername.Text = otherName;

            }
            else
            {
                MessageBox.Show("please Enter Valid Id");

            }
        }

        private void PublisherGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (PublisherGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                string EnterId = PublisherGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textfill.Text = EnterId;
            }
        }

        private void AuthorManagmntbtn_Click(object sender, EventArgs e)
        {
            AuthorManagment authorManagment = new AuthorManagment();
            authorManagment.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PublisherManagment  publisherManagment = new PublisherManagment();
            publisherManagment.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BookManagement bookManagement = new BookManagement();
            bookManagement.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IssueBookFrom issueBookFrom = new IssueBookFrom();
            issueBookFrom.Show();
        }

        private void RederManagmentbtn_Click(object sender, EventArgs e)
        {
            Reader_Managment reader_Managment = new Reader_Managment();
            reader_Managment.Show();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReturnBook returnBook = new ReturnBook();
            returnBook.Show();
            this.Close();
        }
    }
}
