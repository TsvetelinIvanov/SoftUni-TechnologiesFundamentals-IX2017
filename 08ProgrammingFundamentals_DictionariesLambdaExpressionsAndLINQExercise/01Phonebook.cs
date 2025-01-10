using System;
using System.Collections.Generic;

namespace _01Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {            
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            string[] line = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            while (line[0] != "END")
            {
                string command = line[0];
                string name = line[1];
                if (command == "A")
                {
                    string number = line[2];
                    if (phonebook.ContainsKey(name))
                    {
                        phonebook.Remove(name);
                    }

                    phonebook.Add(name, number);
                }
                else if (command == "S")
                {
                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine("{0} -> {1}", name, phonebook[name]);
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }

                line = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
