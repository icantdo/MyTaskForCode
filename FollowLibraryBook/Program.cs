using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FollowLibraryBook
{
    internal class Program
    {
        static public Dictionary<Books, Tanant> followingBook = new Dictionary<Books, Tanant>();
        static public List<Books> libraryBooks = new List<Books>();
        static public List<Tanant> libraryTanant = new List<Tanant>();
        static void Main(string[] args)
        {
            Console.ReadLine();
            string s = Console.ReadLine();
            while (s != "stop")
            {
                ChooseAction(s);
            }
        }
        static void ChooseAction(string strs)
        {
            strs = strs.ToLower();
            if (strs == "add")
            {
                Console.WriteLine("What do you want to add?");
                string res = Console.ReadLine();
                if (res == "book")
                {
                    Console.WriteLine("What is book's name?");
                    Add(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("What is person's id?");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("What is person's name?");
                    Add(id, Console.ReadLine());
                }
            }
            else if (strs == " search")
            {
                Console.WriteLine("what is the name of the book");
                string s = Console.ReadLine();
                if (Search("book", s))
                {
                    Console.WriteLine("This book is in the library");
                }
                else
                {
                    Console.WriteLine("This book is not in the library");
                }
            }
            else if (strs == "rent")
            {
                Console.WriteLine("What is the name of the rented book?");
                string sb = Console.ReadLine();
                Console.WriteLine("What is the name of the person renting the book?");
                string st = Console.ReadLine();
                Rent(sb,libraryTanant.Find(v => v.name == st).id);
            }
            else if(strs == "submit")
            {
                Console.WriteLine("What is the name of the delivered book?");
                Submit(Console.ReadLine().ToLower());
            }
            else
            {
                Console.WriteLine("Please enter a valid action");
            }
        }
        static void Add(string bookName) 
        {
            if (Search("book" ,bookName))
            {
                Console.WriteLine("This book was added before");
            }
            else
            {
                if (libraryBooks[0] != null)
                {
                    int x = libraryBooks[0].idShelf + 1;
                    Books book = new Books(bookName, x);
                    libraryBooks.Add(book);
                }
                else
                {
                    int x = 0;
                    Books book = new Books(bookName, x);
                    libraryBooks.Add(book);
                }
            }
            
        }
        static void Add(int id, string name)
        {
            if (Search("person", id))
            {
                Console.WriteLine("This person was added before");
            }
            else
            {
                Tanant tanant = new Tanant(name, id);
                libraryTanant.Add(tanant);
            }
        }
        static bool Search(string whice, int id)
        {
            whice = whice.ToLower();
            if (whice != "book")
            {
                return libraryBooks.All(v => v.idShelf == id);
            }
            else
            {
                return libraryTanant.All(v => v.id == id);
            }
        }
        static bool Search(string whice, string name)
        {
            whice = whice.ToLower();
            if (whice == "book")
            {
                return libraryBooks.All(v => v.nameShelf == name);
            }
            else
            {
                return libraryTanant.All(v => v.name == name);
            }
        }
        static void Rent(string bookName, int id)
        {
            if (!Search("book", bookName))
            {
                Console.WriteLine("This book does not exist.");
            }
            else if (!Search("person", id))
            {
                Console.WriteLine("This person does not exist.");
            }
            else
            {
                Books books = libraryBooks.Find(v => v.nameShelf == bookName);
                Tanant bookRent = libraryTanant.Find(v => v.id == id);
                followingBook.Add(books, bookRent);
                libraryBooks.Remove(books);
            }
        }
        static void Submit(string bookName)
        {
            if (Search("book", bookName))
            {
                Console.WriteLine("This book is in the library.");
            }
            else
            {
                foreach (var item in followingBook)
                {
                    if (item.Key.nameShelf == bookName)
                    {
                        Books books = new Books(item.Key.nameShelf, item.Key.idShelf);
                        libraryBooks.Add(books);
                        followingBook.Remove(item.Key);
                    }
                }
            }
        }
        public class Tanant
        {
            public int id;
            public string name;
            public Tanant(string name = "", int id = 0)
            {
                id += 1;
                this.id = id;
                this.name = name;
            }
        }
        public class Books
        {
            public int idShelf;
            public string nameShelf;
            public Books(string nameShelf = "", int idShelf = 0)
            {
                this.idShelf = idShelf;
                this.nameShelf = nameShelf;
            }
        }
    }
}
