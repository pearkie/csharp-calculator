using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {

        private decimal valueFirst = 0.0m;
        private decimal valueSecond = 0.0m;
        private decimal Result = 0.0m;
        private string operators = "+";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "1";
            }
            else
            {
                textBox2.Text += "1";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Contains("-"))
            {
                textBox2.Text = textBox2.Text.Trim('-');
            }
            else
            {
                textBox2.Text = "-" + textBox2.Text;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(textBox2.Text);
            textBox2.Clear();
            operators = "*";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "7";
            }
            else
            {
                textBox2.Text += "7";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "0";
            }
            else
            {
                textBox2.Text += "0";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!textBox2.Text.Contains("."))
            {
                textBox2.Text += ".";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "2";
            }
            else
            {
                textBox2.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "3";
            }
            else
            {
                textBox2.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "4";
            }
            else
            {
                textBox2.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "5";
            }
            else
            {
                textBox2.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "6";
            }
            else
            {
                textBox2.Text += "6";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "8";
            }
            else
            {
                textBox2.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "9";
            }
            else
            {
                textBox2.Text += "9";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(textBox2.Text);
            textBox2.Clear();
            operators = "-";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(textBox2.Text);
            textBox2.Clear();
            operators = "+";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(textBox2.Text);
            textBox2.Clear();
            operators = "/";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            switch (operators)
            {
                case "-":
                    valueSecond = decimal.Parse(textBox2.Text);
                    Result = valueFirst - valueSecond;
                    textBox2.Text = Result.ToString();

                    break;

                case "+":
                    valueSecond = decimal.Parse(textBox2.Text);
                    Result = valueFirst + valueSecond;
                    textBox2.Text = Result.ToString();

                    break;

                case "*":
                    valueSecond = decimal.Parse(textBox2.Text);
                    Result = valueFirst * valueSecond;
                    textBox2.Text = Result.ToString();

                    break;

                case "/":
                    valueSecond = decimal.Parse(textBox2.Text);
                    if (valueSecond != 0)
                    {
                        Result = valueFirst / valueSecond;
                        textBox2.Text = Result.ToString();
                    }
                    else
                    {
                        textBox2.Text = "Error";
                    }

                    break;
            }

            valueFirst = 0.0m;
            valueSecond = 0.0m;
            operators = "+";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            valueFirst = 0.0m;
            valueSecond = 0.0m;
            textBox2.Text = "0";
        }

    }
}