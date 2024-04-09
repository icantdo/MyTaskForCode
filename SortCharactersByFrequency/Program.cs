using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortCharactersByFrequency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char,int> map = new Dictionary<char,int>();
            map['a'] = 1;
            map['b'] = 2;
            map['c'] = 3;
            if (map.Count == 1)
            {
                Console.WriteLine(map.Count);
            }
            Console.ReadLine();
        }
        public static string FrequencySort (string frequency)
        {
            //Dictionary<char,int> charCount = new Dictionary<char,int>();
            //char[] chars = frequency.ToCharArray();
            //foreach (char c in chars)
            //{
            //    if (charCount.ContainsKey(c))
            //    {
            //        charCount[c]++;
            //    }
            //    else
            //    {
            //        charCount[c] = 1;
            //    }
            //}
            //if (charCount.Count == 1)
            //{
            //    Array.Sort(chars);
            //}
            //else
            //{

            //}
            return "";
        }
    }
}
