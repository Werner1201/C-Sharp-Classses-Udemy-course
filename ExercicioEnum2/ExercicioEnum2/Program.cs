using System;
using ExercicioEnum2.View;

namespace ExercicioEnum2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vizu v = new Vizu();
            Console.WriteLine(v.EnterOrder(v.EnterClient()));
        }
    }
}
