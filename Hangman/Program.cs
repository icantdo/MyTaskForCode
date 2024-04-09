using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string[] words = { "apple" , "banana", "orange"};
            string selectWord = words[rnd.Next(0 , words.Length - 1)];
            List<char> guessedLetter = new List<char>();
            int attempts = 6; 
            while (attempts > 0)
            {
                string hiddenWord = "";
                foreach (char word in selectWord)
                {
                    if (guessedLetter.Contains(word))
                    {
                        hiddenWord += word;
                    }else
                    {
                        hiddenWord += "_";
                    }
                }
                Console.WriteLine("Word:"+ hiddenWord);
                Console.WriteLine("Attempts left:" + attempts);
                char guess = Console.ReadLine().ToLower().ToCharArray()[0];
                if (guessedLetter.Contains(guess))
                {
                    Console.WriteLine("You already guessed that letter.");
                }
                else if (selectWord.Contains(guess))
                {
                    guessedLetter.Add(guess);
                    Console.WriteLine("Correct guess!");
                }
                else
                {
                    Console.WriteLine("Incorrect guess.");
                    attempts--;
                }

                if (hiddenWord == selectWord)
                {
                    Console.WriteLine("Congratulations! You guessed the word:" + selectWord);
                    break;
                }
                
            }
            Console.ReadLine();
        }
    }
}
