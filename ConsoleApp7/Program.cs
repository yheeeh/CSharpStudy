using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "C:\\temp\\test.txt";
            string str2 = @"C:\temp\test.txt";
            Console.WriteLine(str1);
            Console.WriteLine(str2);
        }
    }
}
