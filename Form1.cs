using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Kalkulator
{

    public partial class Form1 : Form
    {
        string number = string.Empty;
        float cache1;
        string cache2;
        int operate;
        float memory = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            number = number + "1";
            textBox1.Text = number;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            number = number + "2";
            textBox1.Text = number;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            number = number + "3";
            textBox1.Text = number;


        }

        private void button7_Click(object sender, EventArgs e)
        {
            number = number + "4";
            textBox1.Text = number;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            number = number + "5";
            textBox1.Text = number;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            number = number + "6";
            textBox1.Text = number;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            number = number + "7";
            textBox1.Text = number;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            number = number + "8";
            textBox1.Text = number;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            number = number + "9";
            textBox1.Text = number;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            number = number + "0";
            textBox1.Text = number;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (number.Length > 0)
            {
                number = number.Remove(number.Length - 1);
                textBox1.Text = number;
            }
            else
            {
                textBox1.Text = number;
            }
            if (number.IndexOf("-") == 0)
            {
                if (number.Length == 1)
                {
                    number = number.Remove(number.Length - 1);
                    number = number.Replace("-", "");
                    textBox1.Text = number;
                }
            }
            else
            {
                textBox1.Text = number;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            operate = 0;
            number = "";
            cache2 = "";
            textBox2.Text = "";
            textBox1.Text = number;

        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = number;

            if (textBox1.TextLength > 0)
            {
                cache1 = Convert.ToSingle(number);
                cache1 = cache1 * -1;
                number = Convert.ToString(cache1);
                textBox1.Text = number;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (number.Length >= 1)
            {
                if (number.IndexOf(",") == -1)
                {
                    number = number + ",";
                    textBox1.Text = number;
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            operate = 1; //multiple
            cache2 = number;
            number = string.Empty;
            textBox1.Text = number;
            textBox2.Text = "X";
            textBox3.Text = cache2;

        }
        private void button15_Click(object sender, EventArgs e)
        {
            operate = 2; //minus
            cache2 = number;
            number = string.Empty;
            textBox1.Text = number;
            textBox2.Text = "-";
            textBox3.Text = cache2;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            operate = 3; //add
            cache2 = number;
            number = string.Empty;
            textBox1.Text = number;
            textBox2.Text = "+";
            textBox3.Text = cache2;
        }
        private void button13_Click(object sender, EventArgs e)
        {
            operate = 4; //division
            cache2 = number;
            number = string.Empty;
            textBox1.Text = number;
            textBox2.Text = "/";
            textBox3.Text = cache2;
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                float a = Convert.ToSingle(number);
                textBox1.Text = Convert.ToString(roots(a));
                if (textBox1.Text == "0")
                {
                    number = string.Empty;
                    textBox1.Text = "";
                }
                else
                {
                    number = textBox1.Text;
                }
            }
            catch
            {
                number = string.Empty;
                textBox1.Text = "";
            }
        }
        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                float a = Convert.ToSingle(cache2);
                float b = Convert.ToSingle(number);
                switch (operate)
                {
                    case 1:
                        textBox1.Text = Convert.ToString(multiple(a, b));
                        break;
                    case 2:
                        textBox1.Text = Convert.ToString(minus(a, b));
                        break;
                    case 3:
                        textBox1.Text = Convert.ToString(add(a, b));
                        break;
                    case 4:
                        textBox1.Text = Convert.ToString(division(a, b));
                        break;
                }
                number = textBox1.Text;
                textBox2.Text = "=";
                textBox3.Text = "";
            }
            catch
            { }
        }
        private float multiple(float a, float b)
        {
            return a * b;
        }
        private float minus(float a, float b)
        {
            return a - b;
        }
        private float add(float a, float b)
        {
            return a + b;
        }
        private float division(float a, float b)
        {
            if (a!=0 && b!=0)
            {
                return a / b;
            }
            else
            {
                return 0;
            }
        }
        double roots(float liczba)
        {
            try
            {
                return Math.Exp(Math.Log(liczba)/2);
                

                return 0;
            }
            catch
            {
                return 0;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";

            }
        }
        //
        //
        // MEMORY
        //
        //
        private void button23_Click(object sender, EventArgs e)
        {
            //MC
            memory = 0;
            textBox4.Text = "";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            try
            {
                //MR
                number = memory.ToString();
                textBox1.Text = memory.ToString();
            }
            catch
            {

            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            //MS
            try
            {
                if (Convert.ToSingle(number) != 0)
                {
                    memory = Convert.ToSingle(number);
                    textBox4.Text = memory.ToString();
                }
            }
            catch
            {

            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            //M+
            try
            {
                memory = memory + Convert.ToSingle(number);
                textBox4.Text = memory.ToString();
            }
            catch
            {

            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            //M-
            try
            {
                memory = memory - Convert.ToSingle(number);
                textBox4.Text = memory.ToString();
            }
            catch
            {

            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            try
            {
                float a = Convert.ToSingle(number);
                number = Convert.ToString(a * a);
                textBox1.Text = number;
            }
            catch
            {

            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                float a = Convert.ToSingle(number);
                number = Convert.ToString(1 / a);
                textBox1.Text = number;
            }
            catch
            {

            }
        }
    }
}