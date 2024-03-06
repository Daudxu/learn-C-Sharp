using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            bool isCheck = true;

            for (; isCheck;)
            {
                Console.WriteLine("请输入你的年龄!");
                string str = Console.ReadLine();

                try
                {
                    age = int.Parse(str);
                    isCheck = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("请输入一个正确的年龄!");
              /*      throw;*/
                }
            }
           
        }
    }
}