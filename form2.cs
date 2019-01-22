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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String fname = txtFname.Text;
            String lname = txtLname.Text;
            String connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=upes.accdb";
            OleDbConnection conn = new OleDbConnection(connString);            
            conn.Open();
            String q = "insert into tb1 values('" + fname + "','" + lname + "');";
            OleDbCommand cmd = new OleDbCommand(q, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("record Inserted");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = MyCoonection();
            conn.Open();
            String q = "select * from tb1;";
            OleDbCommand cmd = new OleDbCommand(q, conn);
            //OleDbDataReader rdr = cmd.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Load(rdr);
            //dGV.DataSource = dt;
            //conn.Close();


            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dGV.DataSource = ds.Tables[0];
            conn.Close();
            //dGV.DataBind();  

        }
        public OleDbConnection MyCoonection()
        {
            String connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=upes.accdb";
            OleDbConnection conn = new OleDbConnection(connString);
            return conn;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 ob = new Form1();
            this.Hide();
            ob.ShowDialog();
        }
    }
}

