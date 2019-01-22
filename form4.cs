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
    public partial class Form4 : Form
    {
        
        public Form4()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int[] terms;
        string s1;
        int score = 0;
        String[] words = { "appreciate", "economical", "artificial","arithmetic","toothpaste","screenplay","positively","earthquake","elasticity","population" };
        private void Form4_Load(object sender, EventArgs e)
        {
            generateFiveRandomNumber();
            //MessageBox.Show(terms[0]+" "+terms[1]+" "+terms[2]+" "+terms[3]+" "+terms[4]+"");
            int n = rnd.Next(0, 9);
            s1 = words[n];

            for (int p = 0; p < terms.Length; p++)
            {
                fillText(terms[p], s1);
            }   
            
        }

        private void fillText(int p, string s1)
        {
            switch (p)
            {
                case 0:
                    {
                        txt0.Text = s1[p].ToString();
                        txt0.Enabled = false;
                        break;
                    }
                case 1:
                    {
                        txt1.Text = s1[p].ToString();
                        txt1.Enabled = false;
                        break;
                    }
                case 2:
                    {
                        txt2.Text = s1[p].ToString();
                        txt2.Enabled = false;
                        break;
                    }
                case 3:
                    {
                        txt3.Text = s1[p].ToString();
                        txt3.Enabled = false;
                        break;
                    }
                case 4:
                    {
                        txt4.Text = s1[p].ToString();
                        txt4.Enabled = false;
                        break;
                    }
                case 5:
                    {
                        txt5.Text = s1[p].ToString();
                        txt5.Enabled = false;
                        break;
                    }
                case 6:
                    {
                        txt6.Text = s1[p].ToString();
                        txt6.Enabled = false;
                        break;
                    }
                case 7:
                    {
                        txt7.Text = s1[p].ToString();
                        txt7.Enabled = false;
                        break;
                    }
                case 8:
                    {
                        txt8.Text = s1[p].ToString();
                        txt8.Enabled = false;
                        break;
                    }
                case 9:
                    {
                        txt9.Text = s1[p].ToString();
                        txt9.Enabled = false;
                        break;
                    }

            }
        }


        public void generateFiveRandomNumber()
        {
            List<int> termsList = new List<int>();
            int i;
            int flag = 0;
            int k = 1;
            if (termsList.Count() == 0)
            {

                termsList.Add(rnd.Next(1, 10));
            }
            while (termsList.Count() < 5)
            {
                i = rnd.Next(0, 9);
                flag = 0;
                for (int j = 0; j < termsList.Count(); j++)
                {
                    if (termsList[j] == i)
                    {
                        flag = 1;
                    }
                }
                if (flag == 0)
                {
                    termsList.Add(i);
                }
            }
            terms = termsList.ToArray();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int flag=0;
            string ans = txt0.Text + txt1.Text + txt2.Text + txt3.Text + txt4.Text + txt5.Text + txt6.Text + txt7.Text + txt8.Text + txt9.Text;
            for (int n = 0; n < words.Length; n++)
            {
              if (ans.Equals(words[n]))
            {
                flag=1;
            }
                
            }
            if (flag == 1)
            {
                score = score + 5;
                MessageBox.Show("Correct Answer");
            }
            else
            {
                score = score -1;
                MessageBox.Show("Wrong Answer");
            }
            MessageBox.Show("Your Scotre is: " + score);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt0.Text = "";
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
            txt6.Text = "";
            txt7.Text = "";
            txt8.Text = "";
            txt9.Text = "";
            txt0.Enabled = true;
            txt1.Enabled = true;
            txt2.Enabled = true;
            txt3.Enabled = true;
            txt4.Enabled = true;
            txt5.Enabled = true;
            txt6.Enabled = true;
            txt7.Enabled = true;
            txt8.Enabled = true;
            txt9.Enabled = true;
            generateFiveRandomNumber();
            int n = rnd.Next(0, 9);
            s1 = words[n];
            for (int p = 0; p < terms.Length; p++)
            {
                fillText(terms[p], s1);
            }   

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
    }
}

