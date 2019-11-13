using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ShapesLibrary
{
    public class Rectangle : Line
    {
        private Random rm = new Random();
        public Rectangle()
        {



        }
        public Rectangle(int x, int y, int x1, int y1, Color colors) : base(x, y, x1, y1, colors)
        {

        }
        public override void Draw(Graphics graphics)
        {

            graphics.DrawRectangle(new Pen(colors), X, Y, X1, Y1);

        }
        public override void Move(Graphics graphics, int x, int y)
        {
            X += x;
            Y += y;
        }

    }
}
