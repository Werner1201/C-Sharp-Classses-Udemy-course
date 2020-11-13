using System;
using Delegates1.Services;
namespace Delegates1
{
    delegate void BinaryNumericOperation(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;
            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;
            //BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.Sum);
            //double result = op(a, b);
            op.Invoke(a, b); 
            
        }
    }
}