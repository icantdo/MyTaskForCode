using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestPalindrom("abccccdd"));
            Console.ReadLine();
        }
        static public int LongestPalindrom(string s)
        {
            int[] charCount = new int[128];
            foreach (char c in s)
            {
                charCount[c]++;
            }

            int length = 0;
            bool hasOddCount = false;
            foreach (int count in charCount)
            {
                if (count % 2 == 0)
                {
                    length += count;
                }
                else
                {
                    length += count - 1;
                    hasOddCount = true;
                }
            }

            if (hasOddCount)
            {
                length++;
            }
            return length;
        } 
    }
}
