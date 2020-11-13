using System;

namespace Course {
    class Program {
        static void Main(string[] args) {
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            string s = Console.ReadLine();

            string[] vet = s.Split(' ');

            Console.WriteLine("Vc digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine($"{vet[0]} {vet[1]} {vet[2]}");
        }
    }
}
