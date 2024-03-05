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
        static void Main(string[] args)
        {
            Console.WriteLine("请输入你的姓名：");
            string name = Console.ReadLine();

            Console.WriteLine("请输入你的年龄：");
            string age = Console.ReadLine();

            Console.WriteLine("请输入你的爱好：");
            string hobby = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("你的名字是：" + name);
            Console.WriteLine("请输入你的年龄：" + age);
            Console.WriteLine("请输入你的爱好：" + hobby);
            Console.ReadKey();
        }

    }
}