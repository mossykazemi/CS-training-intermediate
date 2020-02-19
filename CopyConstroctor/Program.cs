using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstroctor
{
    class Program
    {
        // copy constructor , ye copy az object vorodi ro dar objecti ke dar haale ejrast copy mikone
        // copy Constructor get's a copy of input object and gives it to the running object
        // be darde object hayi mikhore ke eyne ham hastan
        // it's useful for objects that are same 
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            Rectangle r2 = new Rectangle(r1);

            Console.ReadKey();
        }
    }
}
