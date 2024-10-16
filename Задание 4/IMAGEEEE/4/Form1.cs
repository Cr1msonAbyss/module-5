using System;
using System.Drawing;
using System.Windows.Forms;
namespace _4
{
    public partial class Form1 : Form
    {
        private Image currentImage; 
        private float zoomFactor = 1.0f; 

        public Form1()
        {
            InitializeComponent();
        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
              
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                  
                    currentImage = new Bitmap(openFileDialog.FileName);
                    pictureBox1.Image = currentImage;
                    zoomFactor = 1.0f; 
                    Mashtab();
                }
            }
        }
        private void увеличитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentImage != null)
            {
                zoomFactor += 0.1f; 
                Mashtab(); 
            }
        }
        private void уменьшитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentImage != null)
            {
                zoomFactor = Math.Max(0.1f, zoomFactor - 0.1f); 
                Mashtab();
            }
        }
        private void Mashtab()
        {
            if (currentImage != null)
            {
               
                int newWidth = (int)(currentImage.Width * zoomFactor);
                int newHeight = (int)(currentImage.Height * zoomFactor);
                pictureBox1.Size = new Size(newWidth, newHeight); 
                pictureBox1.Refresh(); 
            }
        }
    }
}



