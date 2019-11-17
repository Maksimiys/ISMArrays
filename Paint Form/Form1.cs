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
        {
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

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            switch (Mode)
            {
                case Mode.DrawPoint:
                    Graphics graphics = pictureBox1.CreateGraphics();
                    graphics.DrawEllipse(new Pen(Color.Red), MouseX1, MouseY1, 2, 2);
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mode = Mode.DrawEllips;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxShapes.SelectedIndex >= 0)
            {
                Shapes.RemoveAt(listBoxShapes.SelectedIndex);
                listBoxShapes.Items.RemoveAt(listBoxShapes.SelectedIndex);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            switch (Mode)
            {
                case Mode.DrawPoint:
                    MouseX1 = e.X;
                    MouseY1 = e.Y;
                    Shape_Point point = new ShapesLibrary.Point(MouseX1,
                                                                             MouseY1,
                                                                             colors);
                    AddShape(point);
                    break;
            }
        }
    }
}
