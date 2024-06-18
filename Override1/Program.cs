using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
오버라이드 대상: 메서드, 속성, 인덱서, 이벤트(보통은 메서드에 사용)
상위 클래스에는 virtual 명시
하위 클래스에는 override 명시
*/
namespace Override
{
    class A
    {
        public virtual void Print()
        {
            Console.WriteLine("A Print");
        }
    }

    class B : A {
        public override void Print() { Console.WriteLine("B Print"); }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            b.Print();

            A a = b;
            a.Print();
        }
    }
}
