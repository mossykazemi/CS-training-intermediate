using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            // sazande methodi hast ham naam ba kelas ke karesh meghdar dehie avalie kardane

            Rectangle r1 = new Rectangle();
            // inja ham mishe meghdar bedim ham nadim chon constructore ma meghdare 
            //avalie dade khodesh va age parantez ha khali bashe moshkeli nist
            r1.GetLength();
            r1.GetBreadth();
            Console.WriteLine(r1.GetArea());
        }
    }
}
