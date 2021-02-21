using System;
using System.Collections.Generic;
using System.Linq;

namespace _07AndreyAndBilliard
{    
    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> ShopList { get; set; }
        public decimal Bill { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> prices = new Dictionary<string, decimal>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] priceInfo = Console.ReadLine().Split('-');
                string product = priceInfo[0];
                decimal price = decimal.Parse(priceInfo[1]);
                if (!prices.ContainsKey(product))
                {
                    prices.Add(product, 0);
                }

                prices[product] = price;
            }

            List<Customer> customers = new List<Customer>();
            string order = String.Empty;
            while ((order = Console.ReadLine()) != "end of clients")
            {
                string[] orderInfo = order.Split('-', ',');
                string client = orderInfo[0];
                string product = orderInfo[1];
                int quantity = int.Parse(orderInfo[2]);

                if (!prices.ContainsKey(product))
                {
                    continue;
                }

                if (customers.Any(c => c.Name == client))
                {
                    Customer customer = customers.Single(c => c.Name == client);
                    if (!customer.ShopList.ContainsKey(product))
                    {
                        customer.ShopList.Add(product, 0);
                    }

                    customer.ShopList[product] += quantity;
                    customer.Bill += prices[product] * quantity;                    
                }
                else
                {
                    Customer customer = new Customer();
                    customer.Name = client;
                    customer.ShopList = new Dictionary<string, int>();
                    customer.ShopList[product] = quantity;
                    customer.Bill = prices[product] * quantity;
                    customers.Add(customer);
                }                
            }

            foreach (Customer customer in customers.OrderBy(c => c.Name))
            {
                Console.WriteLine(customer.Name);
                foreach (KeyValuePair<string, int> item in customer.ShopList)
                {
                    Console.WriteLine("-- {0} - {1}", item.Key, item.Value);
                }

                Console.WriteLine("Bill: {0:f2}", customer.Bill);
            }

            Console.WriteLine("Total bill: {0:f2}", customers.Sum(c => c.Bill));
        }
    }
}
