using System;
using System.Drawing;

namespace OOPDraw
{
    public class Point : Shape_Point
    {
        // protected int X;
        ////protected int Y;
        //protected Color colors;
        protected Brush point = new SolidBrush(Color.Red);
        private Random rn = new Random();
        public Point()
        {

            X = rn.Next(0, 500);
            Y = rn.Next(0, 300);
            colors = Color.Red;
        }
        public Point(int x, int y, Color colors) : base(x, y, colors)
        {

        }
        public void Copy(Point shapes)
        {
            X = shapes.X;
            Y = shapes.Y;
            colors = shapes.colors;
        }
        public override void Draw(Graphics graphics)
        {
            graphics.FillEllipse(point, X, Y, 3, 3);
        }
        public void SetPoint(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void SetColor(Color color)
        {
            colors = color;
        }


    }
}
