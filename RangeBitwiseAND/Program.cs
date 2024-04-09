using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeBitwiseAND
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RangeBitwiseAND(5, 7));
            Console.ReadLine();
        }
        public static int RangeBitwiseAND(int left, int right)
        {
            int shift = 0;
            while (left < right)
            {
                left >>= 1;
                right >>= 1;
                shift++;
            }
            int opti = left << shift;
            return opti;

        }
    }
}
