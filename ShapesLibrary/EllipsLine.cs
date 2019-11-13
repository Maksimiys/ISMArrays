using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ShapesLibrary
{
    public class EllipsLine : Point
    {
        protected int XR,YR;

        public EllipsLine()
        {


        }

        public EllipsLine(int x, int y, Color colors)
        {
            X = x;
            Y = y;
            this.colors = colors;
        }

        public EllipsLine(int x, int y, int x1, Color colors) : base(x, y, colors)
        {
            XR = x1;
        }
        public override void Draw(Graphics graphics)
        {
            SolidBrush cl = new SolidBrush(colors);
            graphics.DrawEllipse(new Pen(colors), X, Y, XR, XR);
            graphics.DrawLine(new Pen(colors), X+XR/2, Y + XR / 2, X+XR, Y+XR/2);
        }
        public override void Move(Graphics graphics, int x, int y)
        {
            X += x;
            Y += y;
        }

    }
}
