using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static bool BoolVar; // 디폴트값은 False
        static void Main(string[] args)
        {
            bool LocalBoolVar = true;
            Console.WriteLine("{0} {1}", BoolVar, LocalBoolVar);
        }
    }
}
