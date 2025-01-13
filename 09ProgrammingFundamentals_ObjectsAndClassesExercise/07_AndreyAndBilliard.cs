using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_AndreyAndBilliard
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> clients = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, double> products = new Dictionary<string, double>();

            int productsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < productsCount; i++)
            {
                string[] productInfo = Console.ReadLine().Split('-');
                if (products.ContainsKey(productInfo[0]))
                {
                    products[productInfo[0]] = double.Parse(productInfo[1]);
                }
                else
                {
                    products.Add(productInfo[0], double.Parse(productInfo[1]));
                }
            }

            string[] orders = Console.ReadLine().Split('-', ',');
            while (orders[0] != "end of clients")
            {
                string client = orders[0];
                string product = orders[1];
                int quantity = int.Parse(orders[2]);
                if (products.ContainsKey(product) && !clients.ContainsKey(client))
                {
                    clients.Add(client, new Dictionary<string, int>());
                }

                if (products.ContainsKey(product))
                {
                    if (!clients[client].ContainsKey(product))
                    {
                        clients[client].Add(product, quantity);
                    }
                    else
                    {
                        clients[client][product] += quantity;
                    }
                }

                orders = Console.ReadLine().Split('-', ',');
            }

            double totalSum = 0;
            foreach (KeyValuePair<string, Dictionary<string, int>> client in clients.OrderBy(c => c.Key))
            {
                Console.WriteLine(client.Key);
                double sum = 0;
                foreach (KeyValuePair<string, int> product in client.Value)
                {
                    Console.WriteLine($"-- {product.Key} - {product.Value}");
                    sum += product.Value * products[product.Key];
                }

                Console.WriteLine("Bill: {0:f2}", sum);
                totalSum += sum;
            }

            Console.WriteLine("Total bill: {0:f2}", totalSum);
        }
    }
}
