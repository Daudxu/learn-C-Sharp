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
            //变量类型
            IntDemo();
            StringDemo();
            BoolDemo();
            Test();
            Console.ReadKey();
        }

        public static void IntDemo()
        {
            Console.WriteLine("int 使用案例");
            int a = 10;
            int b = 20;
            Console.WriteLine(a + b);

            int n1 = 20;
            Console.WriteLine(n1);
            int n2 = 30;
            Console.WriteLine(n2);

            int temp = 0;
            Console.WriteLine(temp);
            temp = n1; //20
            Console.WriteLine(temp);
            n1 = n2; //30
            Console.WriteLine(n2);
            Console.WriteLine(n1);
            n2 = temp; //20
            Console.WriteLine(n2);

        }

        public static void StringDemo()
        {
            Console.WriteLine("string 使用案例");
            string a = "anbc";
            Console.WriteLine(a);
        }

        public static void BoolDemo()
        {
            Console.WriteLine("bool 使用案例");
            bool a = false;
            bool b = true;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        public static void Test()
        {
            Console.WriteLine("请输入一个数字");
            string str = Console.ReadLine();
            if (IsNumeric(str))
            {
                int mum = int.Parse(str) + 20;
                Console.WriteLine(mum);
            }
            else
            {
                string str1 = str + 20.ToString();
                Console.WriteLine(str1);

            }
        }

        static bool IsNumeric(string str)
        {
            return double.TryParse(str, out _);
        }

    }
}