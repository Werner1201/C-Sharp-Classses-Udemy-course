using System;
using System.Globalization;
using System.Collections.Generic;

namespace ExercicioLista {
    class Program {
        static void Main(string[] args) {
            List<Employee> lista = new List<Employee>();
            Console.Write("How many employees will be registered? ");
            int employees = int.Parse(Console.ReadLine());
            for (int i = 0; i < employees; i++) {
                lista.Add(EmployeeRegistration(i));
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int id = int.Parse(Console.ReadLine());
            Employee e = lista.Find(x => x.Id == id);
            if (e != null) {
                Console.Write("Enter the percentage: ");
                double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                e.IncreaseSalary(percent);
            }
            else {
                Console.WriteLine("This Id does not Exist!");
            }
           
           

            Console.WriteLine();
            ImprimeLista(lista);

        }

        static Employee EmployeeRegistration(int index) {
            Console.WriteLine($"Employee #{index+1}");
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Salary: ");
            double salary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine();

            return new Employee(id, name, salary);
        }

        static void ImprimeLista(List<Employee> lista) {
            Console.WriteLine("Updated List of Employees: ");
            foreach (Employee emp in lista) {
                Console.WriteLine($"{emp}");
            }
        }
    }
}
