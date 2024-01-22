using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDraft
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private AddShapeDropDown addShapeDropDown;
        private string shape="";
        private int startX, startY, shapeWidth, shapeHeight;
        private bool isDropDownShown=false;

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                isDropDownShown = true;
                addShapeDropDown = new AddShapeDropDown();
                addShapeDropDown.Location = GetDropDownPoint(sender, e.X, e.Y);
                addShapeDropDown.ShapeDrawn += OnShapeDrawing;
                addShapeDropDown.Show();
            }
        }

        private Point GetDropDownPoint(object sender, int X, int Y)
        {
            Point newPoint = new Point(X, Y);

            

            if (sender is Panel)
            {
                newPoint = PointToScreen(new Point(X, Y));
            }
            else
            {
                newPoint = PointToScreen(new Point(X, Y));
                if (addShapeDropDown.Height >= (Height - Y - 29))
                {
                    newPoint = new Point(newPoint.X, newPoint.Y - addShapeDropDown.Height);
                }
            }

            if (addShapeDropDown.Width >= (Width - X))
            {
                newPoint = new Point(newPoint.X - addShapeDropDown.Width, newPoint.Y);
            }
            return newPoint;
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if(isDropDownShown)
            {
                addShapeDropDown.Dispose();
                isDropDownShown = false;
            }
        }

        private void OnShapeDrawing(object sender, string e)
        {
            addShapeDropDown.Dispose();
            isDropDownShown = false;
            shape = e;
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DoubleBuffered = true;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            switch (shape)
            {
                case "circle":      shapeHeight = shapeWidth = Math.Min(panel1.Width, panel1.Height);
                                    startX = (panel1.Width - shapeHeight) / 2;  startY = 0;
                                    e.Graphics.FillEllipse(new SolidBrush(Color.Red), startX, startY, shapeWidth, shapeHeight);
                                    break;

                case "triangle":    Point[] points1 = new Point[3] { new Point(panel1.Width / 2, panel1.Height / 20), new Point(panel1.Width / 20, panel1.Height * 19 / 20), new Point(panel1.Width * 19 / 20, panel1.Height * 19 / 20) };
                                    e.Graphics.FillPolygon(new SolidBrush(Color.Red), points1);
                                    break;

                case "rectangle":   shapeWidth = Width * 18 / 20; shapeHeight = Height * 19 / 20;
                                    startX = Width / 20; startY = Height / 20;
                                    e.Graphics.FillRectangle(new SolidBrush(Color.Red), startX, startY, shapeWidth, shapeHeight);
                                    break;

                case "hexagon":     Point[] points2 = new Point[6] { new Point(panel1.Width / 3, panel1.Height / 20), new Point(panel1.Width * 2 / 3, panel1.Height / 20), new Point(panel1.Width * 19 / 20, panel1.Height / 2), new Point(panel1.Width * 2 / 3, panel1.Height *19/ 20) , new Point(panel1.Width /3, panel1.Height * 19/ 20) , new Point(panel1.Width / 20, panel1.Height / 2) };
                                    e.Graphics.FillPolygon(new SolidBrush(Color.Red), points2);
                                    break;
                default: break;
            }
        }
    }
}
