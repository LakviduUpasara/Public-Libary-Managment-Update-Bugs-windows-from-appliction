using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Public_Libary_managment_System
{
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
        }
        DBConnection1 con = new DBConnection1();
        private void CreateUser_Load(object sender, EventArgs e)
        {
            //.DoubleClick += dobleclickbtn1.DoubleClick;
            dDBUP.DoubleClick += DDBUP_DoubleClick;
            //Enabale and visable
            Enteridlbl.Visible = false; panel13.Visible = false;
            btnSave.Visible = true;
            textPassword.Enabled = false;
            textDob.Enabled = false;
            textRegNo.Enabled = false;
            AddUser.Enabled = false;
            UpdateSave.Enabled = false; UpdateSave.Visible = false;
            Delete.Enabled = false; Delete.Visible= false;
            dDBUP.Visible = false;
            btnSave.Enabled = true;
            Cansel.Enabled = false; Cansel.Visible = false;
           //Enterlbl.Visible = false;
            textEnterId.Visible = false;
            button1.Visible = false;
            AutoIdNumber();
            loaddatatabale();
            //User Role Display
            UserNameDispla.Text = Systemcs.loggedInUser;
            UserRoleDisplaytext.Text = Systemcs.loggedUserRole;
            
        }

        private void DDBUP_DoubleClick(object sender, EventArgs e)
        {
            string Sql = $"DELETE FROM UserTable  Where USER_ID ='{RegNO}'";
            bool result = con.exuxquary(Sql);

            if (result)
            {
                MessageBox.Show("sucssful");

                clear();
            
               
                loaddatatabale();
            }
            else
            {
                MessageBox.Show("unsucssful");
            }
            Delete.Visible = true; Delete.Enabled = true;
            dDBUP.Enabled = false; dDBUP.Visible = false;
            Cansel.Enabled = false;Cansel.Visible = false;
        }
        void clear()
        {
            textRegNo.Text = "";
            textEnterId.Text = "";
            textName.Text = "";
            textLastName.Text = "";
            textNIC.Text = "";
            textAddress.Text = "";
            textDob.Text = "";
            textPhone.Text = "";
            comboBox1.Text = "";
        }


        string  UserID;
        int RegAdd;
       private void AutoIdNumber()
        {

            String Sql1 = "SELECT Top 1  * FROM UserTable ORDER BY USER_ID DESC;";
            DataTable UPDATEREGNO = con.search(Sql1);
            if(UPDATEREGNO.Rows.Count > 0)
            {
                string REGNO = UPDATEREGNO.Rows[0][0].ToString();
                int RegNoInt= Convert.ToInt32(REGNO);
                int RegAdd = RegNoInt +1;
                UserID = RegAdd.ToString();
                textRegNo.Text = RegAdd.ToString();

            } else
            {
                 RegAdd = 2001;
                 textRegNo.Text = RegAdd.ToString();
            }
        }

        private void datagrideviewsUserTabale_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagrideviewsUserTabale.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                RegNO = datagrideviewsUserTabale.Rows[e.RowIndex].Cells[0].Value.ToString();
                textRegNo.Text = RegNO;
            }
        }
         void loaddatatabale()
        {
            String Sql = "SELECT Top 10 * FROM UserTable ORDER BY USER_ID DESC;";
            DataTable dt = con.search(Sql);
            datagrideviewsUserTabale.DataSource = dt;
            datagrideviewsUserTabale.Columns["USERNAME"].Visible = false;
            datagrideviewsUserTabale.Columns["PASSWORD"].Visible=false;
         
        }
        string UseName;
        string Password;

        private void btnSave_Click(object sender, EventArgs e)
        {
            AutoIdNumber();
            if (string.IsNullOrWhiteSpace(textRegNo.Text)|| string.IsNullOrWhiteSpace(textName.Text)||
               string.IsNullOrWhiteSpace(textAddress.Text) || string.IsNullOrWhiteSpace(textDob.Text)|| string.IsNullOrWhiteSpace(textPhone.Text)||
               string.IsNullOrWhiteSpace(comboBox1.Text)|| string.IsNullOrWhiteSpace(textUsername.Text))
            {
                MessageBox.Show("Please Enter Your Deatail");   
            }
            else
            {
                string RegNo1 = textRegNo.Text;
                string Name = textName.Text.Trim();
                string LastName = textLastName.Text.Trim();
                string NIC = textNIC.Text.Trim();
                string Adress = textAddress.Text.Trim();
                string DOB = textDob.Text;
                UseName = textUsername.Text;
                int MKPassword= Convert.ToInt32(UserID);
                if (RegAdd == 2001)
                {
                   int  Password1 = RegAdd + 1111;
                    Password= Password1 +"@"+ RegAdd.ToString();

                }else
                {
                   MKPassword = MKPassword + 1111 ;
                  Password = MKPassword + "@" + textRegNo.Text.ToString();
                }
               
                textPassword.Text = Password;
                string phone = textPhone.Text.Trim();
                string role = comboBox1.Text;
                string Sql = $"INSERT INTO UserTable (USER_ID,NIC,FRIST_NAME,LAST_NAME,USERNAME,PASSWORD,UserRole,Phone,DOB,Adress)Values('{RegNo1}','{NIC}','{Name}','{LastName}','{UseName}','{Password}','{role}','{phone}','{DOB}','{Adress}')";
                bool result = con.exuxquary(Sql);
                if (result)
                {
                     MessageBox.Show("sucssful");
                     MessageBox.Show("User Name " + UseName + "and "
                        + "Password Is" + Password);

                    textEnterId.Text = "";
                    textRegNo.Text = "";
                    textName.Text = "";
                    textLastName.Text = "";
                    textNIC.Text = "";
                    textAddress.Text = "";
                    textDob.Text = "";
                    textPhone.Text = "";
                    comboBox1.Text = "";
                    textPassword.Text= "";
                    textUsername.Text= "";
                    AutoIdNumber();
                    loaddatatabale();
                }
                else
                {
                    MessageBox.Show("unsucssful");

                }
            }
        }
        private void Dateofbirth_ValueChanged(object sender, EventArgs e)
        {
            textDob.Text = Dateofbirth.Value.ToString("yyyy-MM-dd");
        }
            string RegNO;
    private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnSave.Visible = false;
            textEnterId.Visible = true;
            //Enterlbl.Visible = true;
            button1.Visible = true;
            panel1.Visible = true; panel2.Visible=false;
            textRegNo.Clear();
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            textUsername.Enabled = true;
            //button1.Visible = false;
            btnSave.Visible = true;
            //textEnterId.Visible = false; Enterlbl.Visible=false;
                            
            panel1.Visible = true;
            panel2.Visible = true;
        }
        string UserName ;
        String Passwored;
        private void button1_Click_1(object sender, EventArgs e)
        {
            
            string ENTERID = textEnterId.Text.Trim();
            string sql = $"SELECT * FROM UserTable Where USER_ID='{ENTERID}' ";
            DataTable dt = con.search(sql);
           
                
                if (dt.Rows.Count > 0)
                {
                    datagrideviewsUserTabale.DataSource = dt;
                    panel2.Visible = true; panel1.Visible = true;
                    
                    string fristName = dt.Rows[0][2].ToString();
                    textName.Text = fristName;
                    string LastName = dt.Rows[0][3].ToString();
                    textLastName.Text = LastName;
                    UserName = dt.Rows[0][4].ToString();
                    Passwored = dt.Rows[0][5].ToString();
                    string Nic = dt.Rows[0][1].ToString();
                    textNIC.Text = Nic;
                    string UserRole = dt.Rows[0][6].ToString();
                    comboBox1.Text = UserRole;
                    string Phone = dt.Rows[0][7].ToString(); ; textPhone.Text = Phone;
                    string Dob = dt.Rows[0][8].ToString(); ; textDob.Text = Dob;
                    string Address = dt.Rows[0][9].ToString(); ; textAddress.Text = Address;
                    textRegNo.Text = ENTERID;
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(textEnterId.Text))
                    {
                        MessageBox.Show("Please Enter User Id");
                        loaddatatabale();
                    }
                    else
                    {   
                        textName.Text = "";
                        textLastName.Text = "";
                        textNIC.Text = "";
                        comboBox1.Text = "";
                        textPhone.Text = "";
                        textDob.Text = "";
                        textAddress.Text = "";
                        MessageBox.Show("User ID Id Is Invalid");
                    }
                }
        }

        private void UpdateSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textRegNo.Text) || string.IsNullOrEmpty(textName.Text) ||
              string.IsNullOrEmpty(textAddress.Text) || string.IsNullOrEmpty(textDob.Text) || string.IsNullOrEmpty(textPhone.Text) ||
              string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Please Enter Your Deatail");
            }
            else
            {
                string RegNo1 = textRegNo.Text;
                string Name = textName.Text.Trim();
                string LastName = textLastName.Text.Trim();
                string NIC = textNIC.Text.Trim();
                string Adress = textAddress.Text.Trim();
                string DOB = textDob.Text;
              //  string UseName = textName.Text.Trim() + Dateofbirth.Value.ToString("yyyy");
               // string Password = UseName;
                string phone = textPhone.Text.Trim();
                string role = comboBox1.Text;
                string Sql = $"UPDATE UserTable SET NIC='{NIC}',FRIST_NAME ='{Name}',LAST_NAME='{LastName}',UserRole= '{role}',Phone='{phone}',DOB='{DOB}',Adress ='{Adress}' Where USER_ID='{RegNo1}'"; 
                bool result = con.exuxquary(Sql);

                if (result)
                {
                    MessageBox.Show("sucssful");
                    //MessageBox.Show("User Name :-" + UseName + "/n"
                    //+ "Password :-" + Password);
                    
                    textRegNo.Text = "";
                    textEnterId.Text = "";
                    textName.Text = "";
                    textLastName.Text = "";
                    textNIC.Text = "";
                    textAddress.Text = "";
                    textDob.Text = "";
                    textPhone.Text = "";
                    comboBox1.Text = "";
                    //AutoIdNumber();
                    loaddatatabale();
               }
                else
                {
                    MessageBox.Show("unsucssful");
                }
            }
        }

        private void Dateofbirth_ValueChanged_1(object sender, EventArgs e)
        {
            textDob.Text= Dateofbirth.Value.ToString("yyyy-MM-dd");
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textName.Text) &&
              string.IsNullOrWhiteSpace(textAddress.Text) &&string.IsNullOrWhiteSpace(textDob.Text) && string.IsNullOrWhiteSpace(textPhone.Text) &&
              string.IsNullOrWhiteSpace(comboBox1.Text) && string.IsNullOrWhiteSpace(textUsername.Text)&& string.IsNullOrWhiteSpace(textPassword.Text))
            {
                MessageBox.Show("No Fill Deatail");
            }
            else
            {
                textName.Text = "";
                textLastName.Text = "";
                textNIC.Text = "";
                textAddress.Text = "";
                textDob.Text = "";
                textPhone.Text = "";
                comboBox1.Text = "";
                UseName = "";
                Password = "";
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            textEnterId.Visible = true;
            //Enterlbl.Visible = true;
            button1.Visible = true;
            panel1.Visible = true; panel2.Visible = false;
            textRegNo.Clear();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            DashBord dashBord = new DashBord();
            this.Hide();
            dashBord.Show();
        }

       
        private void textUsername_MouseClick(object sender, MouseEventArgs e)
        {
            textUsername.Clear();
        }

        private void EditUserDeatailbtn_Click(object sender, EventArgs e)
        {
            Enteridlbl.Visible = true; panel13.Visible = true;
            UpdateSave.Visible = true;
            textRegNo.Text = "";
            //enabale true
            AddUser.Enabled = true;
            DeleteUserDeatail.Enabled = true;
           // DeleteUserDeatail.Enabled = true;
            UpdateSave.Enabled = true;
            //visabale true
            UpdateSave.Visible = true;
            Enteridlbl.Visible = true;
            textEnterId.Visible = true;
            button1.Visible = true;
             //visable false
            UPPANAL.Visible = false;
            btnSave.Visible = false;
            //disable btn
            EditUserDeatailbtn.Enabled = false;
            btnSave.Enabled = false;
            Delete.Enabled=  false; Delete.Visible = false;
            dDBUP.Visible = false;


        }

        private void AddUser_Click_1(object sender, EventArgs e)
        {
            loaddatatabale();
            AutoIdNumber();
            //visable true
            UPPANAL.Visible = true;
            btnSave.Visible = true;
            //enable False
            AddUser.Enabled = false;
            button1.Visible = false;
            UpdateSave.Enabled = false;
            Enteridlbl.Visible = false; panel13.Visible = false;
            //Enable true
            EditUserDeatailbtn.Enabled= true;
            DeleteUserDeatail.Enabled= true;
            btnSave.Enabled= true;
            textEnterId.Visible = false;
             //Enterlbl.Visible=false;
            Delete.Visible = false;
            UpdateSave.Visible = false;
            textEnterId.Visible = false;
            dDBUP.Visible= false;

        }

        private void DeleteUserDeatail_Click(object sender, EventArgs e)
        {    //disabale
            DeleteUserDeatail.Enabled = false;
            UpdateSave.Enabled= false;
            btnSave.Enabled=false;
            //enable
            AddUser.Enabled = true;
            EditUserDeatailbtn.Enabled = true;
            
            Delete.Enabled= true;
            Enteridlbl.Visible = true;
            textEnterId.Visible=true;
            button1.Visible=true;

            //Dobole Click
            dDBUP.Visible = false;
            Delete.Visible = true;






        }

        private void Delete_Click_1(object sender, EventArgs e)
        {

            Enteridlbl.Visible = true; panel13.Visible = true;
            string   Fillbtn  =textRegNo.Text;
            string sql = $"SELECT * FROM UserTable Where USER_ID='{Fillbtn}' ";
            DataTable dt = con.search(sql);


            if (dt.Rows.Count > 0)
            {
                if (Systemcs.loggedUSER_ID == Fillbtn)

                {
                     MessageBox.Show("You can't Deleate this Profile .you Are Alredy Loged this Profile");
                }
                    
                if (dt.Rows.Count > 1)
                    datagrideviewsUserTabale.DataSource = dt;
                panel2.Visible = true; panel1.Visible = true;

                string fristName = dt.Rows[0][2].ToString();
                textName.Text = fristName;
                string LastName = dt.Rows[0][3].ToString();
                textLastName.Text = LastName;
                UserName = dt.Rows[0][4].ToString();
                Passwored = dt.Rows[0][5].ToString();
                string Nic = dt.Rows[0][1].ToString();
                textNIC.Text = Nic;
                string UserRole = dt.Rows[0][6].ToString();
                comboBox1.Text = UserRole;
                string Phone = dt.Rows[0][7].ToString(); ; textPhone.Text = Phone;
                string Dob = dt.Rows[0][8].ToString(); ; textDob.Text = Dob;
                string Address = dt.Rows[0][9].ToString(); ; textAddress.Text = Address;
                dDBUP.Visible = true; dDBUP.Enabled = true;
                Delete.Visible = false;
                UpdateSave.Visible = false;
                Cansel.Visible = true;Cansel.Enabled = true;

            }
            else
            {
                MessageBox.Show("User Id Not Select");
            }

            dDBUP.Enabled = true;

        }

  

        private void Cansel_Click(object sender, EventArgs e)
        {
            Clearbtn.Enabled = true; Clearbtn.Visible = true;
            Cansel.Visible = false; Cansel.Enabled = false;
            dDBUP.Enabled = false; dDBUP.Visible=false;
            Delete.Enabled = true; Delete.Visible=true;
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            String Sql;
            string searchKey = textsearch.Text;
            if(int.TryParse(searchKey, out int searchId))
            {
                Sql = $"SELECT * From UserTable WHERE USER_ID={searchId} OR NIC LIKE '%{searchKey}%'";
            }
            else
            {
                Sql = $"SELECT * From UserTable WHERE NIC LIKE '%{searchKey}%' OR FRIST_NAME LIKE '%{searchKey}%' OR LAST_NAME LIKE '%{searchKey}%'";
            }

            DataTable dt = con.search(Sql);  

            datagrideviewsUserTabale.DataSource = dt;

        }
    }
}