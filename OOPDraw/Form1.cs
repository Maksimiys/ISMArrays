using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPDraw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Shape_Point[] shapes = new Shape_Point[21];
            Random rnd = new Random();
            Color colors = new Color();
            colors = Color.Green;
            for(int i=0;i<shapes.Length;i++)
            {
                int number =rnd.Next(1,6) ;
                if(number==1)
                {
                    shapes[i] = new Point();
                }
                if(number==2)                
                {
                    shapes[i] = new Line(rnd.Next(0, 600), rnd.Next(0, 300), rnd.Next(0, 600), rnd.Next(0, 300), colors);
                }
                if(number==3)
                {
                    shapes[i] = new Rectangle(rnd.Next(0, 500), rnd.Next(0, 200), rnd.Next(0, 100), rnd.Next(0, 100), colors);
                }
                if(number==4)
                {
                    int radius = rnd.Next(0, 100);
                    shapes[i] = new EllipsLine(rnd.Next(0, 500), rnd.Next(0, 200),radius , radius, colors);
                }
                if (number == 5)
                {
                    shapes[i] = new Ellips(rnd.Next(0, 500), rnd.Next(0, 200),rnd.Next(0, 100), rnd.Next(0, 100), colors);
                }

            }
            for (int j = 0; j < shapes.Length; j++)
                {
                    shapes[j].Draw(pictureBox1.CreateGraphics());
                }
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
    }
}
