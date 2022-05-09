using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7Var11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
 
        private void button1_Click(object sender, EventArgs e)
        {
           
           int s = 1;
           int t = 0;
           int k = 0;
            for (int i = 0; i < 10; i++)
            {
                if (Mas[i] < 0 && t==0)
                {
                    k = i;
                    t = 1;
                }
            }
            for (int i =k+1; i < 10; i++)
            {
              if (Mas[i]!=0)
                s *= Mas[i];
            }
            textBox2.Text = s.ToString();
        }
 
        int[] Mas = new int[10];
 
        private void button2_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            textBox1.Text = "";
            for (int i = 0; i < 10; i++)
            {
                Mas[i] = rand.Next(-10, 10);
                textBox1.Text += "Mas[" + Convert.ToString(i) + "] = "
                + Convert.ToString(Mas[i]) + Environment.NewLine;
            }
        }
    }
}