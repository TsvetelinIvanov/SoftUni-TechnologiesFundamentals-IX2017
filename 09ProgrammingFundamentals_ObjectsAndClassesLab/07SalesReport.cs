using System;
using System.Collections.Generic;

namespace _07SalesReport
{
    class Sale
    {
        public string Town { get; set; }
        
        public string Product { get; set; }
        
        public decimal Price { get; set; }
        
        public decimal Quantity { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Sale[] sales = ReadSales();
            SortedDictionary<string, decimal> salesByTown = new SortedDictionary<string, decimal>();
            foreach (Sale sale in sales)
            {
                if (!salesByTown.ContainsKey(sale.Town))
                {
                    salesByTown.Add(sale.Town, 0);
                }

                salesByTown[sale.Town] += sale.Price * sale.Quantity;
            }

            foreach (KeyValuePair<string, decimal> sale in salesByTown)
            {
                Console.WriteLine("{0} -> {1:f2}", sale.Key, sale.Value);
            }
        }

        static Sale[] ReadSales()
        {
            int salesCount = int.Parse(Console.ReadLine());
            Sale[] sales = new Sale[salesCount];
            for (int i = 0; i < salesCount; i++)
            {
                sales[i] = ReadSale();
            }

            return sales;
        }

        static Sale ReadSale()
        {
            string[] saleInfo = Console.ReadLine().Split();

            return new Sale()
            {
                Town = saleInfo[0],
                Product = saleInfo[1],
                Price = decimal.Parse(saleInfo[2]),
                Quantity = decimal.Parse(saleInfo[3])
            };
        }               
    }
}
