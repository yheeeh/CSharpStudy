using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BoxingAndCasting
{
    class A
    {
        public void PrintA() { Console.WriteLine("Hello"); }
    }

    class B : A
    {
        public void PrintB() { Console.WriteLine("World"); }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            B Test1 = new B();
            object obj = Test1;
            A Test2 = (A)obj;
            Test2.PrintA();
            Test1.PrintB();
        }
    }
}
