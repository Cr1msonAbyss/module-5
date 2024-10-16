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

        private Point startPoint;
        private bool isDrawing = false;
        private string currentShape = "Line";

        private void карандашToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SolidBrush line = new SolidBrush(Color.Black);
            currentShape = "Line";
        }

        private void прямоугольникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SolidBrush Rectangle = new SolidBrush(Color.Black);
            currentShape = "Square";
        }

        private void кругToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SolidBrush Circle = new SolidBrush(Color.Black);
            currentShape = "Circle";
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                startPoint = e.Location;
                isDrawing = true;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                panel1.Invalidate(); 
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                using (Graphics g = panel1.CreateGraphics())
                {
                    DrawShape(g, startPoint, e.Location);
                }
                isDrawing = false;
            }
        }
        private void DrawShape(Graphics g, Point start, Point end)
        {
            switch (currentShape)
            {
                case "Line":
                    g.DrawLine(Pens.Black, start, end);
                    break;
                case "Circle":
                    int diameter = Math.Max(Math.Abs(end.X - start.X), Math.Abs(end.Y - start.Y));
                    g.DrawEllipse(Pens.Black, start.X, start.Y, diameter, diameter);
                    break;
                case "Square":
                    int side = Math.Max(Math.Abs(end.X - start.X), Math.Abs(end.Y - start.Y));
                    g.DrawRectangle(Pens.Black, start.X, start.Y, side, side);
                    break;
            }
        }
    }
}
