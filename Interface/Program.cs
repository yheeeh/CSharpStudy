using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 인터페이스
// 이벤트, 인덱서, 메서드, 속성을 포함
// 기본 권한은 public
// 관례적으로 대문자 I를 인터페이스명에 붙임
namespace Interface
{
    interface IA
    {
        void PrintA();
    }

    interface IB
    {
        void PrintB();
    }

    class B : IA {
        public void PrintA() { Console.WriteLine("Hello World!"); }
    }

    // 다중상속
    class C : IA, IB {
        public void PrintA() { Console.WriteLine("interface A"); }
        public void PrintB() { Console.WriteLine("interface B"); }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            b.PrintA();

            C c = new C();
            c.PrintA();
            c.PrintB();
        }
    }
}
