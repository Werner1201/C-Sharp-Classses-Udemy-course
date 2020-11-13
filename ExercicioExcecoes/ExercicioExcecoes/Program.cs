using System;
using ExercicioExcecoes.Entities;
using ExercicioExcecoes.Entities.Exceptions;

namespace ExercicioExcecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data: ");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double Ib = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double wL = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

                Account account = new Account(number, holder, Ib, wL);

                Console.Write("Enter amount for withdraw: ");
                double wA = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
                account.Withdraw(wA);
                Console.WriteLine($"New Balance: {account.Balance}");
            }
            catch (DomainException e) 
            {
                Console.WriteLine($"Withdraw error: {e.Message}");
            }
        }
    }
}
