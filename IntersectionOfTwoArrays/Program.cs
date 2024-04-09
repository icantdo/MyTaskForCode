using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntersectionOfTwoArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 1, 2, 2, 1 }; int[] y = { 2, 2 };
            Console.WriteLine("" +Intersection2(x, y)[0] + Intersection2(x, y)[1]);
            Console.ReadLine();
        }
        public static int[] Intersection(int[] nums1, int[] nums2) 
        {
            HashSet<int> set1 = new HashSet<int>(nums1);
            HashSet<int> set2 = new HashSet<int>(nums2);

            set1.IntersectWith(set2);

            return set1.ToArray();
        }
        public static int[] Intersection2(int[] nums1, int[] nums2)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                for (int j = 0; j < nums2.Length; j++)
                {
                    if (nums1[i] == nums2[j]) list.Add(nums1[i]);
                }
            }
            return list.Distinct().ToArray();
        }
        public int[] Intersection3(int[] nums1, int[] nums2)
        {
            int[] arr = new int[1000];
            List<int> fin = new List<int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                arr[nums1[i]]++;
            }
            for (int i = 0; i < nums2.Length; i++)
            {
                if (arr[nums2[i]] > 0 && !fin.Contains(nums2[i]))
                {
                    fin.Add(nums2[i]);
                }
            }
            return fin.ToArray();
        }
    }
}
