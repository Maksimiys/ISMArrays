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

namespace Paint_Form
{
    public partial class Form1 : Form
    {
        protected List<Shape_Point> Shapes;
        protected Mode Mode;
        Color colors = Color.Black;
        protected int MouseX1, MouseY1, MouseX2, MouseY2;
        public void AddShape(Shape_Point shape)
        {if (Shapes == null)
            {
                Shapes = new List<Shape_Point>();
            }
            Shapes.Add(shape);
            listBoxShapes.Items.Add(shape);

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button4.BackColor = colorDialog1.Color;
                colors = colorDialog1.Color;
            }
        }

        private void listBoxShapes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Point_Click(object sender, EventArgs e)
        {
            Mode = Mode.DrawPoint;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mode = Mode.DrawLine;
        }

       

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (Shapes == null)
            {
                Shapes = new List<Shape_Point>();
            }
            for (int j = 0; j < Shapes.Count; j++)
            {
               Shapes[j].Draw(e.Graphics);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mode = Mode.DrawEllips;
        }

        

        public void DeleteShape(int number)
        {
            Shapes.RemoveAt(number);
            listBoxShapes.Items.RemoveAt(number);
            pictureBox1.Refresh();
            
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {

            DeleteShape(listBoxShapes.SelectedIndex);
           
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            switch (Mode)
            {
                case Mode.DrawPoint:
                    MouseX1 = e.X;
                    MouseY1 = e.Y;
                    //Shapes.Add(new ShapesLibrary.Point());
                    Shape_Point point = new ShapesLibrary.Point(MouseX1,MouseY1, colors);
                   // point.Draw(pictureBox1.CreateGraphics());
                    AddShape(point);
                    break;
                case Mode.DrawLine:
                    MouseX1 = e.X;
                    MouseY1 = e.Y;
                    break;
                case Mode.DrawEllips:
                    MouseX1 = e.X;
                    MouseY1 = e.Y;
                    break;
            }
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {Graphics graphics = pictureBox1.CreateGraphics();
            switch (Mode)
            {
                case Mode.DrawLine:
                    if (e.Button == MouseButtons.Left)
                    {
                        pictureBox1.Refresh();
                        MouseX2 = e.X;
                        MouseY2 = e.Y;
                        graphics.DrawLine(new Pen(colors), MouseX1, MouseY1, MouseX2, MouseY2); ;
                    }
                        break;
                case Mode.DrawEllips:
                    if (e.Button == MouseButtons.Left)
                    {
                        pictureBox1.Refresh();
                        MouseX2 = e.X;
                        MouseY2 = e.Y;
                        graphics.DrawEllipse(new Pen(colors), MouseX1, MouseY1, (MouseX2-MouseX1), (MouseY2-MouseY1));
                    }
                    break;
            }
        } 
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            switch (Mode)
            {
                case Mode.DrawPoint:
                    
                    graphics.DrawEllipse(new Pen(colors), MouseX1, MouseY1, 2, 2);
                    break;
                case Mode.DrawLine:
                    //pictureBox1.Refresh();
                    MouseX2 = e.X;
                    MouseY2 = e.Y;
                   
                    graphics.DrawLine(new Pen(colors), MouseX1, MouseY1, MouseX2, MouseY2);
                    Shape_Point Line = new ShapesLibrary.Line(MouseX1, MouseY1,MouseX2,MouseY2, colors);
                    // point.Draw(pictureBox1.CreateGraphics());
                    AddShape(Line);
                    break;
                case Mode.DrawEllips:
                        MouseX2 = e.X;
                        MouseY2 = e.Y;
                        graphics.DrawEllipse(new Pen(colors), MouseX1, MouseY1, (MouseX2 - MouseX1), (MouseY2 - MouseY1));
                    Shape_Point Ellips = new ShapesLibrary.Ellips(MouseX1, MouseY1, (MouseX2 - MouseX1), (MouseY2 - MouseY1), colors);
                    AddShape(Ellips);
                    break;
            }
        }
    }
}
