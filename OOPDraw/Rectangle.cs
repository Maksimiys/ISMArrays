using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDraw
{
    class Rectangle : Line
    {
        private Random rm = new Random();
        public Rectangle()
        {
            
            

        }
        public Rectangle(int x,int y,int x1,int y1, Color colors):base (x,y,x1,y1,colors)
        {

        }
        public override void Draw(Graphics graphics)
        {

            graphics.DrawRectangle(new Pen(Color.Violet), X, Y, X1, Y1);

        }
        public void SetRectangle(int x, int y,int x1,int y1)
        {
            X = x;
            Y = y;
            X1 = x1;
            Y1 = y1;
        }
        public void SetRectangleColor(Color color)
        {
            colors = color;
        }
    }
}
