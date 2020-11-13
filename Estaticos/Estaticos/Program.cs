using System;
using System.Globalization;

namespace Estaticos {
    class Program {

        
        static void Main(string[] args) {

             

            CultureInfo Ponto = CultureInfo.InvariantCulture;
            Console.Write("Entre o Valor do Raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine($"Circunferencia: {circ.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume: {volume.ToString("F2", Ponto)}");
            Console.WriteLine($"Valor de PI: {Calculadora.Pi.ToString("F2", Ponto)}");
        }

       


    }
}
