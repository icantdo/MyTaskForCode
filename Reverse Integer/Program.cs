using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse(1534236469));
            Console.ReadLine();
        }
        static int Reverse(int x)
        {
            long y = 0;
            int hold = 0;
            int result = 0;
            bool negative = false;
            if (x < 0)
            {
                negative = true;
                y = x * -1;
            }
            else
            {
                negative = false;
                y = x;
            }
            while (y > 0)
            {
                hold = ((int)y % 10);
                try
                {
                    result = checked(result * 10 + hold); 
                }
                catch (OverflowException)
                {
                    return 0;
                }
                y /= 10;
            }
            if (negative)
            {
                result *= -1;
            }
            return ((int)result);
        }
    }
}
