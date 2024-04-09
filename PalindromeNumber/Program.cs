using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome(1000021));
            Console.WriteLine(IsPalindrome2(1000021));
            Console.ReadLine();
        }
        static public bool IsPalindrome(int x)
        {
            if (x < 0) return false;
            char[] chars = x.ToString().ToCharArray();
            List<char> list = chars.ToList();
            int lenght = list.Count;
            for (int i = 0; i < lenght/2; i++)
            {
                if (list[i] != list[lenght  - 1 - i]) return false;
            }
            return true;
        }
        static public bool IsPalindrome2(int x) 
        {  
            string str = x.ToString();
            if (str.Count() <= 1) return true;
            int i = 0;
            int j = str.Length - 1;
            while (i <= j)
            {
                if(str[i] != str[j]) return false;
                i++;
                j--;
            }
            return true; 
        }
    }
}
