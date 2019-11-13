using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDraw
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

    }
}
