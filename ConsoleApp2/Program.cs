using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _params
{
    class Program
    {
        // kalameye params hamishe dar akhare arguman miad
        static int CalculateSum (params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateSum(1,2,3,4,5));
            Console.WriteLine(CalculateSum(2,6));
            Console.WriteLine(CalculateSum(7,8,9,5,4,6,4,5));
            int result;
            result=CalculateSum(2, 5, 6, 4);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
