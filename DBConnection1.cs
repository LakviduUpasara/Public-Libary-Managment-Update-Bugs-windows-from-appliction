using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Public_Libary_managment_System
{
    internal class DBConnection1
    {
        SqlConnection con;

        //Data base connection

        private void open()
        {
            string conStr = "Data Source=DESKTOP-LSNIRL8;Initial Catalog=\"Libary Manament System\";Integrated Security=True;Encrypt=False";
            con = new SqlConnection(conStr);
            con.Open();
        }
        public void close()
        {
            con.Close();
        }

        public DataTable search(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                this.open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.close();
            }
            return dt;
        }
        public bool exuxquary(string sql)
        {
            bool Success = false;
            try
            {
                this.open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    Success = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.close();
            }
            return Success;
        }






    }
}
