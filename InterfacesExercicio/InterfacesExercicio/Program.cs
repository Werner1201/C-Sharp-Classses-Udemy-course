using System;
using System.Globalization;
using InterfacesExercicio.Entities;
using InterfacesExercicio.Services;

namespace InterfacesExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double totalValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int installs = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, totalValue, installs);

            ContractService contractService = new ContractService(new PaypalService());

            contractService.ProcessContract(contract, installs);

            Console.WriteLine("Installments: ");
            foreach (Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }

        }
    }
}
