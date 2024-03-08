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
    public partial class Author_Managment : Form
    {
        public Author_Managment()
        {
            InitializeComponent();
        }
        DBConnection1 con = new DBConnection1();

        private void backbtn_Click(object sender, EventArgs e)
        {
            DashBord dashBord= new DashBord();
            dashBord.Show();

        }

        private void Author_Managment_Load(object sender, EventArgs e)
        {
            AddAuthorbtn.Enabled = false;
            Editauthorbtn.Enabled = true;
            deletebtn.Enabled = true;
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            textAuthorId.Text = "";
            textAuthorName.Text = "";
            textAuthorOtherName.Text = "";
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textAuthorId.Text))
            {
                if (string.IsNullOrWhiteSpace(textAuthorName.Text))
                {
                    MessageBox.Show("please enter author id and name");
                }else
                {
                    MessageBox.Show("please enter author ID ");
                }
            }else if (string.IsNullOrWhiteSpace(textAuthorName.Text))
            {
                MessageBox.Show("please enter author  name");
            }else
            {   string  AuthorId = textAuthorId.Text;
                string AuthorName = textAuthorName.Text;
                string OtherName = textAuthorOtherName.Text;
                string Sql = $"INSERT INTO AuthorInfomation(AuthorID,AuthorName,[Author othe Name])Values('{AuthorId}','{AuthorName}','{OtherName}')";
                bool result = con.exuxquary(Sql);
                if (result)
                {
                    MessageBox.Show("Sucsessful");
                    textAuthorId.Text = "";
                    textAuthorName.Text = "";
                    textAuthorOtherName.Text = "";
                }
                else
                {
                    MessageBox.Show("Unsucsessful");
                }

            }
        }

        private void Editauthorbtn_Click(object sender, EventArgs e)
        {
            AddAuthorbtn.Enabled= true;
            Editauthorbtn.Enabled= false;
            deletebtn.Enabled= true;
            Savebtn.Visible= false;
            UpdateBtn.Visible= true;
        }

        private void AddAuthorbtn_Click(object sender, EventArgs e)
        {
            AddAuthorbtn.Enabled = false;
            Editauthorbtn.Enabled = true;
            deletebtn.Enabled = true;
            Savebtn.Visible = true;
            UpdateBtn.Visible = false;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textAuthorId.Text))
            {
                if (string.IsNullOrWhiteSpace(textAuthorName.Text))
                {
                    MessageBox.Show("please enter author id and name");
                }
                else
                {
                    MessageBox.Show("please enter author ID ");
                }
            }
            else if (string.IsNullOrWhiteSpace(textAuthorName.Text))
            {
                MessageBox.Show("please enter author  name");
            }
            else
            {
                string AuthorId = textAuthorId.Text;
                string AuthorName = textAuthorName.Text;
                string OtherName = textAuthorOtherName.Text;
                string Sql = $"UPDATE AuthorInfomation SET AuthorName='{AuthorName}',[Author othe Name] = '{OtherName}' Where AuthorID='{AuthorId}'";
                bool result = con.exuxquary(Sql);
                if (result)
                {
                    MessageBox.Show("Sucsessful");
                    textAuthorId.Text = "";
                    textAuthorName.Text = "";
                    textAuthorOtherName.Text = "";
                }
                else
                {
                    MessageBox.Show("Unsucsessful");
                }

            }
        }
    }
}
