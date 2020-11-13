using System;
using System.Collections.Generic;
using ExercicioHerancaEPolimorfismo1.Entities;

namespace ExercicioHerancaEPolimorfismo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Pays(ReadEmployees(ReadEmpNum())));
        }

        static int ReadEmpNum()
        {
            Console.Write("Enter the number of Employees: ");
            int EmpNum = int.Parse(Console.ReadLine());
            return EmpNum;
        }

        static List<Employee> ReadEmployees(int EmpNum)
        {
            List<Employee> list = new List<Employee>();
            for (int i = 0; i < EmpNum; i++)
            {
                Console.WriteLine($"Employee #{i+1}: ");
                Console.Write("Outsourced (y/n)? ");
                string tipo = Console.ReadLine().ToLower();
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int h = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double vph = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

                if (tipo == "y")
                {
                    Console.Write("Additional Charge: ");
                    double addCharge = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
                    OutsourcedEmployee oe = new OutsourcedEmployee(name, h, vph, addCharge);
                    list.Add(oe);
                    
                }else if(tipo == "n")
                {
                    Employee e = new Employee(name, h, vph);
                    list.Add(e);
                }
            }
            return list;
        }

        static string Pays(List<Employee> list)
        {
            Console.WriteLine("PAYMENTS: ");
            string text = "";
            foreach (Employee emp in list)
            {
                text += $"{emp.Name} - ${emp.Payment()}\n";
            }

            return text;
        }
    }
}
