using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ShapesLibrary
{
    public class Ellips : EllipsLine
    {

        protected new int  YR;
        public Ellips()
        {

        }
        public Ellips(int x, int y, Color colors) : base(x, y,colors)
        {

            YR = Y / 2;
        }
        public override void Draw(Graphics graphics)
        {
            // SolidBrush cl = new SolidBrush(Color.Black);
            graphics.DrawEllipse(new Pen(colors), X, Y, YR, YR);
            graphics.DrawLine(new Pen(colors), X+YR/2, Y + YR / 2, X+YR, Y+YR / 2);
            graphics.DrawLine(new Pen(colors), X + YR / 2, Y + YR / 2, X + YR / 2, Y);
        }
        public override void Move(Graphics graphics, int x, int y)
        {
            X += x;
            Y += y;
        }

    }
}
