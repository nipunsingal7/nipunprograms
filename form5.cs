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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user= txtUser.Text;
            string pwd = txtPwd.Text;
            String connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=pst.accdb";
            OleDbConnection conn = new OleDbConnection(connString);
            string q = "insert into register values('" + user + "','" + pwd + "')";
            OleDbCommand cmd = new OleDbCommand(q, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Registered");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 ob = new Form7();
            this.Hide();
            ob.ShowDialog();
        }
    }
}

