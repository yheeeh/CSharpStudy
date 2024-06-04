using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
// StreamWriter/StreamReader & BinaryWriter/BinaryReader -> 기본 데이터형만 저장/읽기 가능
// FileStream, BinaryFormatter -> 구조체, 클래스 저장/읽기 가능
// 직렬화를 하기 위해서는 구조체나 클래스 위에 [Serializable]을 명시해줘야 함
namespace FileStream6
{
    [Serializable]
    struct DATA
    {
        public int var1;
        public float var2;
        public string str;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            DATA[] Data = new DATA[2];

            Data[0].var1 = 1;
            Data[0].var2 = 0.5f;
            Data[0].str = "Test1";
            Data[1].var1 = 2;
            Data[1].var2 = 1.5f;
            Data[1].str = "Test2";

            using(FileStream fs1 = new FileStream("test.dat", FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs1, Data);
            }

            DATA[] ResultData;

            using (FileStream fs2 = new FileStream("test.dat", FileMode.Open))
            {
                BinaryFormatter bf2 = new BinaryFormatter();
                ResultData = (DATA[])bf2.Deserialize(fs2);
            }

            for (int i = 0; i < ResultData.Length; i++)
            {
                Console.WriteLine("{0} {1} {2}", ResultData[i].var1, ResultData[i].var2, ResultData[i].str);
            }
        }
    }
}
