using System.Globalization;

namespace ExercicioLista {
    class Employee {
        public int Id { get; set; }
        public string Nome { get; set; }
        private double Salario { get; set; }

        public Employee(int id, string nome, double salario) {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void IncreaseSalary(double percentage) {
            this.Salario += (this.Salario * percentage) / 100;
        }

        public override string ToString() {
            return $"{Id}, {Nome}, {Salario.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
