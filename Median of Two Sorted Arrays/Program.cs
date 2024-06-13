using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Median_of_Two_Sorted_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 1, 2, }; int[] y = { 3, 4 };
            Console.WriteLine(FindMedianSortedArrays(x,y));
            Console.ReadLine();
        }
        static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            List<int> list = new List<int>();
            double result = 0;
            foreach (int item in nums1)
                list.Add(item);
            foreach (int item in nums2)
                list.Add(item);
            list.Sort();
            if (list.Count % 2 == 0)
            {
                int x = list.Count / 2;
                result = ((double)(list[x - 1] + list[x]) / 2);
            }
            else
            {
                int x = list.Count / 2;
                result = list[x];
            }
            return result;
        }
    }
}
