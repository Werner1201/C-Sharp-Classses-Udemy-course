
namespace ExercicioClassesAbstratas1.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double yearlyIncome, int numberOfEmployees) : base(name, yearlyIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {

            if (NumberOfEmployees > 10)
            {
                return ((YearlyIncome * 14) / 100);
            }
            else
            {
                return ((YearlyIncome * 16) / 100);
            }
        }
    }
}
