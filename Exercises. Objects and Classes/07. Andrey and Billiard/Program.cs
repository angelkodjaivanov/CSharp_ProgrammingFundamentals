using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Andrey_and_Billiard
{
    class Program
    {

        class Customer
        {
            public string Name { get; set; }
            public Dictionary<string, int> customerProducts { get; set;}
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, decimal> products = new Dictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine().Split('-');

                products[arr[0]] = decimal.Parse(arr[1]);

            }

            string input = Console.ReadLine();
            List<Customer> customers = new List<Customer>();

            while (input != "end of clients")
            {

                List<string> clientPr = input.Split('-', ',').ToList();
                Dictionary<string, int> customerProdu = new Dictionary<string, int>();

                if (products.ContainsKey(clientPr[1]))
                {
                    bool haveClient = false;
                    customerProdu[clientPr[1]] = int.Parse(clientPr[2]);
                    if (customers != null)
                    {
                        for (int i = 0; i < customers.Count; i++)
                        {
                            if (customers[i].Name == clientPr[0])
                            {
                                if (customers[i].customerProducts.ContainsKey(clientPr[1]))
                                {
                                    customers[i].customerProducts[clientPr[1]] += int.Parse(clientPr[2]);
                                }
                                else
                                {
                                    customers[i].customerProducts[clientPr[1]] = int.Parse(clientPr[2]);
                                }
                                haveClient = true;
                            }
                        }
                        if (!haveClient)
                        {
                            customers.Add(new Customer { Name = clientPr[0], customerProducts = customerProdu });
                        }
                    }
                    else
                    {
                        customers.Add(new Customer { Name = clientPr[0], customerProducts = customerProdu });
                    }

                }

                input = Console.ReadLine();
            }

            customers = customers.OrderBy(p => p.Name).ToList();

            decimal totalBill = 0;
            for (int i = 0; i < customers.Count; i++)
            {
                decimal bill = 0;
                Console.WriteLine(customers[i].Name);
                foreach (var key in customers[i].customerProducts.Keys)
                {
                    Console.WriteLine($"-- {key} - {customers[i].customerProducts[key]}");
                    bill += customers[i].customerProducts[key] * products[key];
                }
                Console.WriteLine($"Bill: {bill:F2}");
                totalBill += bill;
            }

            Console.WriteLine($"Total bill: {totalBill:F2}");

        }
    }
}
