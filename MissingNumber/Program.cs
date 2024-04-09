using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
            Console.WriteLine(MissingNumber(x));
            Console.ReadLine();
        }
        public static int MissingNumber(int[] nums) 
        { 
            int x = nums.Length;
            int expectedSum = x * (x + 1) / 2;

            int actualSum = 0;
            foreach (int i in nums)
            {
                actualSum += i;
            }
            return expectedSum - actualSum;
        }
    }
}
