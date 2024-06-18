using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 생성자 호출 순서
상위 -> 하위

소멸자 호출 순서
하위 -> 상위
*/
namespace Inheritance2
{
    class A
    {
        public A()
        {
            Console.WriteLine("A 생성자");
        }

        ~A()
        {
            Console.WriteLine("A 소멸자");
        }        
    }

    class B : A {
        public B()
        {
            Console.WriteLine("B 생성자");
        }

        ~B() { Console.WriteLine("B 소멸자"); }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
        }
    }
}
