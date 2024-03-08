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
    public partial class DashBord : Form
    {
        public DashBord()
        {
            InitializeComponent();
        }
        DBConnection1 con = new DBConnection1();

        void LoadBookDeatail()
        {
            String Sql = "SELECT b.*, ai.AuthorName, pd.PubliserName ,ai.[Author othe Name],pd.[Publiser other Name] FROM Book_Deatail b JOIN AuthorInfomation ai ON b.Author_ID = ai.AuthorID JOIN PubliserDetail pd ON b.Publisher_ID = pd.PubliserID";
            DataTable dt = con.search(Sql);
            DataGriedVewBookDeatail.DataSource = dt;

        }

        private void DashBord_Load(object sender, EventArgs e)
        {


            
            LoadBookDeatail();
            UserNamelbl.Text = Systemcs.loggedInUser;
            userrolelbl.Text = Systemcs.loggedUserRole;
            if (Systemcs.loggedUserRole.Trim().ToLower() != "admin")
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                UserManagmentbtn.Visible = false;
                LabrianManagment.Visible = false;
                monthCalendar1.Visible = true;

                //DateTime today = DateTime.Now;

            }
            else
            {
                monthCalendar1.Visible = false;
                todaylbl.Text = DateTime.Now.ToString("dd-MMMM-yyyy");
            }
            


        }



        private void UserManagmentbtn_Click(object sender, EventArgs e)
        {
            CreateUser createUser = new CreateUser();
            createUser.Show();
            this.Hide();
        }

        private void ManageUserProfilebtn_Click(object sender, EventArgs e)
        {
            User_Profile_Managment UP = new User_Profile_Managment();
            this.Hide();
            UP.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BookManagement bookManagement = new BookManagement();
            this.Hide();
            bookManagement.Show();  
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewReaderfrom viewReaderfrom = new ViewReaderfrom();
            this.Hide();
            viewReaderfrom.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AuthorManagment authorManagment = new AuthorManagment();
            this.Hide();
            authorManagment.Show();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PublisherManagment publisher = new PublisherManagment();
            this.Hide();
            publisher.Show();   
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReturnBook returnBook = new ReturnBook();
            this.Hide();
            returnBook.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            IssueBookFrom issuesBookFrom = new IssueBookFrom();
            issuesBookFrom.Show();
            this.Hide();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string SearchKey = textsearxh.Text;
            string Sql = $"SELECT b.*,ai.AuthorName,ai.[Author othe Name],pd.PubliserName,pd.[Publiser other Name] FROM Book_Deatail b JOIN AuthorInfomation ai ON b.Author_ID = ai.AuthorID  JOIN PubliserDetail pd ON b.Publisher_ID = pd.PubliserID WHERE b.Book_ID LIKE'%{SearchKey}%' OR b.[Type NO] LiKE '%{SearchKey}%' OR b.[Book Name] LIKE '%{SearchKey}%' OR b.[Other Book Name] LIKE '%{SearchKey}%' OR b.[Book Price]Like'%{SearchKey}%' OR Book_Quntity Like'%{SearchKey}%'OR ai.AuthorName Like '%{SearchKey}%' OR  ai.[Author othe Name] Like '%{SearchKey}%' OR pd.PubliserID LIKE '%{SearchKey}%' OR pd.PubliserName Like '%{SearchKey}%'OR pd.[Publiser other Name] Like '%{SearchKey}%' ";
            DataTable dt = con.search(Sql);
            DataGriedVewBookDeatail.DataSource = dt;
        }

        private void Refeshbtn_Click(object sender, EventArgs e)
        {
            LoadBookDeatail();
        }

    

        private void LogOut_Click(object sender, EventArgs e)
        {
            Systemcs.loggedInUser = "";
            Systemcs.loggedUserRole = "";
            Systemcs.loggedpassword = "";
            Systemcs.loggedUSER_ID = "";
            fromLogin fromLogin = new fromLogin();
            this.Close();
            fromLogin.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            User_Profile_Managment um = new User_Profile_Managment();
            this.Hide();
           um.Show();

        }

        private void Upmanagmentlbl_Click(object sender, EventArgs e)
        {
            User_Profile_Managment um = new User_Profile_Managment();
            this.Hide();
            um.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CreateUser createUser = new CreateUser();
            createUser.Show();
            this.Hide();
        }

        private void LabrianManagment_Click(object sender, EventArgs e)
        {
            Attendence attendence = new Attendence();
            attendence.Show();
            this.Hide();
        }
    }
}
