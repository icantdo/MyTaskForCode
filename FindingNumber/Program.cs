using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myReply= Console.ReadLine();
            Random random = new Random();
            Console.WriteLine(MyRandomAnswer());
            string trueAnswer = random.Next().ToString();
            Console.WriteLine(FindNumber(myReply, trueAnswer)[0] + " " + FindNumber(myReply, trueAnswer)[1]);
            Console.ReadLine();
            //for (int i = 3; i > -1; i--)
            //{
            //    string myReply = Console.ReadLine();
            //    FindNumber(myReply, "2356");
            //    if (myReply == "2356")
            //    {
            //        Console.WriteLine("tebrikler başardınız");
            //        Console.ReadLine();
            //    }
            //    else
            //    {
            //        if (i == 0)
            //        {
            //            Console.WriteLine("başarısız oldunuz cevap 2356");
            //            Console.ReadLine();
            //        }
            //        else
            //        {
            //            Console.WriteLine("bir hakkınızı kaybettiniz kalan hakkınız: " + i);
            //        }
            //    }
            //}
        }
        public static int[] FindNumber(string reply , string answer)
        {
            int x = 0;
            int y = 0;
            char[] charArrayAnswer = answer.ToCharArray();
            char[] charArrayReply = reply.ToCharArray();
            for (int i = 0; i < charArrayAnswer.Length; i++)
            {
                for (int j = 0; j < charArrayReply.Length; j++)
                {
                    if (charArrayAnswer[i] == charArrayReply[j])
                    {
                        if (i == j)
                        {
                            x++;
                        }
                        else
                        {
                            y--;
                        }
                    }
                }
            }
            return new int[] {x,y};
        }
        public static int MyRandomAnswer()
        {
            Random random = new Random();
            int x = random.Next(1000,9999);
            char[] chars = x.ToString().ToCharArray();
            for(int i = 0; i < chars.Length; i++)
            {
                for(int j = 0; j < chars.Length;j++)
                {
                    if (i != j)
                    {
                        return x;
                    }
                    else
                    {
                        x = random.Next(1000,9999);
                        i = 0;
                        j = 0;
                    }
                }
            }

            return 0;
        }
    }
}
