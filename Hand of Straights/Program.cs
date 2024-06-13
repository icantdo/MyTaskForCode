using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hand_of_Straights
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        static bool IsNStraightHand(int[] hand, int groupSize)
        {
            if (hand.Length % groupSize != 0) return false;

            Array.Sort(hand);
            Dictionary<int,int> result = new Dictionary<int,int>();
            foreach (int i in hand)
            {
                if (result.ContainsKey(i))
                {
                    result[i]++;
                }
                else
                {
                    result[i] = 1;
                }
            }
            foreach (int i in hand)
            {
                if (result[i] == 0) continue;
                for (int i2 = 0; i2 < groupSize; i2++)
                {
                    int x = result[i] + i;
                    if (!result.ContainsKey(x))
                    {
                        return false;
                    }
                    result[i]--;
                }
            }
            return true;
        }
    }
}
