using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicatesFromSortedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 1, 2, 2 };
            foreach (int i in x.Distinct())
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(RemoveDuplicates(x));
            Console.ReadLine();
        }
        static int RemoveDuplicates(int[] nums)
        {
            int x = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[x] = nums[i];
                    x++;
                }

            }
            return x;
        }
    }
}
