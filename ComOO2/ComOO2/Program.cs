using System;
using System.Globalization;

namespace ComOO2 {
    class Program {
        static void Main(string[] args) {
            


            Console.WriteLine("Entre os dados do Produto:");
            Console.Write("Nome:");
            string nome = Console.ReadLine();
            Console.Write("Preco:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em Estoque:");
            int quantidade = int.Parse(Console.ReadLine());
            Produto p = new Produto(nome, preco, quantidade);

      

            Console.WriteLine($"Dados do Produto: {p}");
            Console.WriteLine("");
            Console.Write("Digite o numero de produtos a ser adicionado ao estoque: ");
            p.AdicionarProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine("");
            Console.WriteLine($"Dados Atualizados: {p}");
            Console.WriteLine("");
            Console.Write("Digite o numero de produtos a ser removido ao estoque: ");
            p.RemoverProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine("");
            Console.WriteLine($"Dados Atualizados: {p}");
        }
    }
}
