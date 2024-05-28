using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 구조체는 값 형식이고 클래스는 참조 형식
namespace ConsoleApp14
{
    public struct MyStruct
    {
        public int Age;
    }

    class MyClass
    {
        public int Age;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyStruct test1 = new MyStruct();
            test1.Age = 12;
            MyStruct test2 = test1;
            test2.Age = 24;
            Console.WriteLine("{0} {1}", test1.Age, test2.Age);

            MyClass test3 = new MyClass();
            test3.Age = 12;
            MyClass test4 = test3;
            test4.Age = 24;
            Console.WriteLine("{0} {1}", test3.Age, test4.Age);
            // -> 같은 값이 나옴(참조한다 == 별명이 생긴다)
        }
    }
}
