using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDraw
{
    public class Line : Point
    {
       
        protected int X1;
        protected int Y1;
        //protected Random rnd = new Random();
        public Line()
        {
            
        }
        public Line(int x, int y,int x1,int y1, Color colors ):base(x,y,colors)
        {
            X1 = x1;
            Y1 = y1;
        }
        public override void Draw(Graphics graphics)
        {
            
            graphics.DrawLine(new Pen(colors), X, Y, X1, Y1);
            
        }
        public void SetLine(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void SetColorLine(Color color)
        {
            colors = color;
        }
    }
}
