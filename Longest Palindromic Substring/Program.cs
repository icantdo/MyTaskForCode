using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Palindromic_Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestPalindrome("abbc"));
            Console.ReadLine();
        }
        static string LongestPalindrome(string s)
        {
            string best = "";
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = s.Length - 1 ; j > i; j--)
                {
                    if (IsPalindrom(i,j,s))
                    {
                        best = (best.Length < j - i + 1) ? s.Substring(i,j) : best;
                    }
                }
            }
            return best;
        }
        static bool IsPalindrom(int x, int y, string s)
        {
            while (x <= y)
            {
                if (s[x] != s[y])
                {
                    return false;
                }
                x++;
                y--;
            }
            return true;
        } 
    }
}
