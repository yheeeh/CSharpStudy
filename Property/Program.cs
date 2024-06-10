using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 속성(property): 사물의 특징이나 성질
// 역할: 클래스 안의 멤버변수에 값 읽기 또는 저장
// private으로 선언된 멤버 변수를 말함
// 키워드: get, set, value, return
namespace Property
{
    class A
    {
        private int number;
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Number
        {
            get { return number; }
            set
            {
                if (value < 0 || value > 10)
                    number = 0;
                else number = value;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.Name = "Microsoft C#";
            a.Number = 10;
            Console.WriteLine("{0} {1}", a.Name, a.Number);
            a.Number = -7;
            Console.WriteLine(a.Number);
        }
    }
}
