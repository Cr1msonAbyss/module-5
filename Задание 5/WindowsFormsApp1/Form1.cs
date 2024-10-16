using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string Line;
        public Form1()
        {
            InitializeComponent();
        }

        private void Number1_Click(object sender, EventArgs e)
        {
            ExprTextBox.Text = ExprTextBox.Text + "1";
        }

        private void Number2_Click(object sender, EventArgs e)
        {
            ExprTextBox.Text = ExprTextBox.Text + "2";
        }

        private void Number3_Click(object sender, EventArgs e)
        {
            ExprTextBox.Text = ExprTextBox.Text + "3";
        }

        private void Number4_Click(object sender, EventArgs e)
        {
            ExprTextBox.Text = ExprTextBox.Text + "4";
        }

        private void Number5_Click(object sender, EventArgs e)
        {
            ExprTextBox.Text = ExprTextBox.Text + "5";
        }

        private void Number6_Click(object sender, EventArgs e)
        {
            ExprTextBox.Text = ExprTextBox.Text + "6";
        }

        private void Number7_Click(object sender, EventArgs e)
        {
            ExprTextBox.Text = ExprTextBox.Text + "7";
        }

        private void Number8_Click(object sender, EventArgs e)
        {
            ExprTextBox.Text = ExprTextBox.Text + "8";
        }

        private void Number9_Click(object sender, EventArgs e)
        {
            ExprTextBox.Text = ExprTextBox.Text + "9";
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            ExprTextBox.Text = ExprTextBox.Text + "+";
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            ExprTextBox.Text = ExprTextBox.Text + " - ";
        }

        private void DevisionBtn_Click(object sender, EventArgs e)
        {
            ExprTextBox.Text = ExprTextBox.Text + " / ";
        }

        private void MultyplicationBtn_Click(object sender, EventArgs e)
        {
            ExprTextBox.Text = ExprTextBox.Text + " * ";
        }

        private void SqrtBtn_Click(object sender, EventArgs e)
        {
            ExprTextBox.Text = ExprTextBox.Text + " √ ";
        }

        private void ErraseLastBtn_Click(object sender, EventArgs e)
        {
            string line = ExprTextBox.Text;
            if (line.Length > 0)
            {
                line = line.Substring(0, line.Length - 1);
                ExprTextBox.Text = line;
            }
             
        }

        private void ErraseAllBtn_Click(object sender, EventArgs e)
        {
            ExprTextBox.Text = "";
        }

        private void EqualBtn_Click(object sender, EventArgs e)
        { 
        string expression = ExprTextBox.Text.Trim();

            try
            {
                var result = EvaluateExpression(expression);
                MessageBox.Show($"Результат: {result}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (EvaluateException ex)
            {
                MessageBox.Show($"Ошибка в выражении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double EvaluateExpression(string expression)
        {
            DataTable table = new DataTable();
            var result = table.Compute(Line, string.Empty);

            if (result == DBNull.Value)
            {
                throw new EvaluateException("Выражение не может быть вычислено.");
            }

            return Convert.ToDouble(result);
        }
    }
}
   