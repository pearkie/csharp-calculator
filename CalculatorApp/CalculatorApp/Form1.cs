using System;
using System.Data;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AppendToTextBox(string value)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = value;
            }
            else
            {
                textBox2.Text += value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppendToTextBox("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AppendToTextBox("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AppendToTextBox("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AppendToTextBox("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AppendToTextBox("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AppendToTextBox("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AppendToTextBox("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AppendToTextBox("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AppendToTextBox("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AppendToTextBox("0");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!textBox2.Text.Contains("."))
            {
                textBox2.Text += ".";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox2.Text = "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            AppendToTextBox("*");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            AppendToTextBox("-");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            AppendToTextBox("+");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            AppendToTextBox("/");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 0)
            {
                textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = EvaluateExpression(textBox2.Text).ToString();
            }
            catch (Exception)
            {
                textBox2.Text = "Error";
            }
        }

        private decimal EvaluateExpression(string expression)
        {
            DataTable table = new DataTable();
            var value = table.Compute(expression, "");
            return Convert.ToDecimal(value);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
