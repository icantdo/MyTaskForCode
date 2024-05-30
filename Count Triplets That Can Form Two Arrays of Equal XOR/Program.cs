using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Triplets_That_Can_Form_Two_Arrays_of_Equal_XOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 2, 3, 1, 6, 7 };
            Console.WriteLine(CountTriplets(x));
            Console.ReadLine();
        }
        static public int CountTriplets(int[] arr)
        {
            int n = arr.Length;
            int[] prefix = new int[n + 1];

            for (int i = 0; i < n; i++)
            {
                prefix[i + 1] = prefix[i] ^ arr[i];
            }

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (prefix[i] == prefix[j + 1])
                        count += j - i;
                }
            }

            return count;
        }
    }
}
