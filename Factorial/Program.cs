using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 4;
            int x = 1;
            while (num != 0)
            {
                x *= num;
                num--;
            }
            Console.WriteLine(x);
            Console.ReadLine(); 
        }
    }
}
