using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimum_Number_of_Moves_to_Seat_Everyone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 4, 1, 5, 9 };
            int[] y = { 1, 3, 2, 6 };
            Console.WriteLine(MinMovesToSeat(x, y));
            Console.ReadLine();
        }
        static int MinMovesToSeat(int[] seats, int[] students)
        {
            int result = 0;
            Array.Sort(seats);
            Array.Sort(students);
            for (int i = 0; i < seats.Length; i++)
            {
                result += Math.Abs(seats[i] - students[i]);
            }
            return result;
        }
    }
}
