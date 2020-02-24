using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace IndexerSample
{
    class Polygon1
    {
        private Point[] vertices;
        public void SetVertex(int i,Point v)
        {
            vertices[i] = v;
        }
        public Point GetVertex(int i)
        {
            return vertices[i];
        }
        public Polygon1(int n)
        {
            vertices = new Point[n];
        }
    }
}
