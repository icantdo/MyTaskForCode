using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidParentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            Console.WriteLine(IsValid2("()[]"));
            Console.ReadLine();
        }
        static public bool IsValid(string s)
        {
            if (s.Length%2 != 0) return false;
            var leftControl = new[] { '(' , '{' , '['};
            var rightControl = new[] { ')' , '}' , ']'};
            Stack<char> stack = new Stack<char>();
            for (var i = 0; i < s.Length; i++)
            {
                if (leftControl.Contains(s[i]))
                {
                    stack.Push(s[i]);
                    continue;
                }
                if (rightControl.Contains(s[i]))
                {
                    if (!stack.Any())
                    {
                        return false;
                    }

                    var x = stack.Peek() - s[i];

                    if (x < 0 && x >= -2)
                    {
                        stack.Pop();
                        continue;
                    }
                    return false;
                }
            }
            return stack.Count == 0;
        }
        static public bool IsValid2(string s)
        {
            if (s.Length % 2 != 0) return false;
            char[] leftControl = new char[3] { '(', '{', '[' };
            char[] rightControl = new char[3] { ')', '}', ']' };
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (leftControl.Contains(s[i]))
                {
                    stack.Push(s[i]);
                    continue;
                }
                if (rightControl.Contains(s[i]))
                {
                    if (!stack.Any())
                    {
                        return false;
                    }

                    int x = stack.Peek() - s[i];

                    if (x < 0 && x >= -2)
                    {
                        stack.Pop();
                        continue;
                    }
                    return false;
                }
            }
            return stack.Count == 0;
        }
    }
}
