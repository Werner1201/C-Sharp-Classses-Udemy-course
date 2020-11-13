using System;
using System.Collections.Generic;
using ExercicioClassesAbstratas1.Entities;

namespace ExercicioClassesAbstratas1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"TOTAL TAXES:  ${Payers(ReadTaxPayers(ReadTaxNum())).ToString("F2", System.Globalization.CultureInfo.InvariantCulture)}");
        }

        static int ReadTaxNum()
        {
            Console.Write("Enter the number of Tax Payers: ");
            int EmpNum = int.Parse(Console.ReadLine());
            return EmpNum;
        }

        static List<TaxPayer> ReadTaxPayers(int EmpNum)
        {
            List<TaxPayer> list = new List<TaxPayer>();
            for (int i = 0; i < EmpNum; i++)
            {
                Console.WriteLine($"Tax payer #{i + 1} data: ");
                Console.Write("Individual or company (i/c)? ");
                string tipo = Console.ReadLine().ToLower();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);


                if (tipo == "i")
                {
                    Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
                    Individual indi = new Individual(name, anualIncome, health);
                    list.Add(indi);

                }
                else if (tipo == "c")
                {
                    Console.Write("Number of employees: ");
                    int n = int.Parse(Console.ReadLine());
                    Company c = new Company(name, anualIncome, n);
                    list.Add(c);
                }
            }
            return list;
        }

        static double Payers(List<TaxPayer> list)
        {
            Console.WriteLine("TAXES PAID: ");
            string text = "";
            double taxes = 0.0;
            foreach (TaxPayer payer in list)
            {
                text += $"{payer.Name}: $ {payer.Tax().ToString("F2", System.Globalization.CultureInfo.InvariantCulture)}\n";
                taxes += payer.Tax();
            }

            Console.WriteLine(text);
            return taxes;
        }
    }
}
