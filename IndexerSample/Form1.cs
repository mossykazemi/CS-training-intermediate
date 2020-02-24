using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndexerSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Polygon1 triangle = new Polygon1(3);
            triangle.SetVertex(0, new Point(10, 10));
            triangle.SetVertex(1, new Point(50, 50));
            triangle.SetVertex(2, new Point(10, 7));
            Point p = new Point();
            p = triangle.GetVertex(2);
            MessageBox.Show(p.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Polygon2 triangle = new Polygon2(3);
            triangle[0] = new Point(10, 10);
            triangle[1] = new Point(50, 50);
            triangle[2] = new Point(10, 70);
            MessageBox.Show(triangle[2].ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Polygon2 rect = new Polygon2(4);
            rect[0] = new Point(10, 10);
            rect[1] = new Point(80, 10);
            rect[2] = new Point(80, 130);
            rect[3] = new Point(10, 130);
            rect.Draw(this.CreateGraphics(), Color.Red);
        }
    }
}
