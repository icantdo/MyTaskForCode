using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAnagrams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = { "eat", "tea", "tan", "ate", "nat", "bat" };
            Console.WriteLine();
            Console.ReadLine();
        }
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            if (strs == null || strs.Length == null)
            {
                return new List<IList<string>>();
            }
            Dictionary<string, IList<string>> map = new Dictionary<string, IList<string>>();
            foreach (string str in strs)
            {
                char[] chars = str.ToCharArray();
                Array.Sort(chars);
                string array = new string(chars);
                if (!map.ContainsKey(array))
                {
                    map[array] = new List<string>();
                }
                map[array].Add(str);
            }
            return new List<IList<string>>(map.Values);
        }
    }
}
