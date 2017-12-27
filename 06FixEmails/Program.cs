using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            var addressBook = new Dictionary<string, string>();
            var name = Console.ReadLine();

            while (name != "stop")
            {
                var eMailAddress = Console.ReadLine();
                bool isEMailValid = !eMailAddress.EndsWith(".us") && !eMailAddress.EndsWith(".uk");

                if (isEMailValid)
                {
                    if (!addressBook.ContainsKey(name))
                    {
                        addressBook[name] = string.Empty;
                    }
                    addressBook[name] = eMailAddress;
                }
                name = Console.ReadLine();
            }

            foreach (var item in addressBook)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }            
            
        }
    }
}
