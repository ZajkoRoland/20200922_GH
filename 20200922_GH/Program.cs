using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200922_GH
{
    class Program
    {
        static Random rnd = new Random();
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Zajkó Roland");
            for (int i = 0; i < 100; i++)
            {
                Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);
                Console.SetCursorPosition(
                    rnd.Next(Console.WindowWidth),
                    rnd.Next(Console.WindowHeight));
                Console.WriteLine("*");
            }
            Console.ReadKey(true);
        }

    }
}
