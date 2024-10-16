using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private float _scale = 1.0f; 
        private Point _lastMousePosition; 
        private bool _isDragging = false;

        
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = System.Drawing.Image.FromFile(ofd.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; pictureBox1.Dock = DockStyle.None;
            }

        }
        private void pictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (sender is PictureBox pictureBox1)
            {

                if (e.Delta > 0)
                {
                    _scale += 0.1f; 
                }
                else if (_scale > 0.1f)
                {
                    _scale -= 0.1f; 
                }


                pictureBox1.Width = (int)(pictureBox1.Image.Width * _scale);
                pictureBox1.Height = (int)(pictureBox1.Image.Height * _scale);
                pictureBox1.Invalidate(); 
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && sender is PictureBox pictureBox)
            {
                _isDragging = true;
                _lastMousePosition = e.Location; 
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDragging && sender is PictureBox pictureBox)
            {
                int dx = e.Location.X - _lastMousePosition.X;
                int dy = e.Location.Y - _lastMousePosition.Y;

                pictureBox.Left += dx;
                pictureBox.Top += dy;

                _lastMousePosition = e.Location;
            }
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _isDragging = false;
            }
        }
    }
}
