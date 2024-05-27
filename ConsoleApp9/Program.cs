using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* nullable 형: null을 허용하지 않는 데이터형이 null 값을 허용 
-> 값을 비교하거나 데이터베이스에 값이 없을 때 에러 나지 않게 하기 위해 사용
형식: 데이터형? 변수명;
예) int? Var;
    bool? Var2 = null; -> true || false || null
속성
.HasValue -> 결과가 true, false로 나옴
.Value -> 읽기 전용
 */
namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? Num1 = null;

            if (Num1.HasValue)
                Console.WriteLine("올바른 값");
            else
                Console.WriteLine("null 값");

            Console.WriteLine("null : {0}", Num1);
        }
    }
}
