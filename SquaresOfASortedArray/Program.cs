using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquaresOfASortedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3 };
            int[] ints2 = { -1, -2 , 3 };
            Console.WriteLine(SquaresOfASortedArray(ints2)[2]);
            Console.WriteLine(SquaresOfASortedArray(ints)[1]);
            Console.ReadLine();
        }
        static public int[] SquaresOfASortedArray(int[] x)
        {
            List<int> list = new List<int>();
            int y = 0;
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = x[i] * x[i];
            }
            Array.Sort(x);
            return x;
        }
        public int[] SortedSquares(int[] nums)
        {

            int[] result = new int[nums.Length];

            int left = 0;
            int right = nums.Length - 1;

            for (int i = nums.Length - 1; i >= 0; i--)
            {

                int square;

                if (Math.Abs(nums[left]) < Math.Abs(nums[right]))
                {
                    square = nums[right];
                    right--;
                }
                else
                {
                    square = nums[left];
                    left++;
                }
                result[i] = square * square;
            }

            return result;
        }
    }
    public class Solution
    {
       
    }
}
