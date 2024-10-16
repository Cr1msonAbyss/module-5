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
        public Form1()
        {
            InitializeComponent();
        }

        private void TaskAppendBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(TaskInputTextBox.Text);
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void MarkBtn_Click(object sender, EventArgs e)
        {
            int Index = listBox1.SelectedIndex;
            listBox1.Items[Index] = $"{listBox1.Text} - выполнено";
        }
    }
}
