using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, double>> shop = new Dictionary<string, Dictionary<string, double>>();

            while (input != "Revision")
            {
                string[] data = input.Split(", ");

                string company = data[0];
                string product = data[1];
                double price = double.Parse(data[2]);

                if (!shop.ContainsKey(company))
                {
                    shop.Add(company, new Dictionary<string, double>());
                }

                shop[company].Add(product, price);

                input = Console.ReadLine();
            }

            shop = shop.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var sh in shop)
            {
                Console.WriteLine($"{sh.Key}->");
                foreach (var product in sh.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
