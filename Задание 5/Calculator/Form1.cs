using System;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Calculator
{
    public partial class SuperCalculator3000 : Form
    {
        private float a, b;
        private int count;
        private bool znak = true;

        public SuperCalculator3000()
        {
            InitializeComponent();
        }

            private void Number0_Click(object sender, EventArgs e)
            {
                richTextBox1.Text = richTextBox1.Text + 0;
            }

            private void Number1_Click(object sender, EventArgs e)
            {
                richTextBox1.Text = richTextBox1.Text + 1;
            }

            private void Number2_Click(object sender, EventArgs e)
            {
                richTextBox1.Text = richTextBox1.Text + 2;
            }

            private void Number3_Click(object sender, EventArgs e)
            {
                richTextBox1.Text = richTextBox1.Text + 3;
            }

            private void Number4_Click(object sender, EventArgs e)
            {
                richTextBox1.Text = richTextBox1.Text + 4;
            }

            private void Number5_Click(object sender, EventArgs e)
            {
                richTextBox1.Text = richTextBox1.Text + 5;
            }

            private void Number6_Click(object sender, EventArgs e)
            {
                richTextBox1.Text = richTextBox1.Text + 6;
            }

            private void Number7_Click(object sender, EventArgs e)
            {
                richTextBox1.Text = richTextBox1.Text + 7;
            }

            private void Number8_Click(object sender, EventArgs e)
            {
                richTextBox1.Text = richTextBox1.Text + 8;
            }

            private void Number9_Click(object sender, EventArgs e)
            {
                richTextBox1.Text = richTextBox1.Text + 9;
            }


            private void DotBtn_Click(object sender, EventArgs e)
            {
                richTextBox1.Text = richTextBox1.Text + ",";
            }
        
    

            private void button_Click(object sender, EventArgs e)
            {
                Button btn = sender as Button;
                richTextBox1.Text += btn.Text;
            }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            a = float.Parse(richTextBox1.Text);
            richTextBox1.Clear();
            count = 1;
            label1.Text = a.ToString() + "+";
            znak = true;
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            a = float.Parse(richTextBox1.Text);
            richTextBox1.Clear();
            count = 2;
            label1.Text = a.ToString() + "-";
            znak = true;
        }

        private void MultiplyBtn_Click(object sender, EventArgs e)
        {
            a = float.Parse(richTextBox1.Text);
            richTextBox1.Clear();
            count = 3;
            label1.Text = a.ToString() + "*";
            znak = true;
        }

        private void DivisionBtn_Click(object sender, EventArgs e)
        {
            a = float.Parse(richTextBox1.Text);
            richTextBox1.Clear();
            count = 4;
            label1.Text = a.ToString() + "/";
            znak = true;
        }

        private void EqualBtn_Click(object sender, EventArgs e)
        {
            calculate();
        }

        private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(richTextBox1.Text);
                    richTextBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(richTextBox1.Text);
                    richTextBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(richTextBox1.Text);
                    richTextBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(richTextBox1.Text);
                    richTextBox1.Text = b.ToString();
                    break;
                default:
                    break;
            }
            label1.Text = "";
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }


        private void ErraseBtn_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length != 0)
                richTextBox1.Text = richTextBox1.Text.Substring(0, richTextBox1.Text.Length - 1);
        }


    }

    public class Class1
    {
    }
}
