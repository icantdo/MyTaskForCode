using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "code";
            char[] arr = str.ToCharArray();
            string result = "";
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
                result += arr[i];
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
