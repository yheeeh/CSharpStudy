using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    class A
    {
        private void PrintPrivate()
        {
            Console.WriteLine("private");
        }

        protected void PrintProtected()
        {
            Console.WriteLine("protected");
        }

        public void PrintPublic()
        {
            Console.WriteLine("public");
        }
    }

    class B : A // B에서 A를 상속받음
    {
        public void Print()
        {
            // PrintPrivate()은 사용 불가
            PrintProtected();
            PrintPublic();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            B test = new B();
            test.Print();
            test.PrintPublic();
        }
    }
}
