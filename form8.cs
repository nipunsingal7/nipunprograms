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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fname = txtFName.Text;
            string sapid = txtSapid.Text;
            string branch = cmbBranch.SelectedItem.ToString();
            string gen = null;
            string hobby = "";
            if (rbMale.Checked)
            {
                gen = "Male";
            }
            if (rbFemale.Checked)
            {
                gen = "Female";
            }
            if (chkPlay.Checked)
            {
               hobby=hobby+" ,Play";
            }
            if (chkRead.Checked)
            {
                hobby = hobby + " ,Read";
            }
            if (chkSing.Checked)
            {
                hobby = hobby + " ,Sing";
            }

            String connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=pst.accdb";
            OleDbConnection conn = new OleDbConnection(connString);
            string q = "insert into student_details values('" + fname + "','" + sapid + "','" + branch + "','" + gen + "','" + hobby + "')";
            OleDbCommand cmd = new OleDbCommand(q, conn);
            conn.Open();            
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Record Entered");
        }
    }
}

