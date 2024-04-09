using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] result = TwoSums(ints, 7);
            if (result != null)
            {
                Console.WriteLine("Indices: {0}, {1}", result[0], result[1]);
            }
            else
            {
                Console.WriteLine("Not Found Result");
            }
            Console.ReadLine();
        }
        public static int[] TwoSums(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target && i != j)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return null;
        }
    }
}
