using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Calculator : Form
    {
        private List<int> numbers = new List<int>();
        private List<string> operations = new List<string>();
        private int currentNumber = 0;

        public Calculator()
        {
            this.numbers.Add(0);
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(this.Calculator_KeyPress);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            inOperation.Text = "";
            currentNumber = 0;
            numbers.Clear();
            operations.Clear();
            numbers.Add(0);
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            numbers[currentNumber] *= 10;
            UpdateText();
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            numbers[currentNumber] *= 10;
            numbers[currentNumber] += 1;
            UpdateText();
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            numbers[currentNumber] *= 10;
            numbers[currentNumber] += 2;
            UpdateText();
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            numbers[currentNumber] *= 10;
            numbers[currentNumber] += 3;
            UpdateText();
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            numbers[currentNumber] *= 10;
            numbers[currentNumber] += 4;
            UpdateText();
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            numbers[currentNumber] *= 10;
            numbers[currentNumber] += 5;
            UpdateText();
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            numbers[currentNumber] *= 10;
            numbers[currentNumber] += 6;
            UpdateText();
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            numbers[currentNumber] *= 10;
            numbers[currentNumber] += 7;
            UpdateText();
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            numbers[currentNumber] *= 10;
            numbers[currentNumber] += 8;
            UpdateText();
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            numbers[currentNumber] *= 10;
            numbers[currentNumber] += 9;
            UpdateText();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            operations.Add("+");
            numbers.Add(0);
            currentNumber++;
            UpdateText();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            operations.Add("-");
            numbers.Add(0);
            currentNumber++;
            UpdateText();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            operations.Add("*");
            numbers.Add(0);
            currentNumber++;
            UpdateText();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operations.Add("/");
            numbers.Add(0);
            currentNumber++;
            UpdateText();
        }

        private void UpdateText()
        {
            string text = numbers[0].ToString();
            for (int i = 0; i < operations.Count; i++)
            {
                text += operations[i];

                if (i + 1 < numbers.Count)
                {
                    text += numbers[i + 1];
                }
                
            }

            inOperation.Text = text;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double result = numbers[0];

            for (int i = 0; i < operations.Count; i++)
            {
                switch(operations[i])
                {
                    case "+":
                        result += numbers[i + 1];
                        break;
                    case "-":
                        result -= numbers[i + 1];
                        break;
                    case "*":
                        result *= numbers[i + 1];
                        break;
                    case "/":
                        result /= numbers[i + 1];
                        break;
                    default:
                        break;
                }
            }

            numbers.Clear();
            operations.Clear();
            currentNumber = 0;
            numbers.Add(0);

            inOperation.Text = result.ToString();
        }

        private void Calculator_KeyPress(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D0:
                case Keys.NumPad0:
                    btnNum0.PerformClick();
                    break;
                case Keys.D1:
                case Keys.NumPad1:
                    btnNum1.PerformClick();
                    break;
                case Keys.D2:
                case Keys.NumPad2:
                    btnNum2.PerformClick();
                    break;
                case Keys.D3:
                case Keys.NumPad3:
                    btnNum3.PerformClick();
                    break;
                case Keys.D4:
                case Keys.NumPad4:
                    btnNum4.PerformClick();
                    break;
                case Keys.D5:
                case Keys.NumPad5:
                    btnNum5.PerformClick();
                    break;
                case Keys.D6:
                case Keys.NumPad6:
                    btnNum6.PerformClick();
                    break;
                case Keys.D7:
                case Keys.NumPad7:
                    btnNum7.PerformClick();
                    break;
                case Keys.D8:
                case Keys.NumPad8:
                    btnNum8.PerformClick();
                    break;
                case Keys.D9:
                case Keys.NumPad9:
                    btnNum9.PerformClick();
                    break;
                case Keys.Add:
                    btnPlus.PerformClick();
                    break;
                case Keys.Subtract:
                    btnMinus.PerformClick();
                    break;
                case Keys.Multiply:
                    btnMul.PerformClick();
                    break;
                case Keys.Divide:
                    btnDiv.PerformClick();
                    break;
                case Keys.Enter:
                    btnEqual.PerformClick();
                    break;
            }
        }
    }
}
