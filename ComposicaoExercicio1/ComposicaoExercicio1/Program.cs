using System;
using ComposicaoExercicio1.Entities;
using ComposicaoExercicio1.Entities.Enums;

namespace ComposicaoExercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            Departament d = new Departament(Console.ReadLine());
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            string level = Console.ReadLine();
            Console.Write("Base Salary: ");
            double sal = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            Console.Write("How many contracts to this worker ? ");
            int contracts = int.Parse(Console.ReadLine());
            Worker w = new Worker(name, Enum.Parse<WorkerLevel>(level), sal, d);
            string date = "";
            double vph = 0.0;
            int hours = 0;
            

            for (int i = 0; i < contracts; i++)
            {
                Console.WriteLine($"Enter #{i+1} contract data: ");
                Console.Write("Date (DD/YY/YYYY): ");
                date = Console.ReadLine();
                Console.Write("Value per hour: ");
                vph = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                hours = int.Parse(Console.ReadLine());
              
                w.AddContract(new HourContract(DateTime.Parse(date), vph, hours));
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            DateTime date1 = DateTime.Parse(Console.ReadLine());
            
            Console.WriteLine(w);
            Console.Write($"Income for {date1.Month}/{date1.Year}: {w.Income(date1.Year, date1.Month)}");
        }
    }
}
