﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            string[] command = Console.ReadLine().Trim().Split(' ');           

            while (command[0] != "END")
            {
                if (command[0] == "A")
                {
                    phonebook[command[1]] = command[2];
                    
                }
                else if (command[0] == "S")
                { 
                        if (phonebook.ContainsKey(command[1]))
                        {
                            Console.WriteLine("{0} -> {1}", command[1], phonebook[command[1]]);
                        }
                        else
                        {
                            Console.WriteLine("Contact {0} does not exist.", command[1]);
                        }                        
                }
                command = Console.ReadLine().Split(' ');
            }
        }
    }
}
