using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trie
{
    internal class Trie
    {
        public bool IsEndOfWord { get; set; }
        public Dictionary<char, Trie> Children { get; set; } = new Dictionary<char, Trie>();

        public void Add(string word)
        {
            Trie currrent = this;

            foreach (var c in word)
            {
                if (!currrent.Children.TryGetValue(c, out var child))
                {
                    child = new Trie();
                    currrent.Children.Add(c, child);
                }
                currrent = child;
            }
            currrent.IsEndOfWord = true;
        }
        public bool Contains(string word)
        {
            Trie current = this;
            foreach (var c in word)
            {
                if (!current.Children.TryGetValue(c, out current))
                {
                    return false;
                }
            }
            return current.IsEndOfWord;
        }
    }
}
