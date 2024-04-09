using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomSortString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CustomSortString("cbad" , "abcf"));
            Console.WriteLine(new string((char)('a' + 3), 1));
            for (int i = 0; i < 26; i++)
            {
                Console.WriteLine((char)('a' + i));
            }
            Console.ReadLine();
        }
        static public string CustomSortString(string order, string s)
        {
            int[] map = new int[26];
            foreach (char c in s)
            {
                map[c - 'a']++;
            }
            var resulte = new System.Text.StringBuilder();
            foreach (char c in order)
            {
                resulte.Append(new string(c, map[c - 'a']));
                map[c - 'a'] = 0;
            }
            for (int i = 0; i < 26; i++)
            {
                resulte.Append(new string((char)('a' + i), map[i]));
            }
            return resulte.ToString();
        }
    }
}
