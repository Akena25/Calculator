using System.Security.Cryptography;
using System.Collections.Generic;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        double firstNumber = 0;
        string operation = "";
        bool newNumber = true;

        List<string> history = new List<string>();

        public Form1()
        {
            InitializeComponent();

            one.Click += Number_Click;
            two.Click += Number_Click;
            three.Click += Number_Click;
            four.Click += Number_Click;
            five.Click += Number_Click;
            six.Click += Number_Click;
            seven.Click += Number_Click;
            eight.Click += Number_Click;
            nine.Click += Number_Click;
            zero.Click += Number_Click;
        }

        private void Number_Click(object? sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (newNumber)
            {
                label1.Text = "";
                newNumber = false;
            }

            label1.Text += button.Text;
        }

        private void plus_Click(object sender, EventArgs e) //кнопка плюс
        {
            Button button = (Button)sender;

            firstNumber = double.Parse(label1.Text);
            operation = "+";
            newNumber = true;

            label1.Text += button.Text;
        }

        private void minus_Click(object sender, EventArgs e) //кнопка минус
        {
            Button button = (Button)sender;

            firstNumber = double.Parse(label1.Text);
            operation = "-";
            newNumber = true;

            label1.Text += button.Text;
        }

        private void mult_Click(object sender, EventArgs e) //кнопка умножить
        {
            Button button = (Button)sender;

            firstNumber = double.Parse(label1.Text);
            operation = "х";
            newNumber = true;

            label1.Text += button.Text;
        }

        private void split_Click(object sender, EventArgs e) //кнопка делить
        {
            Button button = (Button)sender;

            firstNumber = double.Parse(label1.Text);
            operation = "/";
            newNumber = true;

            label1.Text += button.Text;
        }

        private void equ_Click(object sender, EventArgs e) //кнопка равно
        {
            double secondNumber = double.Parse(label1.Text);
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;

                case "-":
                    result = firstNumber - secondNumber;
                    break;

                case "х":
                    result = firstNumber * secondNumber;
                    break;

                case "/":
                    if (secondNumber == 0)
                    {
                        MessageBox.Show("На ноль делить нельзя!");
                        return;
                    }

                    result = firstNumber / secondNumber;
                    break;
            }

            history.Add(firstNumber + " " + operation + " " + secondNumber + " = " + result); // Добавляем вычисление в историю

            label1.Text = result.ToString();
            newNumber = true;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            firstNumber = 0;
            operation = "";
            newNumber = true;
        }

        private void drob_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            firstNumber = double.Parse(label1.Text);
            operation = ",";

            label1.Text += button.Text;
        }

        private void memory_Click(object sender, EventArgs e)
        {
            Form2 historyForm = new Form2(history);
            historyForm.ShowDialog();
        }
    }
}
