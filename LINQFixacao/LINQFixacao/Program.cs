using System;
using System.IO;
using LINQFixacao.Entities;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace LINQFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            //@"d:\CSharpProjects\in.txt"
            Console.Write("Enter full file path: ");
            string sourceFilePath = $@"{Console.ReadLine()}";
            Console.WriteLine(sourceFilePath);
            string[] lines = readFile(sourceFilePath);
            List<Employee> employees = listEmployees(lines);
            
            Console.Write("Enter salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Email of people whose salary is more than 2000.00: ");
            var r1 = employees.Where(e => e.Salary > 2000.00).Select(e => e.Email);
            foreach (string item in r1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Sum of salary of people whose name starts with 'M': {employees.Where(e => e.Name.StartsWith('M')).Sum(e => e.Salary)}");
            
        }

        static string[] readFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            return lines;
        }
        static List<Employee> listEmployees(string[] lines)
        {
            List<Employee> employees = new List<Employee>();
            foreach (string line in lines)
            {
                Employee employee = readEmployee(line);
                employees.Add(employee);

            }
            return employees;
        }
        static Employee readEmployee(string line)
        {
            string[] fields = line.Split(',');
            return new Employee(fields[0], fields[1], double.Parse(fields[2], CultureInfo.InvariantCulture));
        }

        
    }
}
