using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestCommonPrefix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] x = { "flower", "flow", "flightw" };
            Console.WriteLine(x[0].Length);
            Console.WriteLine(LongestCommonPrefix(x));
            Console.ReadLine();
        }
        static public string LongestCommonPrefix(string[] strs)
        {
            string s = "";
            for (int i = 0; i < strs[0].Length; i++)
            {
                for (int j = 1; j < strs.Length; j++)
                {
                    if (i >= strs[j].Length || strs[j][i] != strs[0][i])
                    {
                        return s;
                    }
                }
                s += strs[0][i];
            }
            return s;
        }
    }
}
