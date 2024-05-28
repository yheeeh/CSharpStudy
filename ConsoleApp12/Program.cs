using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    // 구조체
/* 제한 사항
- 구조체에 선언된 const, static 변수만 초기화 가능
- 구조체 안에 선언할 수 있는 생성자는 매개변수가 반드시 있어야 함
*/
    public struct MyStruct
    {
        public const float PI = 3.14f;
        public static int Age = 12;
        // public int val = 10; -> 에러
        public int Val;
        public MyStruct(int InVal) { Val = InVal; }
    }
internal class Program
{
    static void Main(string[] args)
    {
            Console.WriteLine("{0} {1}", MyStruct.PI, MyStruct.Age);

            MyStruct TestStruct1;
            TestStruct1.Val = 10;
            Console.WriteLine(TestStruct1.Val);

            MyStruct TestStruct2 = new MyStruct();
            Console.WriteLine(TestStruct2.Val);

            MyStruct TestStruct = new MyStruct(20);
            Console.WriteLine(TestStruct.Val);
    }
}
}
