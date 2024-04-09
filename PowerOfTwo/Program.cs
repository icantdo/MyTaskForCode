using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerOfTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }
        public static bool ISPowerOfTwo1(int x)
        {
            if (x == 0)
            {
                return false;
            }else if (x == 1)
            {
                return true;
            }else if (x % 2 == 0)
            {
                return ISPowerOfTwo1(x / 2);
            }
            else
            {
                return false;
            }
        }
        public  static bool ISPowerOfTwo2(int x)
        {
            return (Math.Log10(x) / Math.Log10(2)) % 1 == 0;
        }
        public static bool ISPowerOfTwo3(int x)
        {
            double y = x;
            while (y > 1)
            {
                y = y / 3;
            }
            if (y == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    }