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
        public Dictionary<Books, Trie> Children { get; set; } = new Dictionary<Books, Trie>();

        public void Add(Books book)
        {
            Trie currrent = this;
            if (!currrent.Children.TryGetValue(book, out var child))
            {
                child = new Trie();
                currrent.Children.Add(book, child);
            }
                currrent = child;
            currrent.IsEndOfWord = true;
        }
        public bool Contains(Books book)
        {
            Trie current = this;
            if (!current.Children.TryGetValue(book, out current))
            {
                return false;
            }
            return current.IsEndOfWord;
        }
    }
        public class Tanant
        {
            public string name;
            public Tanant(string name = "")
            {
                this.name = name;
            }
        }
        public class Books
        {
            public string nameBook;
            public Books(string nameBook = "")
            {
                this.nameBook = nameBook;
            }
        }

}
