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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int qr;      
        int score = 0;
        int[] terms;
        String[] words = { "appreciate", "economical","artificial"};
        String s1;
        private void Form1_Load(object sender, EventArgs e)
        {
            generateFiveRandomNumber();
            qr = rnd.Next(0, 3);
            s1 = words[qr];
            for (int p = 0; p < terms.Length; p++)
            {
                fillText(terms[p],s1);
            }   
           
        }
        public void fillText(int ch, String str)
        {
            switch (ch)
            {
                case 0:
                    {
                        txtC0.Text = str[ch].ToString();
                        txtC0.Enabled = false;
                        break;                        
                    }
                case 1: { 
                        txtC1.Text = str[ch].ToString();
                        txtC1.Enabled = false;
                        break;
                        
                        }
                case 2:
                    {
                        txtC2.Text = str[ch].ToString();
                        txtC2.Enabled = false;
                        break;
                    }
                case 3:
                    {
                        txtC3.Text = str[ch].ToString();
                        txtC3.Enabled = false;
                        break;
                    }
                case 4:
                    {
                        txtC4.Text = str[ch].ToString();
                        txtC4.Enabled = false;
                        break;
                    }
                case 5:
                    {
                        txtC5.Text = str[ch].ToString();
                        txtC5.Enabled = false;
                        break;
                    }
                case 6:
                    {
                        txtC6.Text = str[ch].ToString();
                        txtC6.Enabled = false;
                        break;
                    }
                case 7:
                    {
                        txtC7.Text = str[ch].ToString();
                        txtC7.Enabled = false;
                        break;
                    }
                case 8:
                    {
                        txtC8.Text = str[ch].ToString();
                        txtC8.Enabled = false;
                        break;
                    }
                case 9:
                    {
                        txtC9.Text = str[ch].ToString();
                        txtC9.Enabled = false;
                        break;
                    }

                default: { MessageBox.Show("worong choice"); break; }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtC0.Text = "";
            txtC0.Enabled = true;
            txtC1.Text = "";
            txtC1.Enabled = true;
            txtC2.Text = "";
            txtC2.Enabled = true;
            txtC3.Text = "";
            txtC3.Enabled = true;
            txtC4.Text = "";
            txtC4.Enabled = true;
            txtC5.Text = "";
            txtC5.Enabled = true;
            txtC6.Text = "";
            txtC6.Enabled = true;
            txtC7.Text = "";
            txtC7.Enabled = true;
            txtC8.Text = "";
            txtC8.Enabled = true;
            txtC9.Text = "";
            txtC9.Enabled = true;
            generateFiveRandomNumber();
            qr = rnd.Next(0, 3);
            s1 = words[qr];
            for (int p = 0; p < terms.Length; p++)
            {
                fillText(terms[p], s1);
            }         
              
        }

        private void button2_Click(object sender, EventArgs e)
        {
           String myAns= (txtC0.Text+txtC1.Text+txtC2.Text+txtC3.Text+txtC4.Text
                          +txtC5.Text+txtC6.Text+txtC7.Text+txtC8.Text+txtC9.Text).ToString();
           MessageBox.Show(myAns);
           if (myAns.Equals(s1))
           {
               score=score+5;
               MessageBox.Show("your score is "+score );
           }
        }
        public void generateFiveRandomNumber()
        {
            List<int> termsList = new List<int>();            
            int i;
            int flag = 0;
            int k=1;
            if (termsList.Count()==0)
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
        
    }
}

