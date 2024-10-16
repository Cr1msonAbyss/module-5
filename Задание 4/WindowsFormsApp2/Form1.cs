using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private Panel drawingPanel;
        private Bitmap image;

        public void DrawingApp() 
        {
            this.Text = "Image Loading Application";
            this.Size = new Size(800, 600);

            drawingPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };
            drawingPanel.Paint += DrawingPanel_Paint;

            Button loadImageButton = new Button { Text = "Load Image", Dock = DockStyle.Top };
            loadImageButton.Click += LoadImageButton_Click;

            this.Controls.Add(drawingPanel);
            this.Controls.Add(loadImageButton);
        }

        private void LoadImageButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    image = new Bitmap(openFileDialog.FileName);
                    drawingPanel.Invalidate(); // Перерисовать панель для отображения изображения
                }
            }
        }

        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
            if (image != null)
            {
                e.Graphics.DrawImage(image, new Rectangle(0, 0, drawingPanel.Width, drawingPanel.Height));
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    image = new Bitmap(openFileDialog.FileName);
                    drawingPanel.Invalidate(); // Перерисовать панель для отображения изображения
                }
            }
        }
    }
}