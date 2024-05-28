using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 열거형
 * 상수를 문자열로 대치하여 선언
 * 상수에 의미 부여
 * 형식
 * - enum 열거형 명칭 {문자열1, 문자열2};
 * - enum 열거형 명칭 {문자열1 = 상수, 문자열2 = 상수};
 * - enum 열거형 명칭 {문자열1 = 상수, 문자열2};
 * 기본은 int형이지만 char형을 제외한 형식으로 지정할 수 있음
 * -> enum Days : byte {Sun = 0, Mon, Tue, Wed, Thu};(잘 쓰이지는 않음)
 * 열거형 변수가 아닌 변수에 열거형 값을 대입할 때는 데이터형을 명시할 것
 */

// 요일에 대한 열거형 변수를 정수형 변수에 대입하여 출력
namespace ConsoleApp16
{
    enum Days { Sun = 1, Mon, Tue, Wed, Thu, Fri, Sat }; // 나머지에 값이 자동으로 1씩 증가하여 저장됨

    internal class Program
    {
        static void Main(string[] args)
        {
            int nValue = (int) Days.Mon;
            Days day = Days.Tue;
            Console.WriteLine("{0} {1}", nValue, day);
        }
    }
}
