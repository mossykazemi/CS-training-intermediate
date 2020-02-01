using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using my=_nameSpaceExamples.myNamespace;
using you=_nameSpaceExamples.yourNamespace;

//using _nameSpaceExamples.myNamespace;
//using _nameSpaceExamples.yourNamespace;

// using mikonim ba kalameye my

namespace _nameSpaceExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            my.Rectangle r1 = new my.Rectangle();
            you.Rectangle r2 = new you.Rectangle();
            // r1 azayi dare ke r2 nadare
        }
    }
}
