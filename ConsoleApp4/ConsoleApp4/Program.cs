using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Hero sa = new Hero();
            sa.xingbie = "man";
            sa.ShowInfo();
         /*   Hero.staitcInfo = "111";*/
            Console.WriteLine(Hero.staitcInfo);
        }
    }

    class Hero
    {
        public string mingzi;
        public string xingbie;
        public int nianling;
        public int shanghai;
        public int xueliang;
        public static string staitcInfo = "666";
        public void ShowInfo()
        {
            Console.WriteLine(xingbie);
        }
    }
}