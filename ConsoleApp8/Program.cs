using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 데이터형이 분명한 var형을 선언한 후에 초기화해보고 두 값을 더한 결과 출력
namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* var: 암시적 데이터형
             * var를 사용할 수 없는 경우
             * 1. null 값 초기화
             * 2. 메서드의 매개변수
             * 3. 클래스 멤버(지역변수로만 사용 가능)
             * 4. 연속적인 초기화(예: var m = 10, n = 20; -> 이런 형태로 사용 불가)
             */
            var value1 = 3.14f;
            float value2 = 10.0f;
            float sum = value1 + value2;
            Console.WriteLine("{0} {1:f1} {2}", value1, value2, sum);
        }
    }
}
