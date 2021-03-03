using System;
using System.Collections.Generic;
using System.Linq;

namespace _04RainAir
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> customers = new Dictionary<string, List<int>>();
            string input = Console.ReadLine();
            while (input != "I believe I can fly!")
            {
                if (!input.Contains("="))
                {
                    string[] customerData = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    string customerName = customerData[0];
                    if (!customers.ContainsKey(customerName))
                    {
                        customers.Add(customerName, new List<int>());
                    }

                    for (int i = 1; i < customerData.Length; i++)
                    {
                        customers[customerName].Add(int.Parse(customerData[i]));
                    }
                }
                else
                {
                    string[] customerData = input.Split(new string[] { " = " }, StringSplitOptions.None);
                    string customerName = customerData[0];
                    string otherCustomer = customerData[1];                    
                    if (!customers.ContainsKey(customerName))
                    {
                        customers[customerName] = new List<int>();
                    }
                    
                    customers[customerName].Clear();                    
                    foreach (int flight in customers[otherCustomer])
                    {
                        customers[customerName].Add(flight);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, List<int>> customer in customers.OrderByDescending(c => c.Value.Count).ThenBy(c => c.Key))
            {                
                Console.WriteLine($"#{customer.Key} ::: {string.Join(", ", customer.Value.OrderBy(x => x))}");
            }
        }
    }
}
