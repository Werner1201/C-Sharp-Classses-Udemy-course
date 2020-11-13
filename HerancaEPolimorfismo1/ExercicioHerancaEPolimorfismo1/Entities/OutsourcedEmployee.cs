using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioHerancaEPolimorfismo1.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(string name, int hours, double vph, double additionalCharge): base(name, hours, vph)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            double pay = base.Payment();
            pay += ((AdditionalCharge * 110) / 100);
            return pay;
        }
    }
}
