using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string firstNumber = "";
        string secondNumber = "";
        string userInput = "";

        char function;

        double result = 0.0;
        double first = 0.0;
        double second = 0.0;

        bool isResultMoved = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void oneButon_Click(object sender, EventArgs e)
        {
            userInput += "1";
            calculatorDisplay.Text = userInput;
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            userInput += "2";
            calculatorDisplay.Text = userInput;
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            userInput += "3";
            calculatorDisplay.Text = userInput;
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            userInput += "4";
            calculatorDisplay.Text = userInput;
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            userInput += "5";
            calculatorDisplay.Text = userInput;
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            userInput += "6";
            calculatorDisplay.Text = userInput;
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            userInput += "7";
            calculatorDisplay.Text = userInput;
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            userInput += "8";
            calculatorDisplay.Text = userInput;
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            userInput += "9";
            calculatorDisplay.Text = userInput;
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            userInput += "0";
            calculatorDisplay.Text = userInput;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            function = '+';
            if (userInput != "" && !isResultMoved)
            {
                firstNumber = userInput;
                userInput = "";
            }
            if (isResultMoved)
            {
                userInput = "";
                isResultMoved = false;
            }
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            function = '-';
            if (userInput != "" && !isResultMoved)
            {
                firstNumber = userInput;
                userInput = "";
            }
            if (isResultMoved)
            {
                userInput = "";
                isResultMoved = false;
            }
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            function = '*';
            if (userInput != "" && !isResultMoved)
            {
                firstNumber = userInput;
                userInput = "";
            }
            if (isResultMoved)
            {
                userInput = "";
                isResultMoved = false;
            }
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            function = '/';
            if (userInput != "" && !isResultMoved)
            {
                firstNumber = userInput;
                userInput = "";
            }
            if (isResultMoved)
            {
                userInput = "";
                isResultMoved = false;
            }
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            secondNumber = userInput;
            if (firstNumber != "" && secondNumber != "")
            {
                first = Convert.ToDouble(firstNumber);
                second = Convert.ToDouble(secondNumber);
                if (function == '+')
                {
                    result = first + second;
                    calculatorDisplay.Text = Convert.ToString(result);
                }
                else if (function == '-')
                {
                    result = first - second;
                    calculatorDisplay.Text = Convert.ToString(result);
                }
                else if (function == '*')
                {
                    result = first * second;
                    calculatorDisplay.Text = Convert.ToString(result);
                }
                else if (function == '/')
                {
                    if (second == 0.0)
                    {
                        calculatorDisplay.Text = "NaN";
                    }
                    else
                    {
                        result = first / second;
                        calculatorDisplay.Text = Convert.ToString(result);
                    }
                }
                else
                {
                    calculatorDisplay.Text = "Err";
                }
                firstNumber = Convert.ToString(result);
                isResultMoved = true;
            }

        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            if (userInput == "")
            {
                userInput = "0";
            }
            if (!userInput.Contains(','))
            {
                userInput += ",";
                calculatorDisplay.Text = userInput;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            firstNumber = "";
            secondNumber = "";
            userInput = "";
            result = 0.0;
            calculatorDisplay.Text = "0";
            isResultMoved = false;
        }
    }
}
