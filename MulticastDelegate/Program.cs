using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 멀티캐스트 델리게이트(multicast delegate)
// : 데이터를 여러 사용자에게 동시에 보내다
// 델리게이트 조합
// 역할: 다수 또는 단일 메서드 호출
// +=, -= -> 호출할 메서드 포함 또는 제거
namespace MulticastDelegate
{
    delegate void DelgateType();

    class A
    {
        public void PrintA()
        {
            Console.WriteLine("PrintA");
        }

        public void PrintB() { Console.WriteLine("PrintB"); }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            A test = new A();
            DelgateType DelFunc = test.PrintA;
            DelFunc += test.PrintB;
            DelFunc();
            DelFunc -= test.PrintA;
            DelFunc();
        }
    }
}
