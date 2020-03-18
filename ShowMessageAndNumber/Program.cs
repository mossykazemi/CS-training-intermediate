using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowMessageAndNumber
{
    class Program
    {
        static void showMessageAndNumber(string message,int number)
        {
            Console.WriteLine(message);
            Console.WriteLine($"number is:{number}");
        }
        static void Main(string[] args)
        {
            showMessageAndNumber("hello", 1376);
            //showMessageAndNumber(1376, "hello"); in eshtebahe 
            Console.ReadKey();
        }
    }
}
