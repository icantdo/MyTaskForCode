using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_Score_Words_Formed_by_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s = { "dog", "cat", "dad", "good" };
            char[] c = { 'a', 'a', 'c', 'd', 'd', 'd', 'g', 'o', 'o' };
            int[] i = { 1, 0, 9, 5, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            Console.WriteLine(MaxScoreWords(s, c, i));
            Console.ReadLine();
        }
    public static int MaxScoreWords(string[] words, char[] letters, int[] score)
    {
            int[] letterCount = new int[26];
            foreach (char letter in letters)
            {
                letterCount[letter - 'a']++;
            }
        }
    }
}
