using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zigzag_Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        static string Convert(string s, int numRows)
        {
            if (numRows == 1)
            {
                return s;
            }
            char[] s2 = s.ToCharArray();
            string[] hold = new string[numRows];
            string result = "";
            int row = 0;
            bool down = true;
            for (int i = 0; i < s.Length; i++)
            {
                hold[row] += s2[i];
                if (row == numRows - 1)
                    down = false;
                else if(row == 0)
                    down = true;

                if (down)
                    row++;
                else
                    row--;
            }
            foreach (string c in hold)
            {
                result += c;
            }
            return result;
        }
    }
}
