using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDraw
{
    class EllipsLine:Point
    {
        protected int XR;
        protected int YR;
        
        public EllipsLine()
        {
           

        }
        public EllipsLine(int x, int y, int x1, int y1, Color colors) : base(x, y, colors)
        {
            XR = x1;
            YR = y1;
        }
        public override void Draw(Graphics graphics)
        {
            SolidBrush cl = new SolidBrush(Color.Brown);
            graphics.DrawEllipse(new Pen(Color.Brown), X, Y, XR, YR);
            X = X + XR / 2;
            Y = Y + YR / 2;
            graphics.FillEllipse(cl, X, Y, 1, 1);
            XR = X + XR / 2;
            graphics.DrawLine(new Pen(Color.Brown), X, Y, XR, Y);

        }
    }
}
