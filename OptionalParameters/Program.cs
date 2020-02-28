using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    class Program
    {
        // Optional Parameters
        static void PrintMessage(string message = "Learning C#")
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            PrintMessage();
            PrintMessage("Mossy Kazemi");

            Console.ReadKey();
        }
    }
}
