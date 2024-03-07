using ConsoleApp5;
using ConsoleApp6;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var PersonObj = new Person();
            PersonObj.Name = "张三";
            PersonObj.Sex = "男";
            PersonObj.Age = 18;

            Console.WriteLine("姓名："+ PersonObj.Name);
            Console.WriteLine("性别："+ PersonObj.Sex);
            Console.WriteLine("年龄："+ PersonObj.Age);
            Console.WriteLine("爱好：" + Person.hobby);
            Person.GetUserInfo();
            ShowInfo.ShpwHeroInfo(PersonObj);
            Console.ReadKey();
        }

    }

  
}