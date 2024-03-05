using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldCS
{
    internal class Prggram
    {
        public static int _number = 0;
        static void Main(string[] arggs)
        {
            int a = 10;
            int b=  Test(a);
            int n = 100;
            int m = 200;
            var sum = n + m;
            Console.WriteLine(n);
            Console.WriteLine(m);
            Console.WriteLine(sum);
            Console.ReadKey();
        }

        public static int Test(int n)
        {
            return ++n;
        }

        public static void Ceshi()
        {
            string a = "anbc";
            Console.WriteLine(a);

        }


    }
}