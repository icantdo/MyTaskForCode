using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CoolHelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x = "helloword";
            int[] map = new int[26];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine((char)('a' + i));
            }
            Console.WriteLine();
            string word = "";
            Console.ReadLine();
            foreach (int xc in x)
            {
                int i = 0;
                while (xc != 'a' + i)
                {
                    i++;
                    Console.WriteLine(word + (char)('a' + i));
                    Thread.Sleep(80);
                }
                word += (char)('a' + i);
            }
            Console.ReadLine();
        }
    }
}
