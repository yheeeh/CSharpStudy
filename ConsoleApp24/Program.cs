using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class Program
    { 

        static int GetNumber(int index)
        {
        int[] nums = { 300, 600, 900 };
        if (index >= nums.Length)
        {
            throw new IndexOutOfRangeException();
        }
        return nums[index];
        }

        static void Main(string[] args)
        {
            int result = GetNumber(3);
        }
    }
}
