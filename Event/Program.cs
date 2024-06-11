using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// event
// 특정 상황이 발생했을 때 알리고자 하는 용도(호출 + 데이터 전송)
// 게시자: 이벤트를 발생시키는 클래스
// 구독자: 이벤트를 받거나 처리하는 클래스
// 델리게이트를 기반으로 함(메서드 호출)
// 이벤트는 메서드 안에서만 사용 가능
// 형식
// : 접근 한정자 event 델리게이트명 이벤트명
namespace Event
{
    delegate void DelegateType(string Message);

    class A
    {
        public event DelegateType EventHandler;

        public void Func(string Message)
        {
            EventHandler(Message);
        }
    }

    class B
    {
        public void PrintA(string Message)
        {
            Console.WriteLine(Message);
        }

        public void PrintB(string Message) { Console.WriteLine(Message); }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // 이벤트에 메서드 추가 및 삭제
            A a = new A();
            B b = new B();

            a.EventHandler += new DelegateType(b.PrintA);
            a.EventHandler += new DelegateType(b.PrintB);
            a.Func("Good!!");
            a.EventHandler -= b.PrintB;
            a.Func("Hi~!");
            a.EventHandler -= b.PrintA;

            a.EventHandler += b.PrintA;
            a.EventHandler += b.PrintB;
            
            a.Func("Hello World");

            /*
             * 이벤트의 핵심
             * 이벤트 핸들러에 객체의 메서드를 연결
             * 이벤트 핸들러는 객체 메서드에서 호출
             * 이벤트 핸들러를 포함하는 객체 안의 메서드를 통해 다른 객체 또는 같은 객체의 메서드를
             * 호출하기 위한 방법(같은 데이터 전달)
             */
        }
    }
}
