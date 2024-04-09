using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindThePivotInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PivotInteger(8));
            Console.WriteLine(PivotInteger(1));
            Console.WriteLine(PivotInteger(4));
            Console.ReadLine();
        }
        static public int PivotInteger(int n)
        {
            int x = -1;
            for (int i = 0; i <= n; i++)
            {
                if (i * (i+1) / 2 == (n - i + 1) * (i + n) / 2 ){
                    x = i;
                }
            }
            return x;
        }
    }
}
