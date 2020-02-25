using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace IndexerSample
{
    class Polygon2
    {
        private Point[] vertices;
        public Polygon2(int n)
        {
            vertices = new Point[n];
        }
        public Point this[int i]
        {
            set
            {
                vertices[i] = value;
            }
            get
            {
                return vertices[i];
            }
        }
        public void Draw(Graphics x,Color c)
        {
            int i;
            for(i = 0; i<vertices.Length-1; i++)
                x.DrawLine(new Pen(c), vertices[i], vertices[i + 1]);
            x.DrawLine(new Pen(c), vertices[i], vertices[0]);
        }
    }
}
