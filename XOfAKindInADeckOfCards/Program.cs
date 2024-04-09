using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace XOfAKindInADeckOfCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 1, 2, 3, 4, 4, 3, 2, 1 };
            Console.WriteLine(HasGroupsSizeX(x));
            Console.ReadLine();
        }
        static public bool HasGroupsSizeX(int[] deck)
        {
            Dictionary<int,int> map = new Dictionary<int,int>();
            for (int i = 0; i < deck.Length; i++)
            {
                if (map.ContainsKey(deck[i]))
                { map[deck[i]]++; }else { map.Add(deck[i] , 1); }
            }
            for (int i = 2;i < 20; i++)
            {
                if (map.Values.All(v => v%i == 0))return true;
            }
            return false;
        }
    }
    public class Solution
    {
        public bool HasGroupsSizeX(int[] deck)
        {
            var counts = deck.GroupBy(x => x).Select(g => g.Count());

            if (counts.Min() < 2) return false;

            int GreatestCommonDivisor(int x, int y)
            {
                return y == 0 ? x : GreatestCommonDivisor(y, x % y);
            }

            return counts.Aggregate(GreatestCommonDivisor) > 1;
        }
    }
}
