

namespace ExercicioClassesAbstratas1.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double yearlyIncome, double healthExpenditures) : base(name, yearlyIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if(YearlyIncome < 20000.00)
            {
                if(HealthExpenditures > 0.0)
                {
                    return ((YearlyIncome * 15) / 100) - ((HealthExpenditures * 50) / 100);
                }
                return ((YearlyIncome * 15) / 100);
            }
            else
            {
                if (HealthExpenditures > 0.0)
                {
                    return ((YearlyIncome * 25) / 100) - ((HealthExpenditures * 50) / 100);
                }
                return ((YearlyIncome * 25) / 100);
            }
        }
    }
}
