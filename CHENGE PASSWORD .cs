using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Public_Libary_managment_System
{
    public partial class CHENGE_PASSWORD : Form
    {
        public CHENGE_PASSWORD()
        {
            InitializeComponent();
        }
        DBConnection1 DBConnection1 = new DBConnection1();

        private void textPassword_TextChanged(object sender, EventArgs e)
        {
            textPassword.PasswordChar = '*';
        }

        private void CMpassoword_TextChanged(object sender, EventArgs e)
        {
            CMpassoword.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textUsername.Text))
            {
                MessageBox.Show(" Please Enter User Name");

            }
            else if (string.IsNullOrWhiteSpace(textPassword.Text))
            {
                MessageBox.Show(" Please Enter  Password");
            }
            else if (string.IsNullOrWhiteSpace(CMpassoword.Text))
            {
                MessageBox.Show(" Please Confrom Your Password");
            }
            else
            {
                string USER_ID = Systemcs.FrogetUSER_ID;
                string username = textUsername.Text;
                string password = textPassword.Text;
                string CMpassword = CMpassoword.Text;

                if (password == CMpassword)
                {
                    string Sql = $"UPDATE UserTable SET USERNAME='{username}' ,PASSWORD='{CMpassword}' Where USER_ID='{USER_ID}'";
                    bool result = DBConnection1.exuxquary(Sql);
                    if (result)
                    {
                        MessageBox.Show("sucssful");
                        textPassword.Text = "";
                        textUsername.Text = "";
                        CMpassoword.Text = "";
                        Systemcs.FrogetUSER_ID = "";
                        this.Close();
                        fromLogin fromLogin  = new fromLogin();
                        fromLogin.Show();
                    }
                    else
                    {
                        MessageBox.Show("unsucssful");
                    }
                }
                else
                {
                    MessageBox.Show("Passwored is deferent");
                }
            }

        }

        private void CHENGE_PASSWORD_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ForgetPasswordf forgetPasswordf = new ForgetPasswordf();
            this.Close();
            forgetPasswordf.Show();
        }
    }
}
