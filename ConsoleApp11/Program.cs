using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 박싱(boxing)
                : 데이터 형을 최상위 object 형으로 변환하여 별도의 힙 메모리에 저장
                 int m = 123;
                 object obj = m;

                언박싱(unboxing)
                : 힙에 저장된 형식을 다시 원래의 형식으로 변환 -> 이때는 항상 캐스팅을 해야 함
                 int n = (int)obj;

                잘 쓰이지는 않음
             */

            int i = 123;
            object obj = i;
            Console.WriteLine("{0}", (int)obj);

            int j = 123;
            object o = j;
            j = 456;
            Console.WriteLine("{0} {1}", j, (int)o);
        }
    }
}
