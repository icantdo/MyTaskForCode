using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.WriteLine("Hangi Trigonomrtrik değer istiyosun");
                string a = Console.ReadLine();
                Console.WriteLine("Lütfen sayı girin.");
                string number = Console.ReadLine();
                if (a == "Sin")
                {
                    if (int.TryParse(number, out int x))
                    {
                        double result = Math.Sin(x);
                        Console.WriteLine($"{number} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Lütfen düzgün sayı girin.");
                    }
                }
                if (a == "Tan")
                {
                    if (int.TryParse(number, out int x))
                    {
                        double result = Math.Tan(x);
                        Console.WriteLine($"{number} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Lütfen düzgün sayı girin.");
                    }
                }
                if (a == "Cot")
                {
                    if (int.TryParse(number, out int x))
                    {
                        double result = Math.Cosh(x);
                        Console.WriteLine($"{number} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Lütfen düzgün sayı girin.");
                    }
                }
                if (a == "Cos")
                {
                    if (int.TryParse(number, out int x))
                    {
                        double result = Math.Cos(x);
                        Console.WriteLine($"{number} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Lütfen düzgün sayı girin.");
                    }
                }
            }
        }
    }
}
