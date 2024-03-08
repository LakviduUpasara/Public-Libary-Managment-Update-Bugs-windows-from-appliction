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
    public partial class ViewReaderfrom : Form
    {
        public ViewReaderfrom()
        {
            InitializeComponent();
        }
        DBConnection1 DB = new DBConnection1();
        private void ViewReaderfrom_Load(object sender, EventArgs e)
        {
            ViewReaderbtn.Enabled = false;
            AddReaderbtn.Enabled=true; 
            EditReaderbtn.Enabled=true;
            DeleteReaderbtn.Enabled=true;
            loaddatatabale();
        }
        void loaddatatabale()
        {
            String Sql = "SELECT Top 10 * FROM ReaderDeatail ORDER BY Reader_ID DESC;";
            DataTable dt = DB.search(Sql);
            DataGriedVewReaderDeatail.DataSource = dt;


        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string searchKey = textsearxh.Text;
            String Sql = $"SELECT * From ReaderDeatail WHERE Reader_ID LIKE '%{searchKey}%' OR [Reade Full_Name] LIKE '%{searchKey}%' OR [Reader NIC_Number] LIKE'%{searchKey}%' OR [Reader Date_Of_Brith] LIKE '%{searchKey}%' OR [Reader Religion] LIKE '%{searchKey}%' OR [Reader Contact_Number_Moblile] LIKE '%{searchKey}%' OR [Reader Contact_Number_Home] LIKE '%{searchKey}%'OR [Reader Occupation] LIKE '%{searchKey}% 'OR [Reader Home Address] LIKE '%{searchKey}%'OR [Work Address] LIKE '%{searchKey}%'OR [Guarantor's Full Name] LIKE '%{searchKey}%'OR [Guarantor's NIC] LIKE '%{searchKey}%' OR [Guarantor's Address] LIKE '%{searchKey}%'" +
                $"OR [Guarantor's Occupation] LIKE '%{searchKey}%'OR [Guarantor's  Work Address] LIKE '%{searchKey}%'OR [Guarantor's Assessment No] LIKE '%{searchKey}%'OR [Guarantor's Contact No] LIKE '%{searchKey}%' OR [Book Avalible Count] LIKE '%{searchKey}%'";
            DataTable dt = DB.search(Sql);

            DataGriedVewReaderDeatail.DataSource = dt;
        }

        private void ViewReaderbtn_Click(object sender, EventArgs e)
        {
            Reader_Managment reader_Managment = new Reader_Managment();
            reader_Managment.Show();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            DashBord dashBord = new DashBord();
            dashBord.Show();
            this.Hide();
        }

        private void AddReaderbtn_Click(object sender, EventArgs e)
        {
            Reader_Managment reader_Managment = new Reader_Managment();
            reader_Managment.Show();
            this.Hide();

        }

        private void EditReaderbtn_Click(object sender, EventArgs e)
        {
            EditReadeFrom editReadeFrom = new EditReadeFrom();
            editReadeFrom.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddReaderbtn_Click_1(object sender, EventArgs e)
        {
            Reader_Managment RD = new Reader_Managment();
            RD.Show();
            this.Hide();
        }

        private void DeleteReaderbtn_Click(object sender, EventArgs e)
        {
            DeleateReader deleateReader = new DeleateReader();
            deleateReader.Show();
            this.Hide();
        }

        private void Refeshbtn_Click(object sender, EventArgs e)
        {
            loaddatatabale();
        }
    }
    
   
}
