using System;
using System.Globalization;

namespace ExercicioClasses2 {
    class Program {
        static void Main(string[] args) {
            Funcionario f = new Funcionario();
            
            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine($"Funcionario: {f.ToString()}");
            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salario: ");
            f.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine($"Dados Atualizados: {f}");
        }
    }
}
