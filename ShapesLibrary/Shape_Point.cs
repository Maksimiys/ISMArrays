using System;
using System.Drawing;

namespace ShapesLibrary
{
    public abstract class Shape_Point
    {
        protected int X;
        protected int Y;
        protected Color colors;

        public Shape_Point()
        {

        }
        public Shape_Point(int x, int y, Color color)
        {
            X = x;
            Y = y;
            colors = color;
        }
        public abstract void Draw(Graphics graphics);
        public abstract void Move(Graphics graphics, int x, int y);
    }
}
