using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace _1
{
    public partial class Form1 : Form
    {
        // Список для хранения всех нарисованных фигур
        private List<Shape> shapes = new List<Shape>();
        private string name_figyra = "Line"; // По умолчанию рисуем линию
        private Point startPoint;
        private bool isdrawing = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.MouseDown += Panel1_MouseDown;
            panel1.MouseMove += Panel1_MouseMove;
            panel1.MouseUp += Panel1_MouseUp;
            panel1.Paint += Panel1_Paint; // Для перерисовки
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // линия
            name_figyra = "Line";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // круг
            name_figyra = "Circle";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            // квадрат
            name_figyra = "Rectangle";
        }
        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            // Начало рисования
            isdrawing = true;
            startPoint = e.Location;
        }
        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isdrawing)
            {
                // Перерисовка при движении мыши
                panel1.Invalidate(); // Перерисовка панели
            }
        }
        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            // Окончание рисования
            isdrawing = false;
            // Добавляем нарисованную фигуру в список
            shapes.Add(new Shape
            {
                Type_figyru = name_figyra,
                Start_point = startPoint,
                End_point = e.Location
            });
            panel1.Invalidate(); // Обновляем панель для отображения новой фигуры
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            // перерисовка всех фигур
            Pen pen = new Pen(Color.Black, 2);
            foreach (var shape in shapes)
            {
                DrawShape(e.Graphics, pen, shape.Start_point, shape.End_point, shape.Type_figyru);
            }

            // отрисовка текущей фигуры при движении мыши
            if (isdrawing)
            {
                DrawShape(e.Graphics, pen, startPoint, panel1.PointToClient(MousePosition), name_figyra);
            }
        }

        private void DrawShape(Graphics g, Pen pen, Point start, Point end, string shapeType)
        {
            // рисование выбранной фигуры
            switch (shapeType)
            {
                case "Line":
                    g.DrawLine(pen, start, end);
                    break;
                case "Circle":
                    int radius = Math.Min(Math.Abs(end.X - start.X), Math.Abs(end.Y - start.Y));
                    g.DrawEllipse(pen, start.X, start.Y, radius, radius);
                    break;
                case "Rectangle":
                    g.DrawRectangle(pen, Math.Min(start.X, end.X), Math.Min(start.Y, end.Y),
                        Math.Abs(end.X - start.X), Math.Abs(end.Y - start.Y));
                    break;
            }
        }
        private class Shape
        {
            public string Type_figyru { get; set; } // Тип фигуры: линия, круг или квадрат
            public Point Start_point { get; set; } // Начальная точка
            public Point End_point { get; set; }   // Конечная точка
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Очищаем список нарисованных фигур
            shapes.Clear();

            // Обновляем панель для перерисовки (очистки)
            panel1.Invalidate();
        }
    }
}


