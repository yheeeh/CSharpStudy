using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 접근 한정자
// 클래스 멤버에 적용: private(기본), protected, public, internal, protected internal
// 클래스 자체에 적용: public -> 명시적, internal -> 암시적(기본) 
// internal
// - 같은 어셈블리(exe, dll == 프로젝트) 안에 있을 때만 내외부에서 멤버에 접근 가능
// - 클래스 서두에 접근 한정자를 생략하면 internal로 설정됨
// protected internal(사용 빈도가 낮음)
// - 같은 어셈블리 안에서는 internal과 동일
// - 서로 다른 어셈블리 안에서 상속관계일 때 하위 클래스는 상위 클래스의 멤버에 접근 가능

// 소멸자 
// - 클래스명과 같음
// - 리턴형 없음
// - 접근 한정자나 매개변수가 없음
// - ~로 시작
// - 임의로 호출 불가 -> 가비지컬렉터가 알아서 처리함
namespace Destructor
{
    class MyClass
    {
        ~MyClass() { Console.WriteLine("소멸자 호출"); }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass test = new MyClass();
        }
    }
}
