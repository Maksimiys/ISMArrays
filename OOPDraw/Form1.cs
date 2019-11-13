using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShapesLibrary;

namespace OOPDraw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected List <Shape_Point> shapes;
        private void button1_Click(object sender, EventArgs e)
        {
            shapes = new List<Shape_Point>();
            Random rnd = new Random();
            Color colors = new Color();
            if (colorDialog1.ShowDialog() != DialogResult.OK)
                return;
            colors = colorDialog1.Color ;
            for(int i=0;i<trackBar1.Value;i++)
            {
                int number =rnd.Next(1,6) ;
                if(number==1)
                {
                    shapes.Add(new  ShapesLibrary.Point());
                }
                if(number==2)                
                {
                    shapes.Add(new ShapesLibrary.Line(rnd.Next(0, pictureBox1.Width), rnd.Next(0, pictureBox1.Height), rnd.Next(0,pictureBox1.Width), rnd.Next(0, pictureBox1.Height), colors));
                }
                if(number==3)
                {

                    shapes.Add(new ShapesLibrary.Rectangle(rnd.Next(0, pictureBox1.Width/2), rnd.Next(0, pictureBox1.Height/2), rnd.Next(0, pictureBox1.Width), rnd.Next(0, pictureBox1.Width), colors));
                }
                if(number==4)
                {
                    int radius = rnd.Next(0, pictureBox1.Width/2);
                    shapes.Add(new ShapesLibrary.EllipsLine(rnd.Next(0, pictureBox1.Width/2), rnd.Next(0, pictureBox1.Height/2),radius , colors));
                }
                if (number == 5)
                {
                    shapes.Add(new ShapesLibrary.Ellips(rnd.Next(0, pictureBox1.Width/2), rnd.Next(0, pictureBox1.Height/2),rnd.Next(0, pictureBox1.Width/2), rnd.Next(0, pictureBox1.Height/2), colors));
                }

            }
            pictureBox1.Refresh();

            for (int j = 0; j <trackBar1.Value; j++)
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
            pictureBox1.Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
           
                if (shapes != null)
                {
                    for (int i = 0; i <trackBar1.Value; i++)
                    {
                        shapes[i].Draw(e.Graphics);
                    }
                }
            
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
 Color colors = new Color();
            if (colorDialog1.ShowDialog() != DialogResult.OK)
                return;
            colors = colorDialog1.Color;
                Random rnd = new Random();
           switch(comboBox1.SelectedIndex)
            {
                
                case 0:
                
                    shapes.Add(new ShapesLibrary.Point());
                    break;
                case 1:
                
                    shapes.Add(new ShapesLibrary.Line(rnd.Next(0, pictureBox1.Width), rnd.Next(0, pictureBox1.Height), rnd.Next(0, pictureBox1.Width), rnd.Next(0, pictureBox1.Height), colors));
                    break;
                case 2:

                    shapes.Add(new ShapesLibrary.Rectangle(rnd.Next(0, pictureBox1.Width / 2), rnd.Next(0, pictureBox1.Height / 2), rnd.Next(0, pictureBox1.Width), rnd.Next(0, pictureBox1.Width), colors));
                    break;
                case 3:
                    int radius = rnd.Next(0, 200);
                    shapes.Add(new ShapesLibrary.EllipsLine(rnd.Next(0, pictureBox1.Width / 2), rnd.Next(0, pictureBox1.Height / 2), radius, colors));
                    break;
                case 4:
                    shapes.Add(new ShapesLibrary.Ellips(rnd.Next(0, pictureBox1.Width / 2), rnd.Next(0, pictureBox1.Height / 2), rnd.Next(0, pictureBox1.Width / 10), rnd.Next(0, pictureBox1.Height / 10), colors));
                    break;

            }
            for (int i = 0; i < shapes.Count; i++)
            {
                shapes[i].Draw(pictureBox1.CreateGraphics());
            }
        }
    }
}
