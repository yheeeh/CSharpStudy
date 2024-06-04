using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 화면으로부터 학생 수와 세 과목에 대한 점수를 입력받은 후에 test.txt 파일로 저장하는 프로그램 작성
// 단, 각 과목의 점수는 스페이스로 구분하여 입력
namespace FileStream3
{
    struct GRADE
    {
        public int kor, eng, math, total;
        public float average;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.Write("성적 처리를 위한 학생 수를 입력해 주세요: ");
            int nCount = int.Parse(Console.ReadLine());
            Console.WriteLine("국어 영어 수학 순서로 입력해 주세요");
            GRADE[] Grade = new GRADE[nCount];
            StreamWriter sw = new StreamWriter("test.txt");
            sw.WriteLine("학생 수: {0}", nCount);
            for (int i = 0; i < nCount; i++)
            {
                str = Console.ReadLine();
                string[] DataString = str.Split(new char[] { ' ' });
                Grade[i].kor = Convert.ToInt32(DataString[0]);
                Grade[i].eng = Convert.ToInt32(DataString[1]);
                Grade[i].math = Convert.ToInt32(DataString[2]);
                Grade[i].total = Grade[i].kor + Grade[i].eng + Grade[i].math;
                Grade[i].average = (int)Math.Round(Grade[i].total / 3.0f);
            }
            for(int i = 0;i < nCount;i++)
            {
                sw.WriteLine("국어: {0}, 영어: {1}, 수학: {2}, 총점: {3}, 평균: {4}", 
                    Grade[i].kor, Grade[i].eng, Grade[i].math, Grade[i].total, Grade[i].average);
            }
            sw.Close();

            Console.WriteLine();

            // 파일 읽기
            string str2;
            Console.Write("파일명을 입력해 주세요! ");
            string filename = Console.ReadLine();
            StreamReader sr = new StreamReader(filename);
            str2 = sr.ReadLine();
            string[] strData1 = str2.Split(new char[] {':'});
            int sCount = int.Parse(strData1[1]);
            Console.WriteLine("--------------------------------------------------------");
            for (int i = 0; i < sCount; i++)
            {
                str2 = sr.ReadLine();
                string[] strData2 = str2.Split(new char[] { ',' });
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}",
                    strData2[0], strData2[1], strData2[2], strData2[3], strData2[4]);
            }
            Console.WriteLine("--------------------------------------------------------");
            sr.Close();
        }
    }
}
