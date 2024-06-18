using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* base
   - 상위 클래스의 생성자 또는 멤버 변수 및 메서드 호출
   - 멤버 이름이 중복될 때
   - 하위에서 상위 설정을 활용할 때(주로 생성자)

    sealed
   - 봉인된
   - 상속 불가에 대한 명시
   - 클래스, 메서드, 프로퍼티에 사용 가능
   - 구조체는 암시적으로 봉인됨
*/
namespace Inheritance3
{
    class A
    {
        int number;
        protected string name = "Hello";
        
        public A(int num)
        {
            number = num;
        }

        public void PrintA()
        {
            Console.WriteLine(number);
        }          
    }

    class B : A
    {
        string name = "World";
        public B(int num) : base(num) { }

        public void PrintB()
        {
            Console.WriteLine("{0} {1}", base.name, name);
        }
    }

    sealed class A2 { }   

    /*class B : A2 -> 상속 불가. 에러 남
    {

    }*/

    internal class Program
    {
        static void Main(string[] args)
        {
            B test = new B(3);
            test.PrintA();
            test.PrintB();
        }
    }
}
