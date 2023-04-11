using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_PolessUP
{
    internal class Program
    {
        static void swap(ref int a, ref int b)
        {
            int buffer=a;
            a = b;
            b=buffer;
        }

        static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 3, 1 };
            for (int i = 1; i < nums.Length; i++)
                for (int j = 0; j < nums.Length - i; j++)
                {
                    if (nums[j] < nums[j+1])
                        swap(ref nums[j], ref nums[j+1]);
                }
            if (nums.Length >= 3)
                Console.WriteLine(nums[2]);
            else
                Console.WriteLine(nums[0]);
 
        }
    }
}
