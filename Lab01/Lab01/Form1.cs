using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Form1 : Form
    {
        Calculation Calc;
        int countOfPress = 0;

        double result = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;
        bool znak = true;

        public Form1()
        {
            InitializeComponent();
            Calc = new Calculation();
            textBox1.Text = "0";
        }

        private void button_click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "0" || isOperationPerformed)
                {
                        textBox1.Clear();
                }
                isOperationPerformed = false;
                Button button = (Button)sender;
                if (button.Text == ",")
                {
                    if (textBox1.Text[0] == ',')
                        throw new Exception("Неверный формат!");
                    if (!textBox1.Text.Contains(","))
                        textBox1.Text = textBox1.Text + button.Text;
                }
                else
                    textBox1.Text = textBox1.Text + button.Text;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void operator_click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text[0] == '+' || textBox1.Text[0] == '-' || textBox1.Text[0] == '*' || textBox1.Text[0] == '/' || textBox1.Text[0] == '%')
                    throw new Exception("Неверный формат");

                Button button = (Button)sender;
                if (result != 0)
                {
                    operationPerformed = button.Text;
                    labelCurrentOperation.Text = result + " " + operationPerformed;
                    isOperationPerformed = true;
                }
                else
                {
                    operationPerformed = button.Text;
                    result = double.Parse(textBox1.Text);
                    labelCurrentOperation.Text = result + " " + operationPerformed;
                    isOperationPerformed = true;
                    znak = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            result = 0;
            labelCurrentOperation.Text = "";
            countOfPress = 0;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            try
            {
                switch (operationPerformed)
                {
                    case "+":
                        textBox1.Text = (result + double.Parse(textBox1.Text)).ToString();
                        break;
                    case "-":
                        textBox1.Text = (result - double.Parse(textBox1.Text)).ToString();
                        break;
                    case "*":
                        textBox1.Text = (result * double.Parse(textBox1.Text)).ToString();
                        break;
                    case "/":
                        if (double.Parse(textBox1.Text) != 0)
                        {
                            textBox1.Text = (result / double.Parse(textBox1.Text)).ToString();
                        }
                        else
                        {
                            throw new Exception("Error!\nDivide by zero");
                        }
                            break;
                    case "%":
                        textBox1.Text = (result % double.Parse(textBox1.Text)).ToString();
                        break;
                    default:
                        break;
                }
                result = double.Parse(textBox1.Text);
                labelCurrentOperation.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text[0]=='-')
            {
                znak = false;
            }
            if (znak)
            {
                textBox1.Text = "-" + textBox1.Text;
                znak = false;
            } else if(znak == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                znak = true;
            }
        }

        private void buttonMRC_Click(object sender, EventArgs e)
        {
            countOfPress++;
            if (countOfPress == 1)
            {
                textBox1.Text = Calc.MemoryShow().ToString();
            }
            if (countOfPress == 2)
            {
                Calc.Memory_Clear();
                textBox1.Text = "0";
                countOfPress = 0;
            }
        }
        private void buttonMPlus_Click(object sender, EventArgs e)
        {
            Calc.M_Sum(double.Parse(textBox1.Text));
        }
        private void buttonMMinus_Click(object sender, EventArgs e)
        {
            Calc.M_Sub(double.Parse(textBox1.Text));
        }
        
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if(e.KeyValue!=8 && e.KeyValue!=13)
                throw new Exception("Неверный формат");
            }
            catch (Exception ex)
            {
                textBox1.Text = "0";
                MessageBox.Show(ex.Message);
            }
        }
    }
}
