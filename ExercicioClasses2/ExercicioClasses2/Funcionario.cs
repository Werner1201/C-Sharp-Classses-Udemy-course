using System;
using System.Globalization;

namespace ExercicioClasses2 {
    class Funcionario {
        public string Nome;
        public double SalarioBruto, Imposto;

        public double SalarioLiquido() {
            return this.SalarioBruto - this.Imposto;
        }

        public void AumentarSalario(double porcentagem) {
            this.SalarioBruto += this.SalarioBruto / porcentagem; 
        }

        public override string ToString() {
            return $"{this.Nome}, $ {this.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
