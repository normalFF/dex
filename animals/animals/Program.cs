using System;
using animals.TortoiseType;

namespace Tortoise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Tortoise***");
            var defaultTortoise = new DefaultTortoise("DefaultTortoise", "Обычное", "Обычный");
            var commodoreTortoise = new CommodoreTortoise("CommodoreTortoise", "Укреплённое", "Металический", " 10 lvl");
            var admiralTortoise = new AdmiralTortoise("AdmiralTortoise", "Бионическое", "Титановый", " 40 lvl", "12 lvl", "10 lvl");

            var turtles = new BaseTortoise[] { defaultTortoise, commodoreTortoise, admiralTortoise };
            foreach (var tortoise in turtles)
            {
                tortoise.ShowInfo();
            }
        }
    }
}
