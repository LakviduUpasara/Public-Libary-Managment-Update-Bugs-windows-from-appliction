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
    public partial class Reader_Managment : Form
    {
        public Reader_Managment()
        {
            InitializeComponent();
        }
        DBConnection1 con = new DBConnection1();    
        private void ManageUserProfilebtn_Click(object sender, EventArgs e)
        {

        }

        private void DateOfBrith_ValueChanged(object sender, EventArgs e)
        {
            DOBtext.Text = DateOfBrith.Value.ToString("yyyy-MM-dd");
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
            } else
            {
                string ReaderID= textReaderId.Text.Trim();
                string ReaderName=textFullName.Text.Trim();
                string ReaderNIC= textNIC.Text.Trim(); 
                string ReaderDOB=DOBtext.Text.Trim();
                string ReaderReligon=Religontext.Text.Trim();
                string ReadorMobile= textMobile.Text.Trim();
                string ReaderHome = textHome.Text.Trim();
                string RHomeAddress= textHomeaddress.Text.Trim();
                string RWorkAddress=textWorkAddress.Text.Trim();
                string ReaderOccupation= textOccupation.Text.Trim();
                string GFullName=textGfullname.Text.Trim();
                string GNIC =textGnic.Text.Trim();  
                string GHomeAddress= textGaddress.Text.Trim();
                string Goccupation= textGoccupation.Text.Trim();
                string GworkAddress=textGWorkaddress.Text.Trim();
                string GAssessmentNo= textGassessmentNo.Text.Trim();
                string GcontactNumber=textGcontactNo.Text.Trim();

                string sql = $"INSERT INTO ReaderDeatail(Reader_ID,[Reade Full_Name],[Reader NIC_Number],[Reader Date_Of_Brith],[Reader Religion],[Reader Contact_Number_Moblile],[Reader Contact_Number_Home],[Reader Occupation],[Reader Home Address],[Work Address],[Guarantor's Full Name],[Guarantor's NIC],[Guarantor's Address],[Guarantor's Occupation],[Guarantor's  Work Address],[Guarantor's Assessment No],[Guarantor's Contact No],[Book Avalible Count])Values ('{ReaderID}','{ReaderName}','{ReaderNIC}','{ReaderDOB}','{ReaderReligon}','{ReadorMobile}','{ReaderHome}','{ReaderOccupation}','{RHomeAddress}','{RWorkAddress}','{GFullName}','{GNIC}','{GHomeAddress}','{Goccupation}','{GworkAddress}','{GAssessmentNo}','{GcontactNumber}','2')";

                bool result = con.exuxquary(sql);
                if (result)
                {
                    MessageBox.Show("sucssful");

                    Clear();


                }
                else
                {
                    MessageBox.Show("unsucssful");

                }

            }


        }

        private void Reader_Managment_Load(object sender, EventArgs e)
        {
            AddReader.Enabled = false;
            EditReader.Enabled = true;
            ViewReader.Enabled = true;
            DeleteReaderbtn.Enabled = true;


        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void ViewReader_Click(object sender, EventArgs e)
        {
            ViewReaderfrom viewReaderfrom = new ViewReaderfrom();
            viewReaderfrom.Show();
            this.Hide();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            DashBord dashBord = new DashBord();
            dashBord.Show();
            this.Hide();
        }

        private void EditReader_Click(object sender, EventArgs e)
        {
            EditReadeFrom editReaderfrom = new EditReadeFrom();
            editReaderfrom.Show();
            this.Hide();
        }

        private void DeleteReaderbtn_Click(object sender, EventArgs e)
        {
            DeleateReader deleateReader = new DeleateReader();
            deleateReader.Show();
            this.Hide();
        }
        void Clear()
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
    }
}
