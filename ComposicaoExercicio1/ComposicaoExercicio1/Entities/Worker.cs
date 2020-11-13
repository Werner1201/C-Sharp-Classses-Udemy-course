using ComposicaoExercicio1.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;


namespace ComposicaoExercicio1.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }

        public double BaseSalary { get; set; }

        public Departament departament { get; set; }

        public List<HourContract> Contracts { get; set; } = new List<HourContract>();
        

        public Worker(string name, WorkerLevel level, double baseSalary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            this.departament = departament;
            
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double income = 0.0;
            foreach (HourContract contract in Contracts)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    income += contract.totalValue();
                }
            }
            return income + BaseSalary;
        }

        public override string ToString()
        {
            return $"Name: {Name}\n" + $"Department: {departament.Name}\n"; 
        }
    }
}
