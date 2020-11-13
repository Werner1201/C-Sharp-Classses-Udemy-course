using System;
using System.Globalization;

namespace ExercicioClasses21 {
    class Program {
        static void Main(string[] args) {
            CultureInfo ponto = CultureInfo.InvariantCulture;
            Conta c;
            Console.Write("Entre o numero da conta: ");
            int numConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Havera deposito inicial (s/n)? ");
            string opt = Console.ReadLine();
            double dep = 0.0;
            if (opt.ToUpper() == "S") {
                Console.Write("Entre o valor de deposito inicial: ");
                dep = double.Parse(Console.ReadLine(), ponto);
                c = new Conta(numConta, titular, dep);
            }else {
                c = new Conta(numConta, titular);
            }

            Console.WriteLine("");
            Console.WriteLine("Dados da Conta:");
            Console.WriteLine($"{c}");
            Console.WriteLine("");
            Console.Write("Entre um valor para deposito: ");
            c.Deposito(double.Parse(Console.ReadLine(), ponto));
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine($"{c}");
            Console.WriteLine("");
            Console.Write("Entre um valor para Saque: ");
            c.Saque(double.Parse(Console.ReadLine(), ponto));
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine($"{c}");
        }
    }
}
