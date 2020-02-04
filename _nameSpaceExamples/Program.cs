using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using my=_nameSpaceExamples.myNamespace;
using you=_nameSpaceExamples.yourNamespace;

//using _nameSpaceExamples.myNamespace;
//using _nameSpaceExamples.yourNamespace;

// using whith (my) keyword
// using whith (you) keyword

namespace _nameSpaceExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            my.Rectangle r1 = new my.Rectangle();
            r1.ln = 10;
            you.Rectangle r2 = new you.Rectangle();
            r2.ln = 10;

            // r1 azayi dare ke r2 nadare
        }
    }
}
