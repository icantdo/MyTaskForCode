using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProductOfArrayExceptSelf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 1, 2, 3, 4};
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(ProductExceptSelf3(x)[i]);
            }
            Console.ReadLine();
        }
        static public int[] ProductExceptSelf(int[] nums)
        {
            int[] x = new int[nums.Length];
            for (int i = 0;i < nums.Length;i++)
            {
                int prod = 1;
                for (int j = 0; j  < nums.Length;j++)
                {
                    if (i == j) continue;
                    prod *= nums[j];
                }
                x[i] = prod;
            }
            return x;
        }
        static public int[] ProductExceptSelf2(int[] nums)
        {
            int n = nums.Length;
            int[] right = new int[n];
            int[] res = new int[n];
            int prod = 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                prod *= nums[i];
                right[i] = prod;
            }
            prod = 1;
            for (int i = 0; i < n - 1; i++)
            {
                int lp = prod;
                int rp = right[i+1];
                res[i] = lp * rp;
                prod *= nums[i];
            }
            res[n - 1] = prod;
            return res;
        }
        static public int[] ProductExceptSelf3(int[] nums)
        {
            int n = nums.Length;
            int[] right = new int[n];
            int[] left = new int[n];
            int[] res = new int[n];

            right[0] = 1;
            left[n-1] = 1;

            for (int i = 1; i < n; i++)
            {
                right[i] = right[i - 1] * nums[i - 1];
                Console.WriteLine(right[i]);
            }
            for (int i = n - 2; i >= 0; i--)
            {
                left[i] = left[i + 1] * nums[i + 1];
            }
            for (int i = 0; i < n; i++)
            {
                res[i] = right[i] * left[i];
            }
            return res;
        }
    }
}