using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IQ
{
    public partial class Form6 : Form
    {

        public Form6()
        {
           
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pwd = txtPwd.Text;
            String connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=pst.accdb";
            OleDbConnection conn = new OleDbConnection(connString);
            string q = "select * from register";
	    OleDbCommand cmd = new OleDbCommand(q, conn);
            conn.Open();
            OleDbDataReader rdr = cmd.ExecuteReader();
           
 
            int flag = 0;
            while (rdr.Read())
            {
                if(user.Equals(rdr.GetString(0)) && pwd.Equals(rdr.GetString(1)))
                {
                    flag=1;
                }
            }
        
            else
            {
                MessageBox.Show("invalid username or password");
            }


            
        }
    }
}


