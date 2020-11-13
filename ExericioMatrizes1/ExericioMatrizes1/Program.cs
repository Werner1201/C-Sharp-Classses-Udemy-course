using System;

namespace ExericioMatrizes1 {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];
            for (int i = 0; i < n; i++) {
                string[] numbers = Console.ReadLine().Split(" ");
                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(numbers[j]);
                }
            }
            Console.WriteLine("Main diagonal: ");
            for (int i = 0; i < n; i++) {
                Console.Write($"{mat[i,i]} ");
               
            }
            Console.WriteLine();

            int count = 0;
            for (int j = 0; j < n; j++) {
                for (int i = 0; i < n; i++) {
                    if(mat[j, i] < 0) {
                        count++;
                    }
                }
            }

            Console.WriteLine($"Negative number: {count}");
        }
    }
}
