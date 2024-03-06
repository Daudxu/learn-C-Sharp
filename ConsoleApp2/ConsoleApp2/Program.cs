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
            Test();

            while (true) // 循环，直到用户选择退出
            {
                GetUserInfo();
                Console.WriteLine("是否继续？(Y/N)");
                string continueInput = Console.ReadLine();

                if (continueInput.ToLower() != "y") // 如果用户输入不是 'y'，则退出循环
                {
                    break;
                }
                Console.ReadKey();
            }


        }

        public static void Test()
        {
    /*        for(int i = 0; i<10; i++)
            {
                Console.WriteLine(i);
            }*/
            Console.WriteLine("请输入一个数字：");
            string str = Console.ReadLine();
            int age = 0;
            try
            {
                age = int.Parse(str);

            }catch(Exception e)
            {
                Console.WriteLine("报错了："+ e);
                return;
            }
            
        }

        public static void GetUserInfo()
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
        }
    }
}