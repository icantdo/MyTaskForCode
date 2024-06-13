using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Substring_Without_Repeating_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LengthOfLongestSubstring("pwwkew"));
            Console.ReadLine();
        }
        static int LengthOfLongestSubstring(string s)
        {
            int i = -1; List<char> cur = new List<char>(); int best = 0;
            for (int j = 0; j < s.Length; j++)
            {
                while (cur.Contains(s[j]))
                {
                    i++;
                    cur.Remove(s[i]);
                }
                cur.Add(s[j]);
                best = Math.Max(best, cur.Count);
            }
            return best;
        }
    }
}
