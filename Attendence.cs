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
    public partial class Attendence : Form
    {
        public Attendence()
        {
            InitializeComponent();
        }
        DBConnection1 con = new DBConnection1();

        private void Attendence_Load(object sender, EventArgs e)
        {
            LoadAttendence();
        }
        void LoadAttendence ()
        {
            string sql = "SELECT Ut.USER_ID,Ut.FRIST_NAME,Ut.LAST_NAME,AT.[Attendance Date],AT.[Attendence Statement] FROM AttendanceTable AT Join UserTable Ut On Ut.USER_ID=AT.User_Id ORDER BY AT.[Attendance Date] DESC ;";
            DataTable dt = con.search(sql);
            Attendenceview.DataSource = dt;
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            sbtn();
        }
        void sbtn()
        {
            string serchKey = textserch.Text;
            string saql = $"SELECT Ut.USER_ID,Ut.FRIST_NAME,Ut.LAST_NAME,AT.[Attendance Date],AT.[Attendence Statement] FROM AttendanceTable AT Join UserTable Ut On Ut.USER_ID=AT.User_Id WHERE Ut.USER_ID LIKE '{serchKey}'OR  Ut.FRIST_NAME LIKE '{serchKey}' OR Ut.LAST_NAME LIKE  '{serchKey}'  OR AT.[Attendance Date] LIKE '{serchKey}' OR AT.[Attendence Statement] LIKE '{serchKey}';";
            DataTable dt = con.search(saql);
            Attendenceview.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadAttendence();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            DashBord dashBord = new DashBord();
            dashBord.Show();
            this.Close();
        }
    }
}
