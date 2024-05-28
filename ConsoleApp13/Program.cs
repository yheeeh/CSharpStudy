using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 구조체를 같은 구조체에 대입하게 되면 값이 복사됨
namespace ConsoleApp13
{
    public struct MyStruct
    {
        public int Age;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStruct TestStruct1, TestStruct2; // 구조체는 값 형식이라 선언만으로도 사용 가능

            TestStruct2.Age = 10;
            // Console.WriteLine(TestStruct1.Age); -> 초기화되지 않은 값을 쓰려고 하면 에러 뜸
            
            MyStruct test;
            test = new MyStruct();
            Console.WriteLine(test.Age); // -> new를 통해 생성하면 값이 0으로 초기화 됨

            TestStruct1 = TestStruct2;
            Console.WriteLine(TestStruct1.Age);
        }
    }
}
