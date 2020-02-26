using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSignatureAndOverride
{
    class Program
    {
        static void ShowMessage(double number)
        {
            Console.WriteLine("double version of method is called.");
        }
        static void ShowMessage(int number)
        {
            Console.WriteLine("integer version of method is called.");
        }
        static void Main(string[] args)
        {
            ShowMessage(10);
            ShowMessage(10.5);
            // emzaye method ro khodesh tashkhis mide ke double hast ya int

            Console.ReadKey();
        }
    }
}
