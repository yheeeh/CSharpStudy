using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static2
{
    internal class Program
    {
        static string Message = "Hello World!";
        static void Print() { Console.WriteLine(Message); }
        static void Main(string[] args)
        {
            Print();
        }
    }
}
