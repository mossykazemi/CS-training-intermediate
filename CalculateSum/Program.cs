using System;

namespace CalculateSum
{
    class Program
    {
        static int Calcsum()
        {
            int num1 = 10, num2 = 20;
            //int sum = num1 + num2;
            //return sum;
            return num1 + num2;
        }
        static void Main(string[] args)
        {
            var result = Calcsum();

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
