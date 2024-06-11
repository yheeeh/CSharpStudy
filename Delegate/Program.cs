using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 델리게이트(delegate)
// 사전적 의미: 위임하다
// 역할: 복수 또는 단일 메서드를 대신하여 호출(같은 형식이어야 함)
// 메서드만 호출 가능하며 외부에서 호출하는 것도 가능(private, protected 메서드는 불가) 
// 형식
// 접근 한정자 delegate return형 델리게이트타입명(메서드 매개변수);
namespace Delegate
{
    delegate void DelegateType(string str);

    class A
    {
        public void Print(string str)
        { Console.WriteLine(str); }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            A Test = new A();
            // C# 1.0 이상
            DelegateType DelMethod1 = new DelegateType(Test.Print); 
            DelMethod1("Hello World!");

            // C# 2.0 이상(더 간편해짐)
            DelegateType DelMethod2 = Test.Print;
            DelMethod2("Hello World!");
        }
    }
}
