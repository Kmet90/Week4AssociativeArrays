using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().ToLower().Split(' ');
            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (counts.ContainsKey(word))
                {
                    counts[word]++;
                }
                else
                {
                    counts[word] = 1;
                }
            }
                var results = new List<string>();

            foreach (var pair in counts.Keys)
            {
                if (counts[pair] %2==1)
                {
                    results.Add(pair);
                }
            }
            Console.WriteLine(string.Join(", ", results));
        }
    }
}
