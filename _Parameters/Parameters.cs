using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Parameters
{
    class Parameters
    {
        public int a;

        public void passByVal(int n)
        {
            n *= 5;
            //Console.WriteLine(n);
        }
        public void passByRef(ref int m)
        {
            m *= 5;
        }
        public void passByOut(out int c)
        {
            c = 10;

        }
    }
}
