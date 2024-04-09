using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Trie
{
    internal class Program
    {
        const string badWordsFile = @"C:\Users\Mustafa Doğukan\source\repos\MyTaskForCode\Trie\BadWords.txt";
        static public List<string> badLessSentece = new List<string>();
        //static void Main(string[] args)
        //{
        //    Trie trie = new Trie();
        //    string badWordsList = @"C:\Users\Mustafa Doğukan\source\repos\MyTaskForCode\Trie\BadWords.txt";
        //    using (StreamReader sr = new StreamReader(badWordsList))
        //    {
        //        string satir;
        //        while ((satir = sr.ReadLine()) != null)
        //        {
        //            trie.Add(satir);
        //        }
        //    }
        //    string sentencs = Console.ReadLine();
        //    string[] words = sentencs.Split(' ');
        //    List<string> words2 = words.ToList();
        //    foreach (string word in words)
        //    {
        //        if (trie.Contains(word) == true)
        //        {
        //            words2.Remove(word);
        //        }
        //    }
        //    for (int i = 0; i < words2.Count; i++)
        //    {
        //        Console.Write(words2[i] + ' ');
        //    }
        //    Console.ReadLine();
        //}
        static void ShowBadWordsFromFile(string bWF)
        {
            using (StreamReader sr = new StreamReader(bWF))
            {
                string satir;
                while ((satir = sr.ReadLine()) != null)
                {
                    Console.WriteLine(satir);
                }
            }
        }
        static void Main(string[] args)
        {
            //ShowBadWords(badWordsFile);
            Run();
            Server();
            Client("127.0.0.1", "hello world");
            Console.ReadLine();
        }
        static void Server()
        {
            Socket serverSoket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            serverSoket.Bind(new IPEndPoint(IPAddress.Any, 1234));
            serverSoket.Listen(10);
            Socket clientSoket = serverSoket.Accept();
            byte[] data = new byte[256];
            int numberOfBytesReceived = clientSoket.Receive(data);
            string messange = Encoding.UTF8.GetString(data, 0, numberOfBytesReceived);
            Console.WriteLine("Alınan mesaj: " + messange);
            clientSoket.Close();
            serverSoket.Close();
        }
        static void Client(string messangePerson, string ip  = "127.0.0.1 ")
        {
            Socket clientSoket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            clientSoket.Connect(new IPEndPoint(IPAddress.Parse(ip), 1234));

            string messange = messangePerson;
            byte[] data = Encoding.UTF8.GetBytes(messange);
            clientSoket.Send(data);

            byte[] takeData = new byte[256];
            int numberOfBytesReceived = clientSoket.Receive(takeData);
            string comeMessenge = Encoding.UTF8.GetString(takeData, 0, numberOfBytesReceived);
            Console.WriteLine("Gelen mesaj: " + comeMessenge);

            clientSoket.Close();
        }
        static Trie AddBadWords(string bWF)
        {
            Trie trie = new Trie();
            using (StreamReader sr = new StreamReader(bWF))
            {
                string satir;
                while ((satir = sr.ReadLine()) != null)
                {
                    trie.Add(satir);
                }
            }
            return trie;
        }
        static string ContainsBadWords(Trie trie)
        {
            string sentcence = Console.ReadLine();
            string[] wordsFromSentcence = sentcence.Split(' ');
            badLessSentece = wordsFromSentcence.ToList();
            foreach (string word in badLessSentece)
            {
                if (trie.Contains(word))
                {
                    return word;
                }
            }
            return "";
        }
        static void RemoveBadWords(string word)
        {
            badLessSentece.Remove(word);
        }
        static void RewriteBadlessSentece(List<string> strings)
        {
            for (int i = 0; i < strings.Count; i++)
            {
                Console.Write(strings[i] + ' ');
            }
        }
        static void Run()
        {
            Trie trie = AddBadWords(badWordsFile);
            RemoveBadWords(ContainsBadWords(trie));
            RewriteBadlessSentece(badLessSentece);
        }
    }
}
