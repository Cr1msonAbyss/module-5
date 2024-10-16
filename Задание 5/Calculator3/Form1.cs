using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator3
{
    public partial class Form1 : Form
    {
        public double result = 0;
        public string operation = "";
        public bool operationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }
        private void Number1_Click(object sender, EventArgs e)
        {
            if ((ResTextBox.Text == "0") || operationPerformed)
                ResTextBox.Clear();

            operationPerformed = false;
            Button button = (Button)sender;
            ResTextBox.Text += button.Text;
        }

        private void Number2_Click(object sender, EventArgs e)
        {
            if ((ResTextBox.Text == "0") || operationPerformed)
                ResTextBox.Clear();

            operationPerformed = false;
            Button button = (Button)sender;
            ResTextBox.Text += button.Text;
        }

        private void Number3_Click(object sender, EventArgs e)
        {
            if ((ResTextBox.Text == "0") || operationPerformed)
                ResTextBox.Clear();

            operationPerformed = false;
            Button button = (Button)sender;
            ResTextBox.Text += button.Text;
        }

        private void Number4_Click(object sender, EventArgs e)
        {
            if ((ResTextBox.Text == "0") || operationPerformed)
                ResTextBox.Clear();

            operationPerformed = false;
            Button button = (Button)sender;
            ResTextBox.Text += button.Text; 
        }

        private void Number5_Click(object sender, EventArgs e)
        {
            if ((ResTextBox.Text == "0") || operationPerformed)
                ResTextBox.Clear();

            operationPerformed = false;
            Button button = (Button)sender;
            ResTextBox.Text += button.Text;
        }

        private void Number6_Click(object sender, EventArgs e)
        {
            if ((ResTextBox.Text == "0") || operationPerformed)
                ResTextBox.Clear();

            operationPerformed = false;
            Button button = (Button)sender;
            ResTextBox.Text += button.Text;
        }

        private void Number7_Click(object sender, EventArgs e)
        {
            if ((ResTextBox.Text == "0") || operationPerformed)
                ResTextBox.Clear();

            operationPerformed = false;
            Button button = (Button)sender;
            ResTextBox.Text += button.Text;
        }

        private void Number8_Click(object sender, EventArgs e)
        {
            if ((ResTextBox.Text == "0") || operationPerformed)
                ResTextBox.Clear();

            operationPerformed = false;
            Button button = (Button)sender;
            ResTextBox.Text += button.Text;
        }

        private void Number9_Click(object sender, EventArgs e)
        {
            if ((ResTextBox.Text == "0") || operationPerformed)
                ResTextBox.Clear();

            operationPerformed = false;
            Button button = (Button)sender;
            ResTextBox.Text += button.Text;
        }


        private void ErraseAllBtn_Click(object sender, EventArgs e)
        {
            ResTextBox.Text= "0";
            result = 0;
            
        }

        private void EqualBtn_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    ResTextBox.Text = (result + Double.Parse(ResTextBox.Text)).ToString();
                    break;
                case "-":
                    ResTextBox.Text = (result - Double.Parse(ResTextBox.Text)).ToString();
                    break;
                case "*":
                    ResTextBox.Text = (result * Double.Parse(ResTextBox.Text)).ToString();
                    break;
                case "/":
                    ResTextBox.Text = (result / Double.Parse(ResTextBox.Text)).ToString();
                    break;
                default:
                    break;
            }
            result = Double.Parse(ResTextBox.Text);
            operation = "";
        }
        private void button_Click(object sender, EventArgs e)
        {
            if ((ResTextBox.Text == "0") || operationPerformed)
                ResTextBox.Clear();

            operationPerformed = false;
            Button button = (Button)sender;
            ResTextBox.Text += button.Text;
        }
        

        private void EqualBtn_Click_1(object sender, EventArgs e)
        {

        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (result != 0)
            {
                EqualBtn.PerformClick();
                operationPerformed = true;
                operation = button.Text;
            }
            else
            {
                operation = button.Text;
                result = Double.Parse(ResTextBox.Text);
                operationPerformed = true;
            }
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (result != 0)
            {
                EqualBtn.PerformClick();
                operationPerformed = true;
                operation = button.Text;
            }
            else
            {
                operation = button.Text;
                result = Double.Parse(ResTextBox.Text);
                operationPerformed = true;
            }
        }

        private void DevisionBtn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (result != 0)
            {
                EqualBtn.PerformClick();
                operationPerformed = true;
                operation = button.Text;
            }
            else
            {
                operation = button.Text;
                result = Double.Parse(ResTextBox.Text);
                operationPerformed = true;
            }
        }

        private void MultyplicationBtn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (result != 0)
            {
                EqualBtn.PerformClick();
                operationPerformed = true;
                operation = button.Text;
            }
            else
            {
                operation = button.Text;
                result = Double.Parse(ResTextBox.Text);
                operationPerformed = true;
            }
        }
    }
}
