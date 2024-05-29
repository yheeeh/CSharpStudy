using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* is 연산자
 * 형식 호환을 조사하는 연산자
 * 변수 is 클래스형 or 데이터형 -> 결과는 true, false
 * 박싱/언박싱 변환, 참조 변환에서 사용
 */
namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nValue = 10;
            if (nValue is float)
                Console.WriteLine("호환됨");
            else
                Console.WriteLine("호환 안 됨");
            if (nValue is object) // boxing 호환
                Console.WriteLine("호환됨");
            else
                Console.WriteLine("호환 안 됨");

            object obj = nValue;
            if (obj is int)
                Console.WriteLine("호환됨");
            else
                Console.WriteLine("호환 안 됨");
            
        }
    }
}
