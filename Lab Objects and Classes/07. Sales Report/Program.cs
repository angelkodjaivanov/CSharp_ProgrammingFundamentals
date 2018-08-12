using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sales_Report
{
    class Program
    {

        class Sale
        {
            public string Town { get; set; }
            public string Product { get; set; }
            public decimal Price { get; set; }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Sale> result = new Dictionary<string, Sale>();

            for (int i = 0; i < n; i++)
            {
                List<string> townProp = Console.ReadLine().Split(' ').ToList();

                if (result.ContainsKey(townProp[0]))
                {
                    result[townProp[0]].Price += (decimal.Parse(townProp[2]) * decimal.Parse(townProp[3]));
                }
                else
                {
                    result[townProp[0]] = new Sale { Town = townProp[0], Product = townProp[1],
                        Price = (decimal.Parse(townProp[2]) * decimal.Parse(townProp[3]))};
                }

            }

            result = result.OrderBy(p => p.Value.Town).ToDictionary(p => p.Key, p => p.Value);
            foreach (var key in result.Keys)
            {
                Console.WriteLine($"{key} -> {result[key].Price:F2}");
            }

        }
    }
}
