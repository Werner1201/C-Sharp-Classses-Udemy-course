using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using ExercicioEnum2.Entities;
using ExercicioEnum2.Entities.Enums;

namespace ExercicioEnum2.View
{
    public class Vizu
    {
        public Vizu() 
        {
            
        }

        public Client EnterClient()
        {
            Console.WriteLine("Enter Client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            string date = Console.ReadLine();
            Client c = new Client(name, email, DateTime.Parse(date));
            return c;
        }

        public Order EnterOrder(Client client)
        {
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            string status = Console.ReadLine();
            Console.Write("How many items to this order? ");
            int qtd = int.Parse(Console.ReadLine());
           
            Order o = new Order(Enum.Parse<OrderStatus>(status), client);
            for (int i = 0; i < qtd; i++)
            {
                o.AddItem(EnterItem(i));
            }

            return o;
        }

        public OrderItem EnterItem(int number)
        {
            Console.WriteLine($"Enter #{number+1} data: ");
            Console.Write("Product name: ");
            string name = Console.ReadLine();
            Console.Write("Product price: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantity: ");
            int qtd = int.Parse(Console.ReadLine());
            Product p = new Product(name, price);
            OrderItem oi = new OrderItem(qtd, price, p);
            return oi;
        }
    }
}
