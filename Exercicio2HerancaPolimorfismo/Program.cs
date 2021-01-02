using Exercicio2HerancaPolimorfismo.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio2HerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> listProducts = new List<Product>();

            Console.Write("Enter the number of products: ");
            int numberOfProducts = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numberOfProducts; i++)
            {
                Console.WriteLine($"Product #{i + 1} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char tag = Convert.ToChar(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = Convert.ToDouble(Console.ReadLine(),CultureInfo.InvariantCulture);

                Product product;

                if (tag == 'c')
                {
                    product = new Product(name, price);
                }
                else if (tag == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = Convert.ToDateTime(Console.ReadLine());
                    product = new UsedProduct(name, price, manufactureDate);
                }
                else if (true)
                {
                    Console.Write("Customs fee: ");
                    double customsFee = Convert.ToDouble(Console.ReadLine(),CultureInfo.InvariantCulture);
                    product = new ImportedProduct(name, price, customsFee);
                }
                listProducts.Add(product);
            }

            Console.WriteLine("PRICE TAGS:");
            foreach (Product product in listProducts)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
