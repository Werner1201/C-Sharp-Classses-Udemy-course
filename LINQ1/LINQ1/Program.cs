using System;
using System.Linq;

namespace LINQ1
{
    class Program
    {
        static void Main(string[] args)
        {
            //especificar o data source
            int[] numbers = new int[] { 2, 3, 4, 5 };

            //Definir a query
            //IEnummerable result
            var result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            //Execute the query
            foreach (int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}
