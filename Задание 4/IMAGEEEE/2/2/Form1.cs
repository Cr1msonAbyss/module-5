using System;
using System.Drawing;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        private Image currentImage; // Текущее изображение
        private float zoomFactor = 1.0f; // Коэффициент масштабирования

        public Form1()
        {
            InitializeComponent();
            InitializeComboBox(); // Инициализация ComboBox
            this.panel1.Paint += new PaintEventHandler(Panel1_Paint); // Подписка на событие рисования
        }

        private void InitializeComboBox()
        {
            // Заполнение ComboBox значениями от 10 до 100 с шагом 10
            for (int i = 10; i <= 100; i += 10)
            {
                comboBox1.Items.Add(i);
            }
            comboBox1.SelectedIndex = 8; // Устанавливаем значение по умолчанию на 100%
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Установка фильтра для выбора изображений
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Загрузка выбранного изображения
                    currentImage = new Bitmap(openFileDialog.FileName);
                    panel1.Invalidate(); // Перерисовываем панель
                }
            }
        }

        private void btnScale_Click(object sender, EventArgs e)
        {
            // Перерисовываем панель для применения масштабирования
            panel1.Invalidate();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            if (currentImage != null)
            {
                // Вычисление новых размеров изображения
                int newWidth = (int)(currentImage.Width * zoomFactor);
                int newHeight = (int)(currentImage.Height * zoomFactor);

                // Вычисление координат для центрирования
                int x = (panel1.Width - newWidth) / 2;
                int y = (panel1.Height - newHeight) / 2;

                // Рисуем изображение на панели с новыми размерами
                e.Graphics.DrawImage(currentImage, new Rectangle(x, y, newWidth, newHeight));
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Изменение коэффициента масштабирования в зависимости от выбранного значения ComboBox
            if (comboBox1.SelectedItem != null)
            {
                int selectedValue = (int)comboBox1.SelectedItem;
                zoomFactor = selectedValue / 100.0f; // Приводим к доле
            }
        }
    }
}


