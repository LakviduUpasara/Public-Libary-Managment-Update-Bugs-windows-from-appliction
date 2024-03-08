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
    public partial class viewBookDeatail : Form
    {
        public viewBookDeatail()
        {
            InitializeComponent();
        }
        DBConnection1 DB = new DBConnection1();
        private void viewBookDeatail_Load(object sender, EventArgs e)
        {
            bOOKdEATAILTABALE();
        }
     
    } 
}
