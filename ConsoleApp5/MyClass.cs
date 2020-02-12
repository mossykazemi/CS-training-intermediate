using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class MyClass
    {
        public int a;
        public static int b;
        public void SetB(int n)
        {
            b = n;
            //baraye inke meghdar az karbar gerefte shavad
        }
        public static void ShowB()
        {
            Console.WriteLine(b);
        }
        //azaye static ham dar method haye mamoli ghabele dastressi hastan ham dar static ha
        //ama azaye mamoli faghat dar method haye mamoli ghabel dastress hastan
    }
}
