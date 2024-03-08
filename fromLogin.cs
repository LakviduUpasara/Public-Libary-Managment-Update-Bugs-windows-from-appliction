using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Public_Libary_managment_System
{
    public partial class fromLogin : Form
    {
        public fromLogin()
        {
            InitializeComponent();
        }

        DBConnection1 dB = new DBConnection1();



        private void FLtextPasswored_TextChanged(object sender, EventArgs e)
        {
            FLtextPasswored.PasswordChar = '*';
        }



        private void FLbtnLogin_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FLtextUsername.Text) || string.IsNullOrWhiteSpace(FLtextPasswored.Text))
            {
                MessageBox.Show("please Enter valid User Name Or passowed");
            }
            else
            {
                string UserName = FLtextUsername.Text;//Lakvidu
                string Passwored = FLtextPasswored.Text;//Lakvidu@12

                string sql = $"SELECT USERNAME,UserRole,PASSWORD,USER_ID from UserTable WHERE USERNAME = '{UserName/*:Lakvdu*/}'And PASSWORD = '{Passwored/*Lakvidu@12*/}'";
                DataTable dt = dB.search(sql);



                if (dt.Rows.Count > 0)
                {
                    Systemcs.loggedInUser = dt.Rows[0][0].ToString();
                    Systemcs.loggedUserRole = dt.Rows[0][1].ToString();
                    Systemcs.loggedpassword = dt.Rows[0][2].ToString();
                    Systemcs.loggedUSER_ID = dt.Rows[0][3].ToString();


                    MessageBox.Show(Systemcs.loggedInUser, Systemcs.loggedUserRole);


                    // Login the User
                    DashBord d = new DashBord();
                    this.Hide();
                    d.Show();
                    Cheakattendence();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
            }
        }
        
        
        void Attendence()
        {
            string UserId = Systemcs.loggedUSER_ID;
            DateTime today = DateTime.Now;
            string sql = $"INSERT INTO  AttendanceTable VALUES ('{UserId}','{today}','Present');";
            bool result = dB.exuxquary(sql);
            if(result)
            {
                MessageBox.Show(today.ToString());
            }else
            {
                MessageBox.Show(UserId + "  Absent");
            }
        }
        void Cheakattendence()
        {
            string UserId = Systemcs.loggedUSER_ID;
            DateTime today = DateTime.Now;
            string sql = $"SELECT [Attendance Date] From  AttendanceTable Where User_Id='{UserId}' AND [Attendance Date]='{today}' ";
            DataTable dt = dB.search(sql);
            if (dt.Rows.Count < 1)
            {
                Attendence();
            }
            else
            { 
                MessageBox.Show("attendence Is Alredy Present ");
            }

        }

        private void FLtextUsername_MouseClick(object sender, MouseEventArgs e)
        {
            FLtextUsername.Clear();
        }

        private void FLtextPasswored_MouseClick(object sender, MouseEventArgs e)
        {
            FLtextPasswored.Clear();
        }

        private void FLlinklblForgrtpasswored_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPasswordf FP = new ForgetPasswordf();
            this.Hide();
            FP.Show();
        }



        private void fromLogin_Load(object sender, EventArgs e)
        {

        }

     

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
