using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ShapesLibrary;

namespace OOPDROW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
             protected List<Shape_Point> shapes;
        Color colors = Color.Black;
        private void button1_Click(object sender, EventArgs e)
        {
            shapes = new List<Shape_Point>();
            Random rnd = new Random();
            //Color colors = new Color();
           
            for (int i = 0; i < trackBar1.Value; i++)
            {
                int number = rnd.Next(1, 6);
                if (number == 1)
                {
                    shapes.Add(new ShapesLibrary.Point());
                }
                if (number == 2)
                {
                    shapes.Add(new ShapesLibrary.Line(rnd.Next(0, pictureBox1.Width), rnd.Next(0, pictureBox1.Height), rnd.Next(0, pictureBox1.Width), rnd.Next(0, pictureBox1.Height), colors));
                }
                if (number == 3)
                {

                    shapes.Add(new ShapesLibrary.Rectangle(rnd.Next(0, pictureBox1.Width / 2), rnd.Next(0, pictureBox1.Height / 2), rnd.Next(0, pictureBox1.Width/5), rnd.Next(0, pictureBox1.Width/5), colors));
                }
                if (number == 4)
                {
                    int radius = rnd.Next(0, pictureBox1.Width / 2);
                    shapes.Add(new ShapesLibrary.EllipsLine(rnd.Next(0, pictureBox1.Width / 2), 
                        rnd.Next(0, pictureBox1.Height / 2), 
                        radius, 
                        colors));
                }
                if (number == 5)
                {
                    int radius = rnd.Next(0, pictureBox1.Width / 2);
                    shapes.Add(new ShapesLibrary.Ellips(rnd.Next(0, pictureBox1.Width / 2), 
                        rnd.Next(0, pictureBox1.Height / 2),radius,
                        colors));
                }
}
pictureBox1.Refresh();

            for (int j = 0; j < shapes.Count; j++)
            {
                shapes[j].Draw(pictureBox1.CreateGraphics());

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (shapes == null)
            {
                shapes = new List<Shape_Point>();
            }
            Random rnd = new Random();
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    shapes.Add(new ShapesLibrary.Point());
                    break;
                case 1:
                    shapes.Add(new ShapesLibrary.Line(rnd.Next(0, pictureBox1.Width),
                        rnd.Next(0, pictureBox1.Height), 
                        rnd.Next(0, pictureBox1.Width), 
                        rnd.Next(0, pictureBox1.Height), colors));
                    break;
                case 2:
                    shapes.Add(new ShapesLibrary.Rectangle(rnd.Next(0, pictureBox1.Width / 2), 
                        rnd.Next(0, pictureBox1.Height / 2), 
                        rnd.Next(0, pictureBox1.Width / 5), 
                        rnd.Next(0, pictureBox1.Width / 5), colors));
                    break;
                case 3:
                    int radius = rnd.Next(0, pictureBox1.Width / 2);
                    shapes.Add(new ShapesLibrary.EllipsLine(rnd.Next(0, pictureBox1.Width / 2),
                        rnd.Next(0, pictureBox1.Height / 2),
                        radius,
                        colors));
                    break;
                case 4:
                    int radius1 = rnd.Next(0, pictureBox1.Width / 2);
                    shapes.Add(new ShapesLibrary.Ellips(rnd.Next(0, pictureBox1.Width / 2),
                        rnd.Next(0, pictureBox1.Height / 2),radius1
                        , colors));
                    break;
            }
            //pictureBox1.Refresh();
            for (int j = 0; j < shapes.Count; j++)
            {
                shapes[j].Draw(pictureBox1.CreateGraphics());

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
 if (colorDialog1.ShowDialog() != DialogResult.OK)
return;
            colors = colorDialog1.Color;
            button4.BackColor = colors;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (shapes == null)
            {
                MessageBox.Show("Фігури відсутні", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if ((int)numericUpDown1.Value >= 0 && (int)numericUpDown1.Value < shapes.Count && shapes!=null)
                {
                    shapes.RemoveAt((int)numericUpDown1.Value);

                }
                else
                {
                    MessageBox.Show("Немає такого елементу", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            pictureBox1.Refresh();
            for (int j = 0; j < shapes.Count; j++)
            {
                shapes[j].Draw(pictureBox1.CreateGraphics());

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            shapes = null;
            pictureBox1.Refresh();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int x = (int)numericUpDown2.Value;
            int y = (int)numericUpDown3.Value;
            shapes[(int)numericUpDown1.Value].Move(pictureBox1.CreateGraphics(),x,y);
            pictureBox1.Refresh();
            for (int j = 0; j < shapes.Count; j++)
            {
                shapes[j].Draw(pictureBox1.CreateGraphics());

            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                int X = e.X;
                int Y = e.Y;
                if (shapes == null)
                {
                    shapes = new List<Shape_Point>();
                }
                Random rnd = new Random();
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        shapes.Add(new ShapesLibrary.Point(X, Y, colors));
                        break;
                    case 1:
                        shapes.Add(new ShapesLibrary.Line(X,
                            Y,
                            rnd.Next(0, pictureBox1.Width),
                            rnd.Next(0, pictureBox1.Height), colors));
                        break;
                    case 2:
                        shapes.Add(new ShapesLibrary.Rectangle(X,
                           Y,
                            rnd.Next(0, pictureBox1.Width / 5),
                            rnd.Next(0, pictureBox1.Width / 5), colors));
                        break;
                    case 3:
                        int radius = rnd.Next(0, pictureBox1.Width / 2);
                        shapes.Add(new ShapesLibrary.EllipsLine(X-radius/2, Y-radius / 2, radius, colors));
                        break;
                    case 4:
                        int radius1 = rnd.Next(0, pictureBox1.Width / 2);
                        shapes.Add(new ShapesLibrary.Ellips(X-radius1/2, Y-radius1/2,radius1, colors));
                        break;
                }
                for (int j = 0; j < shapes.Count; j++)
                {
                    shapes[j].Draw(pictureBox1.CreateGraphics());

                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }

