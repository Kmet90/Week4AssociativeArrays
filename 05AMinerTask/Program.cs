using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> mine = new Dictionary<string, int>();
            string resource = Console.ReadLine();

            while (resource != "stop") 
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!mine.ContainsKey(resource))
                {
                    mine[resource] = 0;
                }
                mine[resource] += quantity;

                resource = Console.ReadLine();
            }
            foreach (var item in mine)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
