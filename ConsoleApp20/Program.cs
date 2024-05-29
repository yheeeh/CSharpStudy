using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* as 연산자
 * 역할
 * - 형변환(캐스팅)과 변환 조사
 * - 불변환은 null 리턴
 * 참조, 박싱, 언박싱, null형에 사용
 * 형식
 * : 결과형 = 참조형, 언박싱, 박싱 as 변환형
 */
namespace ConsoleApp20
{
    class A { }

    class B { }
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "123";
            object obj = str1;
            string str2 = obj as string;
            Console.WriteLine(str2);

            A test1 = new A();
            object obj1 = test1;
            B test2 = obj1 as B;
            if (test2 == null)
                Console.WriteLine("형변환 실패");
            else
                Console.WriteLine("형변환 성공");
        }
    }
}
