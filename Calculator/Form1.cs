namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Input.Text =Input.Text+"1";
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

        private void button13_Click(object sender, EventArgs e)
        {
            Input.Text = Input.Text + "+";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Input.Text = Input.Text + "^";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Input.Text = Input.Text + "*";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Input.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Input.Text = Input.Text + ".";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string temp=Input.Text;
            Input.Text = "";
            int l = temp.Length;
            for (int i = 0; i < l - 1; i++)
                Input.Text = Input.Text + temp[i];
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Input.Text = Input.Text + "=";
            char[] m = new char[10];
            char[] n = new char[10];
            char op;
            int i = 0;
            while (Input.Text[i]!='+'&& Input.Text[i] != '^'&& Input.Text[i] != '*')
                m [i]= Input.Text[i++];
            op= Input.Text[i++];
            int j = 0;
            while (Input.Text[i] !='=')
                n[j++] = Input.Text[i++];
            double a, b;
            string p=new string(m);
            string q=new string(n);

            a = Convert.ToDouble(p);
            b= Convert.ToDouble(q);
           
            double r;
            switch (op)
            {
                case '+':r = a + b;
                    Input.Text = Input.Text + r; break;
                case '^':r = Math.Pow(a,b);
                    Input.Text = Input.Text + r; break;
                case '*':r = a * b;
                    Input.Text = Input.Text + r; break;

            }
            


        }

        private void Input_TextChanged(object sender, EventArgs e)
        {

        }
    }
}