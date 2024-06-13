using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Append_Characters_to_String_to_Make_Subsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string t = Console.ReadLine();
            Console.WriteLine(AppendCharacters(s,t));
            Console.ReadLine();
        }
        static public int AppendCharacters(string s, string t)
        {
            int tIndex = 0;
            int tLength = t.Length;
            foreach (char c in s)
            {
                if (c == t[tIndex] && ++tIndex == tLength)
                {
                    return 0;
                }
            }
            return tLength - tIndex;
        }
    }
}
