using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ShapesLibrary
{
    public class Point : Shape_Point
        {
            
            protected Brush point = new SolidBrush(Color.Red);
            private Random rn = new Random();
            public Point()
            {

                X = rn.Next(0, 500);
                Y = rn.Next(0, 300);
                colors = Color.Red;
            }
            public Point(int x, int y, Color colors) : base(x, y, colors)
            {

            }
            public void Copy(Point shapes)
            {
                X = shapes.X;
                Y = shapes.Y;
                colors = shapes.colors;
            }
            public override void Draw(Graphics graphics)
            {
                graphics.DrawEllipse(new Pen(colors), X, Y, 3, 3);
            }
        public override void Move(Graphics graphics,int x,int y)
        {
            X+=x;
            Y+=y;
                
        }


    }
}
