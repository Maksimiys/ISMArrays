using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDraw
{
    public class Ellips:EllipsLine
    {
        public Ellips()
        {

        }
        public Ellips(int x, int y, int x1, int y1, Color colors) : base(x, y,x1,y1 ,colors)
        {
           
        }
        public override void Draw(Graphics graphics)
        {
            SolidBrush cl = new SolidBrush(Color.Black);
            graphics.DrawEllipse(new Pen(Color.Orange), X, Y, XR, YR);
            X = X + XR / 2;
            Y = Y + YR / 2;
            graphics.FillEllipse(cl, X, Y, 1, 1); 
            int yr = Y - YR / 2;
            graphics.DrawLine(new Pen(Color.Orange), X, Y, X, yr);
            XR = X + XR / 2;
            graphics.DrawLine(new Pen(Color.Orange), X, Y, XR, Y);
           

        }
    }
}
