using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Common_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = { "bella", "label", "roller" };
            Console.WriteLine(CommonChars(strings));
            Console.ReadLine();
        }
        static IList<string> CommonChars(string[] words)
        {
            IList<string> result = new List<string>();
            if (words == null || words.Length == 0)
            {
                return result;
            }
            int[] minFreq = new int[26];
            for (int i = 0; i < minFreq.Length; i++)
            {
                minFreq[i] = int.MaxValue;
            }
            foreach (string word in words)
            {
                int[] charCount = new int[26];
                foreach (char item in word)
                {
                    charCount[item - 'a']++;
                }
                for (int i = 0; i < 26; i++)
                {
                    minFreq[i] = Math.Min(minFreq[i], charCount[i]);
                }
            }
            for (int i = 0; i < 26; i++)
            {
                for (int j = 0; j < minFreq[i]; j++)
                {
                    result.Add(((char)(i + 'a')).ToString());
                }
            }
            return result;
        }
    }
}
