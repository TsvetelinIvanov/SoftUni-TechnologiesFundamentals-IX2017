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
            Dictionary<string, decimal> products = new Dictionary<string, decimal>();
            int productsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < productsCount; i++)
            {
                string[] productInfo = Console.ReadLine().Split('-');
                string product = productInfo[0];
                decimal price = decimal.Parse(productInfo[1]);
                if (!products.ContainsKey(product))
                {
                    products.Add(product, 0);
                }

                products[product] = price;
            }

            List<Customer> customers = new List<Customer>();
            string order = String.Empty;
            while ((order = Console.ReadLine()) != "end of clients")
            {
                string[] orderInfo = order.Split('-', ',');
                string customerName = orderInfo[0];
                string product = orderInfo[1];
                int quantity = int.Parse(orderInfo[2]);

                if (!products.ContainsKey(product))
                {
                    continue;
                }

                if (customers.Any(c => c.Name == customerName))
                {
                    Customer customer = customers.Single(c => c.Name == customerName);
                    if (!customer.ShopList.ContainsKey(product))
                    {
                        customer.ShopList.Add(product, 0);
                    }

                    customer.ShopList[product] += quantity;
                    customer.Bill += products[product] * quantity;                    
                }
                else
                {
                    Customer customer = new Customer();
                    customer.Name = customerName;
                    customer.ShopList = new Dictionary<string, int>();
                    
                    customer.ShopList[product] = quantity;
                    customer.Bill = products[product] * quantity;
                    
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
