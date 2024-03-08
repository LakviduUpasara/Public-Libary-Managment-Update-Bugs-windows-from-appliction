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

namespace Public_Libary_managment_System
{
    public partial class DeleateReader : Form
    {
        public DeleateReader()
        {
            InitializeComponent();
        }
        DBConnection1 DB = new DBConnection1();
        private void DeleateReader_Load(object sender, EventArgs e)
        {
            confrom.DoubleClick += Confrom_DoubleClick;
          
            EditReaderbtn.Enabled = true;
            AddReaderbtn.Enabled = true;
            ViewReaderbtn.Enabled = true;
            DeleteReaderbtn.Enabled = false;
            confrom.Visible = false;
        }

        private void Confrom_DoubleClick(object sender, EventArgs e)
        {
            if (ABook == 0)
            {
                MessageBox.Show("you can't Deleate This reader Beacuse Reader Not Return Some Book");
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
            else
            {
                string ReaderID = textReaderId.Text.Trim();
                string Sql1 = $"DELETE FROM ReaderDeatail  Where Reader_ID ='{ReaderID}'";
                bool result = DB.exuxquary(Sql1);
                if (result)
                {
                    MessageBox.Show("sucssful");

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
                else
                {
                    MessageBox.Show("unsucssful");

                }

            }
            confrom.Visible = false;
            Delete.Visible = true;
        }



        int ABook;
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textsearxh.Text))
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
                    string AvalibaleBook = dt.Rows[0][17].ToString();
                    ABook= Convert.ToInt32(AvalibaleBook);
                }
                else
                {
                    MessageBox.Show("Reader Id Is Invalied ");
                }



            }

        }

        private void EditReaderbtn_Click(object sender, EventArgs e)
        {
            EditReadeFrom editReadeFrom = new EditReadeFrom();
            editReadeFrom.Show();
            this.Hide();
        }

        private void AddReaderbtn_Click(object sender, EventArgs e)
        {
            Reader_Managment reader_Managment = new Reader_Managment();
            reader_Managment.Show();
            this.Hide();
        }

        private void ViewReaderbtn_Click(object sender, EventArgs e)
        {
            ViewReaderfrom reader_from = new ViewReaderfrom();
            reader_from.Show();
            this.Hide();
        }

        private void textsearxh_Click(object sender, EventArgs e)
        {
            textsearxh.Clear();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textReaderId.Text))
            {
                MessageBox.Show("please Enter Reader Id");
            }
            else
            {
                string searchKey = textReaderId.Text;
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
                    string AvalibaleBook = dt.Rows[0][17].ToString();
                    ABook = Convert.ToInt32(AvalibaleBook);
                    Delete.Visible = false;
                    confrom.Visible = true;
                }
                else
                {
                    MessageBox.Show("Reader Id Is Invalied ");
                }
            }

           



        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            DashBord dashBord = new DashBord();
            dashBord.Show();
            this.Hide();
        }

        private void Clearbtn_Click(object sender, EventArgs e)
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
    }
}
