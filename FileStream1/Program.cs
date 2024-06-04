using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 스트림(stream)
- 파일, 네트워크 등에서 데이터를 바이트 단위로 읽고 쓰는 클래스
- Stream 클래스를 상속받는 클래스들
  : FileStream, MemoryStream, NetworkStream, SqlFileStream 등
- using System.IO 를 선언해줘야 사용 가능

FileStream: 파일 입출력을 다루는 기본 클래스
- byte[] 배열로 데이터를 읽거나 저장함 -> 형변환이 요구됨
- StreamWriter/StreamReader + BinaryWriter/BinaryReader와 함께 사용
- 파일 정보 설정에 사용
- 필드: 경로, 파일 모드, 권한

텍스트 파일처리
- StreamWriter(파일 쓰기), StreamReader(파일 읽기)
- 텍스트 파일의 특징: 기본 단위는 1바이트, 아스키코드 기반
- 아스키코드를 유니코드로 인코딩
 */
namespace FileStream1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = 12;
            float value2 = 3.14f;
            string str = "Hello World!";
            //FileStream fs = new FileStream("test.txt", FileMode.Create);
            //StreamWriter sw = new StreamWriter(fs);
            //sw.WriteLine(value);
            //sw.WriteLine(value2);
            //sw.WriteLine(str);
            //sw.Close();

            // using 구문을 쓰면 Close가 자동으로 됨
            //using (StreamWriter sw = new StreamWriter(new FileStream("test2.txt", FileMode.Create)))
            //{
            //    sw.WriteLine(value);
            //    sw.WriteLine(value2);
            //    sw.WriteLine(str);
            //}

            // 간단하게 쓰기만 할 때
            StreamWriter sw = new StreamWriter("test3.txt");
            sw.WriteLine(value);
            sw.WriteLine(value2);
            sw.WriteLine(str);
            sw.Close();
        }
    }
}
