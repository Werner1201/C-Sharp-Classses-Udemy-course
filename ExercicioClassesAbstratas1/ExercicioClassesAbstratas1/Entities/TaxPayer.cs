﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioClassesAbstratas1.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double YearlyIncome { get; set; }

        protected TaxPayer(string name, double yearlyIncome)
        {
            Name = name;
            YearlyIncome = yearlyIncome;
        }

        public abstract double Tax();
    }
}
