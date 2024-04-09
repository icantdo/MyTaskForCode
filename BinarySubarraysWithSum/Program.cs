using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySubarraysWithSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 0, 0, 0, 0, 0 };
            Console.WriteLine(NumSubarraysWithSum(x, 0));
            Console.ReadLine();
        }
        static public int NumSubarraysWithSum(int[] nums, int goal)
        {
            int x = 0;
            foreach (int i in nums)
            {
                if (i == goal)
                {
                    x++;
                }
            }
            return x;
        }
    }
}
