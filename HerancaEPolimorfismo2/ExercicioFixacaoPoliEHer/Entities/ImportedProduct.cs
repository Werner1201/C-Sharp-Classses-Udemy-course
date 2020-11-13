using System;
using System.Globalization;

namespace ExercicioFixacaoPoliEHer.Entities
{
    class ImportedProduct :  Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            string preco = $"{Name} $ {TotalPrice().ToString("F2", CultureInfo.InvariantCulture)} (Customs Fee: $ {CustomsFee})";
            return preco;
        }

        public double TotalPrice()
        {

            return Price + CustomsFee;
        }
    }
}
