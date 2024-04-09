using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RomanToInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RomanToInt("MDLXII"));
            Console.ReadLine();
        }

        static public int RomanToInt(string s)
        {
            Dictionary<char, int> map = new Dictionary<char, int>()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };
            int result = 0;
            for (int i = 0; i < s.Length; ++i)
            {
                if (i == s.Length - 1)
                {
                    result += map[s[i]];
                    break;
                }
                if (map[s[i]] >= map[s[i + 1]])
                    result += map[s[i]];
                else
                {
                    result += map[s[i + 1]] - map[s[i]];
                    i++;
                }
            }
            return result;
        }
    }
}
