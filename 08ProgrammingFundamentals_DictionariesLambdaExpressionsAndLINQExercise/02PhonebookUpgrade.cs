using System;
using System.Collections.Generic;

namespace _02PhonebookUpgrade
{
    class Program
    {
        static void Main(string[] args)
        {            
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();
            string[] line = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            while (line[0] != "END")
            {
                if (line[0] == "ListAll")
                {
                    foreach (KeyValuePair<string, string> item in phonebook)
                    {
                        Console.WriteLine("{0} -> {1}", item.Key, item.Value);
                    }
                }
                else
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

                }

                line = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
