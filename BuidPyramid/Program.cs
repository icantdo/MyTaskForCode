using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuidPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            //for (int i = 0; i < x*2 + 1; i++)
            //{
            //    if (x + 1 == i)
            //    {
            //        Console.Write('*');
            //        continue;
            //    }
            //    Console.Write(' ');
            //}
            //Console.WriteLine();
            //for (int i = 0;i < x*2 + 1;i++)
            //{
            //    if (x == i || x + 2 == i)
            //    {
            //        Console.Write('*');
            //        continue;
            //    }
            //    Console.Write(' ');
            //}
            BuildPyramid(x);
            Console.ReadLine();
        }
        static void BuildPyramid(int x)
        {
            int z = 0;
            int y = 0;
            for (int j = 0; j < x; j++)
            {
            for (int i = 0; i < x - y; i++)
            {
                Console.Write(' ');
            }
            z++;
            for (int i = 0; i < z*2 -1; i++)
            {
                Console.Write('*');
            }
            for (int i = 0; i < x - y; i++)
            {
                Console.Write(' ');
            }
            Console.WriteLine();
            y++;
            }
        }

    }
}
