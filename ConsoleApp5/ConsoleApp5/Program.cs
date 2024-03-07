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
            
            Console.ReadKey();
        }

        static void GetUserInfo()
        {

        }
    }

    class Person
    {
        public string Name { get; set; }

        public string Sex { get; set; }

        public int Age { get; set; }
    }
}