using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ShapesLibrary
{
    public class Ellips : EllipsLine
    {

        protected int  X1;
        public Ellips()
        {

        }
        public Ellips(int x, int y,int x1, Color colors) : base(x, y,x1,colors)
        {
            X1=x1;
        }
        public override void Draw(Graphics graphics)
        {
            // SolidBrush cl = new SolidBrush(Color.Black);
            graphics.DrawEllipse(new Pen(colors), X, Y, X1, X1);
            graphics.DrawLine(new Pen(colors), X+X1/2, Y + X1 / 2, X+X1, Y+X1 / 2);
            graphics.DrawLine(new Pen(colors), X + X1 / 2, Y + X1 / 2, X + X1 / 2, Y);
        }
        public override void Move(Graphics graphics, int x, int y)
        {
            X += x;
            Y += y;
        }

    }
}
