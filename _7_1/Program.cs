using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(100, 40);
            Random rd = new Random();
            ConsoleColor[] Color = { ConsoleColor.Blue, ConsoleColor.Cyan, ConsoleColor.Red,
            ConsoleColor.Yellow, ConsoleColor.Green, ConsoleColor.Magenta, ConsoleColor.Gray };

            while (true)
            {
                Console.Clear();
                for (int i = 0; i < 30; i++)
                {
                    Console.ForegroundColor = Color[rd.Next(Color.Length)];
                    Console.SetCursorPosition(rd.Next(100), rd.Next(40));
                    Console.Write("Hello World!");
                }
                Thread.Sleep(200);
            }
        }
    }
}
