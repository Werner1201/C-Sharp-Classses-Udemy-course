using System;
using System.Collections.Generic;
using ExercicioFixacaoPoliEHer.Entities;

namespace ExercicioFixacaoPoliEHer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PriceTags(ReadProducts(ReadProdNum())));
        }
        static int ReadProdNum()
        {
            Console.Write("Enter the number of Products: ");
            int ProdNum = int.Parse(Console.ReadLine());
            return ProdNum;
        }

        static List<Product> ReadProducts(int ProdNum)
        {
            List<Product> list = new List<Product>();
            for (int i = 0; i < ProdNum; i++)
            {
                Console.WriteLine($"Product #{i + 1}: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                string tipo = Console.ReadLine().ToLower();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

                if (tipo == "i")
                {
                    Console.Write("Customs fee: ");
                    double fee = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
                    ImportedProduct ip = new ImportedProduct(name, price,fee);
                    list.Add(ip);

                }
                else if (tipo == "u")
                {
                    Console.Write("Manufacture date: (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    UsedProduct up = new UsedProduct(name, price, date);
                    list.Add(up);
                }
                else if (tipo == "c")
                {
                    Product p = new Product(name, price);
                    list.Add(p);
                }
            }
            return list;
        }

        static string PriceTags(List<Product> list)

        {
            Console.WriteLine("PRICE TAGS: ");
            string text = "";
            foreach (Product p in list)
            {
                text += $"{p.PriceTag()}\n";
            }

            return text;
        }
    }
}
