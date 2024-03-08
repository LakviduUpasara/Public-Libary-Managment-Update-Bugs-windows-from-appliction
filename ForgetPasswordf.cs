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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Public_Libary_managment_System
{
    public partial class ForgetPasswordf : Form
    {
        public ForgetPasswordf()
        {
            InitializeComponent();
        }
        DBConnection1 Connection1 = new DBConnection1();
        private void ForgetPasswordf_Load(object sender, EventArgs e)
        {
            textDob.Enabled = false;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            fromLogin fromLogin = new fromLogin();
            fromLogin.Show();
            this.Close();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textRegNo.Text))
            {
                if (//string.IsNullOrWhiteSpace(textRegNo.Text)||
                    string.IsNullOrWhiteSpace(textName.Text) ||
                    string.IsNullOrWhiteSpace(textLastName.Text)||
                    string.IsNullOrWhiteSpace(textNIC.Text)||
                    string.IsNullOrWhiteSpace(textDob.Text)||
                    string.IsNullOrWhiteSpace(textAddress.Text)||
                   
                    string.IsNullOrWhiteSpace(textPhone.Text) )
                {

                    MessageBox.Show(" Some deatail Not Enterd ,Please cheack And fill it");

                }
                else
                {
                    MessageBox.Show(" Please Enter User Id");
                }
                

            }
            else if (string.IsNullOrWhiteSpace(textName.Text))
            {
                if (string.IsNullOrWhiteSpace(textRegNo.Text)||
                   // string.IsNullOrWhiteSpace(textName.Text) ||
                    string.IsNullOrWhiteSpace(textLastName.Text) ||
                    string.IsNullOrWhiteSpace(textNIC.Text) ||
                    string.IsNullOrWhiteSpace(textDob.Text) ||
                    string.IsNullOrWhiteSpace(textAddress.Text) ||

                    string.IsNullOrWhiteSpace(textPhone.Text))
                {
                    MessageBox.Show(" Some deatail Not Enterd ,Please cheack And fill it");
                }
                else
                {
                    MessageBox.Show(" Please Enter  Frist Name");
                }
               
            }
            else if (string.IsNullOrWhiteSpace(textLastName.Text))
            {
                if (string.IsNullOrWhiteSpace(textRegNo.Text) ||
                    string.IsNullOrWhiteSpace(textName.Text) ||
                   // string.IsNullOrWhiteSpace(textLastName.Text) ||
                    string.IsNullOrWhiteSpace(textNIC.Text) ||
                    string.IsNullOrWhiteSpace(textDob.Text) ||
                    string.IsNullOrWhiteSpace(textAddress.Text) ||
               
                    string.IsNullOrWhiteSpace(textPhone.Text))
                {
                    MessageBox.Show(" Some deatail Not Enterd ,Please cheack And fill it");
                }
                else
                {
                    MessageBox.Show(" Please Enter  Last Name");
                }
                
            }
            else if (string.IsNullOrWhiteSpace(textNIC.Text))
            {
                if (string.IsNullOrWhiteSpace(textRegNo.Text) ||
                    string.IsNullOrWhiteSpace(textName.Text) ||
                    string.IsNullOrWhiteSpace(textLastName.Text) ||
                   // string.IsNullOrWhiteSpace(textNIC.Text) ||
                    string.IsNullOrWhiteSpace(textDob.Text) ||
                    string.IsNullOrWhiteSpace(textAddress.Text) ||
                  
                    string.IsNullOrWhiteSpace(textPhone.Text))
                {
                    MessageBox.Show(" Some deatail Not Enterd ,Please cheack And fill it");
                }
                else
                {
                    MessageBox.Show(" Please Enter  NIC Number");
                }
                
            }
            else if (string.IsNullOrWhiteSpace(textDob.Text))
            {
                if (string.IsNullOrWhiteSpace(textRegNo.Text) ||
                    string.IsNullOrWhiteSpace(textName.Text) ||
                     string.IsNullOrWhiteSpace(textLastName.Text) ||
                    string.IsNullOrWhiteSpace(textNIC.Text) ||
                    //string.IsNullOrWhiteSpace(textDob.Text) ||
                    string.IsNullOrWhiteSpace(textAddress.Text) ||
                    
                    string.IsNullOrWhiteSpace(textPhone.Text))
                {
                    MessageBox.Show(" Some deatail Not Enterd ,Please cheack And fill it");
                }
                else
                {
                    MessageBox.Show(" Select Your date of Brith");
                }
                
            }
            else if (string.IsNullOrWhiteSpace(textAddress.Text))
            {
                if (string.IsNullOrWhiteSpace(textRegNo.Text) ||
                    string.IsNullOrWhiteSpace(textName.Text) ||
                     string.IsNullOrWhiteSpace(textLastName.Text) ||
                    string.IsNullOrWhiteSpace(textNIC.Text) ||
                    string.IsNullOrWhiteSpace(textDob.Text) ||
                   // string.IsNullOrWhiteSpace(textAddress.Text) ||
                   
                    string.IsNullOrWhiteSpace(textPhone.Text))
                {
                    MessageBox.Show(" Some deatail Not Enterd ,Please cheack And fill it");
                }
                else
                {
                    MessageBox.Show(" Please Enter your Address");
                }
               
            }
            else if (string.IsNullOrWhiteSpace(textPhone.Text))
            {
                if (string.IsNullOrWhiteSpace(textRegNo.Text) ||
                    string.IsNullOrWhiteSpace(textName.Text) ||
                     string.IsNullOrWhiteSpace(textLastName.Text) ||
                    string.IsNullOrWhiteSpace(textNIC.Text) ||
                    string.IsNullOrWhiteSpace(textDob.Text) ||
                    string.IsNullOrWhiteSpace(textAddress.Text) )
                  
                   
                   
                {
                    MessageBox.Show(" Some deatail Not Enterd ,Please cheack And fill it");
                }
                else
                {
                    MessageBox.Show(" Please Enter your Contact Number");
                }
               
            }
            else
            {
                string REGNO = textRegNo.Text;
                string name = textName.Text;
                string lastName = textLastName.Text;
                string NIC = textNIC.Text;
                string dob = textDob.Text;
                string address = textAddress.Text;
                string phone = textPhone.Text;
                string sql = $"SELECT * FROM UserTable Where USER_ID='{REGNO}' And NIC='{NIC}'And FRIST_NAME ='{name}'And LAST_NAME='{lastName}'And Phone='{phone}'And DOB='{dob}'And Adress ='{address}'";
                DataTable dt = Connection1.search(sql);
                if (dt.Rows.Count > 0)
                {
                    CHENGE_PASSWORD cHENGE_PASSWORD = new CHENGE_PASSWORD();
                    cHENGE_PASSWORD.Show();
                    this.Hide();
                    Systemcs.FrogetUSER_ID = REGNO;
                }
                else
                {
                    MessageBox.Show(" Your Deatail is wrong");
                }
            }
        }

        private void Dateofbirth_ValueChanged_1(object sender, EventArgs e)
        {
            textDob.Text = Dateofbirth.Value.ToString("yyyy-MM-dd");
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            textRegNo.Text = "";
            textName.Text = "";
            textLastName.Text = "";
            textNIC.Text = "";
            textAddress.Text = "";
            textDob.Text = "";
            textPhone.Text = "";
            Systemcs.FrogetUSER_ID = "";



        }
    }
}
