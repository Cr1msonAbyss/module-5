using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private float _scale = 1.0f; // Текущий масштаб
        private Point _lastMousePosition; // Последняя позиция мыши
        private bool _isDragging = false; // Флаг для отслеживания перетаскивания

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLoadImage_Click(object sender, EventArgs e)
        {
           
        }

        private void PictureBox_MouseWheel(object sender, MouseEventArgs e)
        {
            if (sender is PictureBox pictureBox1)
            {
                // Изменяем масштаб в зависимости от прокрутки мыши
                if (e.Delta > 0)
                {
                    _scale += 0.1f; // Увеличиваем масштаб
                }
                else if (_scale > 0.1f)
                {
                    _scale -= 0.1f; // Уменьшаем масштаб
                }

                // Обновляем размер PictureBox
                pictureBox1.Width = (int)(pictureBox1.Image.Width * _scale);
                pictureBox1.Height = (int)(pictureBox1.Image.Height * _scale);
                pictureBox1.Invalidate(); // Перерисовываем PictureBox
            }
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && sender is PictureBox pictureBox1)
            {
                _isDragging = true;
                _lastMousePosition = e.Location; // Сохраняем начальную позицию мыши
            }
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDragging && sender is PictureBox pictureBox1)
            {
                // Перемещаем изображение при удерживании кнопки мыши
                int dx = e.Location.X - _lastMousePosition.X;
                int dy = e.Location.Y - _lastMousePosition.Y;

                pictureBox1.Left += dx;
                pictureBox1.Top += dy;

                // Обновляем последнюю позицию мыши
                _lastMousePosition = e.Location;
            }
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _isDragging = false; // Останавливаем перетаскивание
            }
        }

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
                _scale += 0.1f; // Увеличиваем масштаб
                pictureBox1.Width = (int)(pictureBox1.Image.Width * _scale);
                pictureBox1.Height = (int)(pictureBox1.Image.Height * _scale);
                pictureBox1.Invalidate(); // Перерисовываем PictureBox
            
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            _scale -= 0.1f; // Уменьшаем масштаб
            pictureBox1.Width = (int)(pictureBox1.Image.Width * _scale);
            pictureBox1.Height = (int)(pictureBox1.Image.Height * _scale);
            pictureBox1.Invalidate(); // Перерисовываем PictureBox
        }
    }
}
