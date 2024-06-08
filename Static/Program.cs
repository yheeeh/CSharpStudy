using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// C#에서 static 역할 : 객체를 생성하지 않고 멤버 사용
namespace Static
{
    class MyClass
    {
        public static int number = 25;
        public static void Print() { Console.WriteLine("Hello World!"); }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass.Print();
            Console.WriteLine(MyClass.number);
            MyClass.number = 200;
            MyClass test = new MyClass();
            Console.WriteLine(MyClass.number);
        }
    }
}
