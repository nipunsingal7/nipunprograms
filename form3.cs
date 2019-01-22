using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IQ
{
    
    public partial class Form3 : Form
    {
        Random rnd = new Random();
        int[] a;
        static int count= 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            generateEven();
            fillMatrix();
            count = 1;
        }
        public void fillMatrix()
        {
            txt11.Text = a[0].ToString();
            txt12.Text = a[1].ToString();
            txt13.Text = a[2].ToString();
            txt21.Text = a[3].ToString();
            txt22.Text = a[4].ToString();
            txt23.Text = a[5].ToString();
            txt31.Text = a[6].ToString();
            txt32.Text = a[7].ToString();
            txt33.Text = a[8].ToString();
        }
        public void generateEven()
        {

            List<int> termsList = new List<int>();
            int i;
            int flag = 0;            
            if (termsList.Count() == 0)
            {
                         
                termsList.Add(2);
            }

            while (termsList.Count() < 9)
            {
                i = rnd.Next(0, 100);
                flag = 0;
                for (int j = 0; j < termsList.Count(); j++)
                {
                    if ((termsList[j] == i) || ((i%2)!=0))
                    {
                        flag = 1;
                    }

                }
                if (flag == 0)
                {
                    termsList.Add(i);
                }

            }

            a = termsList.ToArray();
        }
        public void generateOdd()
        {

            List<int> termsList = new List<int>();
            int i;
            int flag = 0;           
            if (termsList.Count() == 0)
            {

                termsList.Add(3);
            }

            while (termsList.Count() < 9)
            {
                i = rnd.Next(0, 100);
                flag = 0;
                for (int j = 0; j < termsList.Count(); j++)
                {
                    if ((termsList[j] == i) || ((i % 2) == 0))
                    {
                        flag = 1;
                    }

                }
                if (flag == 0)
                {
                    termsList.Add(i);
                }

            }

            a = termsList.ToArray();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (calcDet().ToString().Equals(txt_ans.Text))
            {
                MessageBox.Show("Right Answer! Click for next attempt");
                count++;
            }
            else
            {
                MessageBox.Show("Sorry! Wrong Answer. Game Over");
                this.Close();
            }
            if (count < 5 && count % 2 == 0)
            {
                generateOdd();
                fillMatrix();
            }
            if (count < 5 && count % 2 != 0)
            {
                generateEven();
                fillMatrix();
            }
            if (count > 5)
            {
                MessageBox.Show("5 Chances completed.Excellent! Game Over");
                this.Close();
            }
            
        }
        public int calcDet()
        {
            int ans;
            ans = a[0] * (a[4] * a[8] - a[5] * a[7]) - a[1] * (a[3] * a[8] - a[5] * a[6]) + a[2] * (a[3] * a[7] - a[4] * a[6]);
            return ans;
        }
    }
}

