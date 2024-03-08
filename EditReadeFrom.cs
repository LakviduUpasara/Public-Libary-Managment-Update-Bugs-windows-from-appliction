using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Public_Libary_managment_System
{
    public partial class EditReadeFrom : Form
    {
        public EditReadeFrom()
        {
            InitializeComponent();
        }
        DBConnection1 DB = new DBConnection1();

        private void EditReadeFrom_Load(object sender, EventArgs e)
        {
            EditReaderbtn.Enabled = false;
            AddReaderbtn.Enabled = true;
            ViewReaderbtn.Enabled = true;
            textReaderId.Enabled = false;
            DeleteReaderbtn.Enabled = true;



        }
        private void ViewReaderbtn_Click(object sender, EventArgs e)
        {
            ViewReaderfrom viewReaderfrom = new ViewReaderfrom();
            viewReaderfrom.Show();
            this.Hide();
        }

        private void AddReaderbtn_Click(object sender, EventArgs e)
        {
            Reader_Managment reader_Managment = new Reader_Managment();
            reader_Managment.Show();
            this.Hide();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            DashBord dashBord = new DashBord();
            dashBord.Show();    
            this.Hide();
        }

       

        private void SearchBtn_Click(object sender, EventArgs e)
        {   if (string.IsNullOrWhiteSpace(textsearxh.Text))
            {
                MessageBox.Show("Please Enter Reader Id");
            }
            else
            { 
            string searchKey = textsearxh.Text;
            String Sql = $"SELECT * From ReaderDeatail WHERE Reader_ID ='{searchKey}'";
            DataTable dt = DB.search(Sql);
                if (dt.Rows.Count > 0)
                {
                    textReaderId.Text = dt.Rows[0][0].ToString();
                    textFullName.Text = dt.Rows[0][1].ToString();
                    textNIC.Text = dt.Rows[0][2].ToString();
                    DOBtext.Text = dt.Rows[0][3].ToString();
                    Religontext.Text = dt.Rows[0][4].ToString();
                    textMobile.Text = dt.Rows[0][5].ToString();
                    textHome.Text = dt.Rows[0][6].ToString();
                    textHomeaddress.Text = dt.Rows[0][8].ToString();
                    textWorkAddress.Text = dt.Rows[0][9].ToString();
                    textOccupation.Text = dt.Rows[0][7].ToString();
                    textGfullname.Text = dt.Rows[0][10].ToString();
                    textGnic.Text = dt.Rows[0][11].ToString();
                    textGaddress.Text = dt.Rows[0][12].ToString();
                    textGoccupation.Text = dt.Rows[0][13].ToString();
                    textGWorkaddress.Text = dt.Rows[0][14].ToString();
                    textGassessmentNo.Text = dt.Rows[0][15].ToString();
                    textGcontactNo.Text = dt.Rows[0][16].ToString();
                }else
                {
                    MessageBox.Show("Reader Id Is Invalied ");
                }
                
                

            }

        }

        private void DataGriedVewReaderDeatail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textsearxh_Click(object sender, EventArgs e)
        {
            textsearxh.Clear();
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            cl();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textReaderId.Text) &&
                string.IsNullOrWhiteSpace(textFullName.Text) &&
                string.IsNullOrWhiteSpace(textNIC.Text) &&
                string.IsNullOrWhiteSpace(DOBtext.Text) &&
                string.IsNullOrWhiteSpace(Religontext.Text) &&
                string.IsNullOrWhiteSpace(textMobile.Text) &&
                string.IsNullOrWhiteSpace(textHomeaddress.Text) &&
                string.IsNullOrWhiteSpace(textGfullname.Text) &&
                string.IsNullOrWhiteSpace(textGnic.Text) &&
                string.IsNullOrWhiteSpace(textGaddress.Text) &&
                string.IsNullOrWhiteSpace(textGassessmentNo.Text) &&
                string.IsNullOrWhiteSpace(textGcontactNo.Text))

            {

                MessageBox.Show("Please Enter Reder Id,full Name, NIC number,Date Of Brith ,Religion,Mobile,Home Address,Guarantor's Full Name,\r\nGuarantor's NIC ,Guarantor's Address,Guarantor's Assessment No ,Guarantor's Contact No");
            }
            else if (string.IsNullOrWhiteSpace(textReaderId.Text) ||
                string.IsNullOrWhiteSpace(textFullName.Text) ||
                string.IsNullOrWhiteSpace(textNIC.Text) ||
                string.IsNullOrWhiteSpace(DOBtext.Text) ||
                string.IsNullOrWhiteSpace(Religontext.Text) ||
                string.IsNullOrWhiteSpace(textMobile.Text) ||
                string.IsNullOrWhiteSpace(textHomeaddress.Text) ||
                string.IsNullOrWhiteSpace(textGfullname.Text) ||
                string.IsNullOrWhiteSpace(textGnic.Text) ||
                string.IsNullOrWhiteSpace(textGaddress.Text) ||
                string.IsNullOrWhiteSpace(textGassessmentNo.Text) ||
                string.IsNullOrWhiteSpace(textGcontactNo.Text))
            {
                if (string.IsNullOrWhiteSpace(textReaderId.Text))
                {
                    if (string.IsNullOrWhiteSpace(textFullName.Text))
                    {
                        MessageBox.Show("Please Enter Reader Id And Full Name");
                    }
                    else if (string.IsNullOrWhiteSpace(textNIC.Text))
                    {
                        MessageBox.Show("Please Enter Reader ID And NIC Number");
                    }
                    else if (string.IsNullOrWhiteSpace(DOBtext.Text))
                    {
                        MessageBox.Show("Please Enter Reader Id And DOB");
                    }
                    else if (string.IsNullOrWhiteSpace(Religontext.Text))
                    {
                        MessageBox.Show("Please Enter Reader Id And Religon ");
                    }
                    else if (string.IsNullOrWhiteSpace(textMobile.Text))
                    {
                        MessageBox.Show("Please Enter Reader Id And Mobile Number ");
                    }
                    else if (string.IsNullOrWhiteSpace(textHomeaddress.Text))
                    {
                        MessageBox.Show("Please Enter Reader Id And Home Address ");
                    }
                    else if (string.IsNullOrWhiteSpace(textGfullname.Text))
                    {

                        MessageBox.Show("Please Enter Reader Id And Guarantor's Full Name ");
                    }
                    else if (string.IsNullOrWhiteSpace(textGnic.Text))
                    {
                        MessageBox.Show("Please Enter Reader ID And Guarantor's NIC Number");
                    }
                    else if (string.IsNullOrWhiteSpace(textGaddress.Text))
                    {
                        MessageBox.Show("Please Enter Reader Id and Guarantor's Address ");
                    }
                    else if (string.IsNullOrWhiteSpace(textGassessmentNo.Text))
                    {
                        MessageBox.Show(" Please Enter Reader ID and Guarantor's Assessment No ");
                    }
                    else if (string.IsNullOrWhiteSpace(textGcontactNo.Text))
                    {
                        MessageBox.Show("please Enter Reader Id And  Guarantor's Contact  No");
                    }
                    else
                    {
                        MessageBox.Show("please Enter Reader Id ");
                    }


                }
                else if (string.IsNullOrWhiteSpace(textFullName.Text))
                {
                    if (string.IsNullOrWhiteSpace(textNIC.Text))
                    {
                        MessageBox.Show("Please Enter Reader Full Name And NIC Number");
                    }
                    else if (string.IsNullOrWhiteSpace(DOBtext.Text))
                    {
                        MessageBox.Show("Please Enter Reader Full NameAnd DOB");
                    }
                    else if (string.IsNullOrWhiteSpace(Religontext.Text))
                    {
                        MessageBox.Show("Please Enter Reader Full Name And Religon ");
                    }
                    else if (string.IsNullOrWhiteSpace(textMobile.Text))
                    {
                        MessageBox.Show("Please Enter Reader Full Name And Mobile Number ");
                    }
                    else if (string.IsNullOrWhiteSpace(textHomeaddress.Text))
                    {
                        MessageBox.Show("Please Enter Reader Full Name And Home Address ");
                    }
                    else if (string.IsNullOrWhiteSpace(textGfullname.Text))
                    {

                        MessageBox.Show("Please Enter Reader Full Name And Guarantor's Full Name ");
                    }
                    else if (string.IsNullOrWhiteSpace(textGnic.Text))
                    {
                        MessageBox.Show("Please Enter Reader Full Name And Guarantor's NIC Number");
                    }
                    else if (string.IsNullOrWhiteSpace(textGaddress.Text))
                    {
                        MessageBox.Show("Please Enter Reader Full Name and Guarantor's Address ");
                    }
                    else if (string.IsNullOrWhiteSpace(textGassessmentNo.Text))
                    {
                        MessageBox.Show(" Please Enter Reader Full Name and Guarantor's Assessment No ");
                    }
                    else if (string.IsNullOrWhiteSpace(textGcontactNo.Text))
                    {
                        MessageBox.Show("please Enter Reader Full Name And Guarantor's Guarantor's Contact  No");
                    }
                    else
                    {
                        MessageBox.Show("please Enter Reader Full Name ");
                    }
                }
                else if (string.IsNullOrWhiteSpace(DOBtext.Text))
                {
                    if (string.IsNullOrWhiteSpace(Religontext.Text))
                    {
                        MessageBox.Show("Please Enter Reader Date Of Brith  And Religon ");
                    }
                    else if (string.IsNullOrWhiteSpace(textMobile.Text))
                    {
                        MessageBox.Show("Please Enter Reader Date Of Brith And Mobile Number ");
                    }
                    else if (string.IsNullOrWhiteSpace(textHomeaddress.Text))
                    {
                        MessageBox.Show("Please Enter Reader Date Of Brith And Home Address ");
                    }
                    else if (string.IsNullOrWhiteSpace(textGfullname.Text))
                    {

                        MessageBox.Show("Please Enter Reader Date Of Brith And Guarantor's Full Name ");
                    }
                    else if (string.IsNullOrWhiteSpace(textGnic.Text))
                    {
                        MessageBox.Show("Please Enter Reader Date Of Brith And Guarantor's NIC Number");
                    }
                    else if (string.IsNullOrWhiteSpace(textGaddress.Text))
                    {
                        MessageBox.Show("Please Enter Reader Date Of Brith and Guarantor's Address ");
                    }
                    else if (string.IsNullOrWhiteSpace(textGassessmentNo.Text))
                    {
                        MessageBox.Show(" Please Enter Reader Date Of Brith and Guarantor's Assessment No ");
                    }
                    else if (string.IsNullOrWhiteSpace(textGcontactNo.Text))
                    {
                        MessageBox.Show("please Enter Reader Date Of Brith And Guarantor's  Guarantor's Contact  No");
                    }
                    else
                    {
                        MessageBox.Show("please Enter Reader Date Of Brith ");
                    }
                }
                else if (string.IsNullOrWhiteSpace(Religontext.Text))
                {
                    if (string.IsNullOrWhiteSpace(textMobile.Text))
                    {
                        MessageBox.Show("Please Enter Reader  Religon  And Mobile Number ");
                    }
                    else if (string.IsNullOrWhiteSpace(textHomeaddress.Text))
                    {
                        MessageBox.Show("Please Enter Reader  Religon  And Home Address ");
                    }
                    else if (string.IsNullOrWhiteSpace(textGfullname.Text))
                    {

                        MessageBox.Show("Please Enter Reader  Religon  And Guarantor's Full Name ");
                    }
                    else if (string.IsNullOrWhiteSpace(textGnic.Text))
                    {
                        MessageBox.Show("Please Enter Reader  Religon And Guarantor's NIC Number");
                    }
                    else if (string.IsNullOrWhiteSpace(textGaddress.Text))
                    {
                        MessageBox.Show("Please Enter Reader  Religon  and Guarantor's Address ");
                    }
                    else if (string.IsNullOrWhiteSpace(textGassessmentNo.Text))
                    {
                        MessageBox.Show(" Please Enter Reader  Religon and Guarantor's Assessment No ");
                    }
                    else if (string.IsNullOrWhiteSpace(textGcontactNo.Text))
                    {
                        MessageBox.Show("please Enter Reader  Religon  And  Guarantor's Contact  No");
                    }
                    else
                    {
                        MessageBox.Show("please Enter Reader Religon  ");
                    }
                }
                else if (string.IsNullOrWhiteSpace(textMobile.Text))
                {
                    if (string.IsNullOrWhiteSpace(textHomeaddress.Text))
                    {
                        MessageBox.Show("Please Enter Mobile Number  Religon  And Home Address ");
                    }
                    else if (string.IsNullOrWhiteSpace(textGfullname.Text))
                    {

                        MessageBox.Show("Please Enter Reader Mobile Number  And Guarantor's Full Name ");
                    }
                    else if (string.IsNullOrWhiteSpace(textGnic.Text))
                    {
                        MessageBox.Show("Please Enter Reader  Mobile Number And Guarantor's NIC Number");
                    }
                    else if (string.IsNullOrWhiteSpace(textGaddress.Text))
                    {
                        MessageBox.Show("Please Enter Reader  Mobile Number  and Guarantor's Address ");
                    }
                    else if (string.IsNullOrWhiteSpace(textGassessmentNo.Text))
                    {
                        MessageBox.Show(" Please Enter Reader Mobile Number and Guarantor's Assessment No ");
                    }
                    else if (string.IsNullOrWhiteSpace(textGcontactNo.Text))
                    {
                        MessageBox.Show("please Enter Reader  Mobile Number  And  Guarantor's Contact  No");
                    }
                    else
                    {
                        MessageBox.Show("please Enter Reader Mobile Number ");
                    }
                }
                else if (string.IsNullOrWhiteSpace(textHomeaddress.Text))
                {
                    if (string.IsNullOrWhiteSpace(textGfullname.Text))
                    {

                        MessageBox.Show("Please Enter Reader Home Address  And Guarantor's Full Name ");
                    }
                    else if (string.IsNullOrWhiteSpace(textGnic.Text))
                    {
                        MessageBox.Show("Please Enter Reader  Home Address And Guarantor's NIC Number");
                    }
                    else if (string.IsNullOrWhiteSpace(textGaddress.Text))
                    {
                        MessageBox.Show("Please Enter Reader  Home Address  and Guarantor's Address ");
                    }
                    else if (string.IsNullOrWhiteSpace(textGassessmentNo.Text))
                    {
                        MessageBox.Show(" Please Enter Reader Home Address and Guarantor's Assessment No ");
                    }
                    else if (string.IsNullOrWhiteSpace(textGcontactNo.Text))
                    {
                        MessageBox.Show("please Enter Reader  Home Address  And  Guarantor's Contact  No");
                    }
                    else
                    {
                        MessageBox.Show("please Enter Reader Home Address ");
                    }
                }
                else if (string.IsNullOrWhiteSpace(textGfullname.Text))
                {

                    // Guarantor's Full Name 
                    if (string.IsNullOrWhiteSpace(textGnic.Text))
                    {
                        MessageBox.Show("Please Enter  Guarantor's Full Name And Guarantor's NIC Number");
                    }
                    else if (string.IsNullOrWhiteSpace(textGaddress.Text))
                    {
                        MessageBox.Show("Please Enter  Guarantor's Full Name  and Guarantor's Address ");
                    }
                    else if (string.IsNullOrWhiteSpace(textGassessmentNo.Text))
                    {
                        MessageBox.Show(" Please Enter  Guarantor's Full Name and Guarantor's Assessment No ");
                    }
                    else if (string.IsNullOrWhiteSpace(textGcontactNo.Text))
                    {
                        MessageBox.Show("please Enter  Guarantor's Full Name And  Guarantor's Contact  No");
                    }
                    else
                    {
                        MessageBox.Show("please Enter Guarantor's Full Name ");
                    }
                }
                else if (string.IsNullOrWhiteSpace(textGnic.Text))
                {
                    //Guarantor's NIC Number
                    if (string.IsNullOrWhiteSpace(textGaddress.Text))
                    {
                        MessageBox.Show("Please Enter  Guarantor's NIC Number and Guarantor's Address ");
                    }
                    else if (string.IsNullOrWhiteSpace(textGassessmentNo.Text))
                    {
                        MessageBox.Show(" Please Enter  Guarantor's NIC Number and Guarantor's Assessment No ");
                    }
                    else if (string.IsNullOrWhiteSpace(textGcontactNo.Text))
                    {
                        MessageBox.Show("please Enter  Guarantor's NIC Number And  Guarantor's Contact  No");
                    }
                    else
                    {
                        MessageBox.Show("please Enter Guarantor's NIC Number ");
                    }
                }
                else if (string.IsNullOrWhiteSpace(textGaddress.Text))
                {   //Guarantor's Address
                    if (string.IsNullOrWhiteSpace(textGassessmentNo.Text))
                    {
                        MessageBox.Show(" Please Enter Guarantor's Address and Guarantor's Assessment No ");
                    }
                    else if (string.IsNullOrWhiteSpace(textGcontactNo.Text))
                    {
                        MessageBox.Show("please Enter  Guarantor's Address And Guarantor's Contact  No");
                    }
                    else
                    {
                        MessageBox.Show("please Enter Guarantor's Address ");
                    }

                }
                else if (string.IsNullOrWhiteSpace(textGassessmentNo.Text))
                {   //Guarantor's Assessment No
                    if (string.IsNullOrWhiteSpace(textGcontactNo.Text))
                    {
                        MessageBox.Show("please Enter  Guarantor's Assessment No And Guarantor's Assessment No");
                    }
                    else
                    {
                        MessageBox.Show("please Enter  Guarantor's Contact  No");
                    }
                }
            }
            else
            {
                string ReaderID = textReaderId.Text.Trim();
                string ReaderName = textFullName.Text.Trim();
                string ReaderNIC = textNIC.Text.Trim();
                string ReaderDOB = DOBtext.Text.Trim();
                string ReaderReligon = Religontext.Text.Trim();
                string ReadorMobile = textMobile.Text.Trim();
                string ReaderHome = textHome.Text.Trim();
                string RHomeAddress = textHomeaddress.Text.Trim();
                string RWorkAddress = textWorkAddress.Text.Trim();
                string ReaderOccupation = textOccupation.Text.Trim();
                string GFullName = textGfullname.Text.Trim();
                string GNIC = textGnic.Text.Trim();
                string GHomeAddress = textGaddress.Text.Trim();
                string Goccupation = textGoccupation.Text.Trim();
                string GworkAddress = textGWorkaddress.Text.Trim();
                string GAssessmentNo = textGassessmentNo.Text.Trim();
                string GcontactNumber = textGcontactNo.Text.Trim();

                string sql = $"UPDATE  ReaderDeatail SET [Reade Full_Name] = '{ReaderName}',[Reader NIC_Number]='{ReaderNIC}',[Reader Date_Of_Brith]='{ReaderDOB}',[Reader Religion]= '{ReaderReligon}',[Reader Contact_Number_Moblile]='{ReadorMobile}',[Reader Contact_Number_Home]='{ReaderHome}',[Reader Occupation]='{ReaderOccupation}',[Reader Home Address]='{RHomeAddress}',[Work Address]='{RWorkAddress}',[Guarantor's Full Name] ='{GFullName}',[Guarantor's NIC]='{GNIC}',[Guarantor's Address]='{GHomeAddress}',[Guarantor's Occupation]='{Goccupation}',[Guarantor's  Work Address]='{GworkAddress}',[Guarantor's Assessment No]='{GAssessmentNo}',[Guarantor's Contact No]='{GcontactNumber}' Where  Reader_ID = '{ReaderID}'";

                bool result = DB.exuxquary(sql);
                if (result)
                {
                    MessageBox.Show("sucssful");

                    cl();


                }
                else
                {
                    MessageBox.Show("unsucssful");

                }

            }










        }

        void cl()
        {
            textReaderId.Text = "";

            textFullName.Text = "";
            textNIC.Text = "";
            DOBtext.Text = "";
            Religontext.Text = "";
            textMobile.Text = "";
            textHome.Text = "";
            textHomeaddress.Text = "";
            textWorkAddress.Text = "";
            textOccupation.Text = "";
            textGfullname.Text = "";
            textGnic.Text = "";
            textGaddress.Text = "";
            textGoccupation.Text = "";
            textGWorkaddress.Text = "";
            textGassessmentNo.Text = "";
            textGcontactNo.Text = "";
        }

        private void DateOfBrith_ValueChanged(object sender, EventArgs e)
        {
            DOBtext.Text = DateOfBrith.Value.ToString("yyyy-MM-dd");
        }

        private void DeleteReaderbtn_Click(object sender, EventArgs e)
        {
            DeleateReader deleateReader = new DeleateReader();
            deleateReader.Show();
            this.Hide();
        }
    }
}
