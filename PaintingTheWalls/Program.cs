using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintingTheWalls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = {1, 2, 3, 2}; int[] y = { 1, 2, 3, 2 };
            Console.WriteLine(PaintWalls(x,y));
            Console.ReadLine();
        }
        static public int PaintWalls(int[] cost, int[] time)
        {
            const int kMax = 500_000_000;
            int n = cost.Length;
            int[] dp = new int[n+1];
            for (int i = 0; i < dp.Length; i++)
            {
                dp[i] = kMax;
            }
            dp[0] = 0;
            for (int i = 1; i < n; i++)
            {
                for (int walls = n; walls > 0; --walls)
                {
                    dp[walls] = Math.Min(dp[walls], dp[Math.Max(walls - time[i] - 1, 0)] + cost[i]);    
                }
            }
            return dp[n];
        }
    }
}
