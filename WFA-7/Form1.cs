using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Input.Text = Input.Text+"1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Input.Text = Input.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Input.Text = Input.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Input.Text = Input.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Input.Text = Input.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Input.Text = Input.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Input.Text = Input.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Input.Text = Input.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Input.Text = Input.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Input.Text = Input.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Input.Text = Input.Text + ".";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Input.Text = Input.Text + "+";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Input.Text = Input.Text + "*";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Input.Text = Input.Text + "^";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Input.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string T = Input.Text;
            int L = T.Length;
            Input.Text = "";
            for (int i = 0; i < L - 1; i++)
                Input.Text = Input.Text + T[i];
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Input.Text = Input.Text + "=";
            char op;
            char [] m=new char[10];   //23.5+34=
            char[] n = new char[10];   //m= 23.5   op='+'
            int i=0;
            while (Input.Text[i] != '+' && Input.Text[i] != '*' && Input.Text[i] != '^')
            {
                m[i] = Input.Text[i];
                i++;
            }
            op = Input.Text[i];
            i++;
            int j = 0;
            while (Input.Text[i] != '=')
            {
                n[j] = Input.Text[i];
                i++;
                j++;
            }
            double a, b;
            string p=new string(m);
            string q=new string(n);
            a = double.Parse(p);
            b = double.Parse(q);
            double res=0;
            switch (op)
            {
                case '+': res = a + b; break;
                case '*': res = a * b; break;
                case '^': res = Math.Pow(a,b); break;
            }
            Input.Text = Input.Text + res;
        }
    }
}
