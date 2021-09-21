using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryHandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1, "Player 5");
            d.Add(2, "Player 1");
            d.Add(3, "Player 3");
            d.Add(4, "Player 2");
            d.Add(5, "Player 4");

            Console.WriteLine("Total number of players in race: {0}", d.Count());
            d[1] = "Player 4";
            d[5] = "Player 5";
            foreach (KeyValuePair<int,string> i in d)
            {
                Console.WriteLine("Player at position {0} is {1}", i.Key, i.Value);
            }
            d.Clear();
            Console.Read();
        }
    }
}
