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
    public partial class User_Profile_Managment : Form
    {
        public User_Profile_Managment()
        {
            InitializeComponent();
        }
        DBConnection1 con = new DBConnection1();    

        private void User_Profile_Managment_Load(object sender, EventArgs e)
        {
            UserNameDispla.Text = Systemcs.loggedInUser;
            UserRoleDisplaytext.Text = Systemcs.loggedUserRole;
            UserNameDispla.Enabled = false;
            UserRoleDisplaytext.Enabled = false;
            textRegNo.Enabled = false;
            textRegNo.Text = Systemcs.loggedUSER_ID;
            textDob.Enabled = false;
            string REGNO = textRegNo.Text.Trim();
            string sql = $"SELECT * FROM UserTable Where USER_ID='{REGNO}' ";
            DataTable dt = con.search(sql);

            if (dt.Rows.Count > 0)
            {
                string fristName = dt.Rows[0][2].ToString();
                textName.Text = fristName;
                string LastName = dt.Rows[0][3].ToString();
                textLastName.Text = LastName;
                string UserName = dt.Rows[0][4].ToString();
                textUsername.Text = UserName;

                string Passwored = dt.Rows[0][5].ToString();
                textPassword.Text = Passwored;
                string Nic = dt.Rows[0][1].ToString();
                textNIC.Text = Nic;
                string UserRole = dt.Rows[0][6].ToString();
                comboBox1.Text = UserRole;
                string Phone = dt.Rows[0][7].ToString(); ; textPhone.Text = Phone;
                string Dob = dt.Rows[0][8].ToString(); ; textDob.Text = Dob;
                string Address = dt.Rows[0][9].ToString(); ; textAddress.Text = Address;            
            }


        }



        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textName.Text) ||
             string.IsNullOrWhiteSpace(textAddress.Text) || string.IsNullOrWhiteSpace(textDob.Text) || string.IsNullOrWhiteSpace(textPhone.Text) ||
             string.IsNullOrWhiteSpace(comboBox1.Text) || string.IsNullOrWhiteSpace(textUsername.Text) || string.IsNullOrWhiteSpace(textPassword.Text)|| string.IsNullOrWhiteSpace(CMpassoword.Text))
            {
                MessageBox.Show("Please fill Your Detail");
            }
            else
            {
                string RegNo1 = textRegNo.Text;

                string Name = textName.Text.Trim();
                string LastName = textLastName.Text.Trim();
                string NIC = textNIC.Text.Trim();
                string Adress = textAddress.Text.Trim();
                string DOB = textDob.Text;
                string phone = textPhone.Text.Trim();
                string role = comboBox1.Text;
                string username = textUsername.Text.Trim();
                string password = textPassword.Text;
                string CMpasswored = CMpassoword.Text;
                   if(password== CMpasswored)
                    {
                        string Sql = $"UPDATE UserTable SET USER_ID='{RegNo1}',NIC='{NIC}',FRIST_NAME ='{Name}',LAST_NAME='{LastName}',USERNAME='{username}' ,PASSWORD='{CMpasswored}',UserRole= '{role}',Phone='{phone}',DOB='{DOB}',Adress ='{Adress}' Where USER_ID='{RegNo1}'";
                        bool result = con.exuxquary(Sql);
                        if (result)
                        {
                            MessageBox.Show("sucssful");

                       
                        }
                        else
                        {
                            MessageBox.Show("unsucssful");

                        }
                   }else
                {
                    MessageBox.Show("Passwod is defferent ,Cheack And Try again");
                }

                

            }
        }

        private void Dateofbirth_ValueChanged(object sender, EventArgs e)
        {
            textDob.Text = Dateofbirth.Value.ToString("yyyy-MM-dd");
        }

        private void textName_Click(object sender, EventArgs e)
        {
            textName.Clear();
        }

        private void textLastName_Click(object sender, EventArgs e)
        {
            textLastName.Clear();
        }

        private void textNIC_Click(object sender, EventArgs e)
        {
            textNIC.Clear();
        }

        private void textAddress_Click(object sender, EventArgs e)
        {
            textAddress.Clear();
        }

        private void textPhone_Click(object sender, EventArgs e)
        {
            textPhone.Clear();
        }

        private void textUsername_Click(object sender, EventArgs e)
        {
            textUsername.Clear();
        }

        private void textPassword_Click(object sender, EventArgs e)
        {
            textPassword.Clear();
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            textPassword.Text = "";
            
            textName.Text = "";
            textLastName.Text = "";
            textNIC.Text = "";
            textAddress.Text = "";
            textDob.Text = "";
            textPhone.Text = "";
            comboBox1.Text = "";
            textPassword.Text = "";
            textUsername.Text = "";
            CMpassoword.Text = "";
            textUsername.Text = "";
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            DashBord dashBord = new DashBord();
            this.Close();
            dashBord.Show();
        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {
           // textPassword.PasswordChar = '*';
        }

        private void CMpassoword_TextChanged(object sender, EventArgs e)
        {
            CMpassoword.PasswordChar = '*';
        }

        private void textName_MouseClick(object sender, MouseEventArgs e)
        { if (string.IsNullOrEmpty(textName.Text))
            {
                string REGNO = textRegNo.Text.Trim();
                string sql = $"SELECT * FROM UserTable Where USER_ID='{REGNO}' ";
                DataTable dt = con.search(sql);


                string fristName = dt.Rows[0][2].ToString();
                textName.Text = fristName;
                string LastName = dt.Rows[0][3].ToString();
                textLastName.Text = LastName;
                string UserName = dt.Rows[0][4].ToString();
                textUsername.Text = UserName;

                string Passwored = dt.Rows[0][5].ToString();
                textPassword.Text = Passwored;
                string Nic = dt.Rows[0][1].ToString();
                textNIC.Text = Nic;
                string UserRole = dt.Rows[0][6].ToString();
                comboBox1.Text = UserRole;
                string Phone = dt.Rows[0][7].ToString(); ; textPhone.Text = Phone;
                string Dob = dt.Rows[0][8].ToString(); ; textDob.Text = Dob;
                string Address = dt.Rows[0][9].ToString(); ; textAddress.Text = Address;
            }
            
        }
    }
}
