using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 값 형식
 * System.Object + System.ValueType에서 파생
 * 변수가 직접 값을 저장
 * 기본 데이터형, 구조체, 열거형
 * 선언 vs 생성(new) -> 생성을 하면 기본값으로 초기화
 */
namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 일반적인 선언과 new를 통해 생성한 객체에 대한 초기화 비교
            int nVal1 = 100;
            int nVal2 = new int();
            Console.WriteLine("{0} {1}", nVal1, nVal2);
        }
    }
}
