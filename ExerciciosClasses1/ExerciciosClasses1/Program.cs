using System;
using System.Globalization;

namespace ExerciciosClasses1 {
    class Program {
        static void Main(string[] args) {
            Retangulo r = new Retangulo();
            Console.WriteLine("Entre a largura e altura do retangulo: ");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"AREA: {r.Area().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"PERIMETRO: {r.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"DIAGONAL: {r.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
