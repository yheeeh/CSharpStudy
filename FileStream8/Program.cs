using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
// 컬렉션과 제네릭의 직렬화
namespace FileStream8
{
    [Serializable]
    struct Data
    {
        public int data;
        public string str;
        public Data(int data1, string str1)
        {
            data = data1;
            str = str1;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Data> ResultList;
            List<Data> DataList = new List<Data>();
            DataList.Add(new Data(1, "test1"));
            DataList.Add(new Data(2, "test2"));
            DataList.Add(new Data(3, "test3"));
            DataList.Add(new Data(4, "test4"));
            DataList.Add(new Data(5, "test5"));

            using (FileStream fs1 = new FileStream("test.dat", FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs1, DataList);
            }

            using (FileStream fs2 = new FileStream("test.dat", FileMode.Open))
            {
                BinaryFormatter bf2 = new BinaryFormatter();
                ResultList = (List<Data>)bf2.Deserialize(fs2);
            }

            for (int i = 0; i < ResultList.Count; i++)
            {
                Console.WriteLine("{0} {1}", ResultList[i].data, ResultList[i].str);
            }
        }
    }
}
