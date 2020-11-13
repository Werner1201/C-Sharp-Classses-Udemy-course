using System;
using System.Globalization;

namespace ExercicioClasses21 {
    class Conta {
        private CultureInfo ponto = CultureInfo.InvariantCulture;
        private string Titular { get; set; };
        public int Numero { get; private set; }
        private double Saldo { get; private set; }

        public Conta(int numConta, string nomeTitular) {
            this.NumConta = numConta;
            this._titular = nomeTitular;
            this._saldo = 0;
        }

        public Conta(int numConta, string nomeTitular, double depInicial) : this(numConta, nomeTitular) {
            this._saldo += depInicial;
        }

        
        public string Nome {
            get => this._titular;
            set {
                if(value != null && value.Length > 1) {
                    this._titular = value;
                }
            }
        }


        public void Deposito(double dep) {
            this._saldo += dep;
        }

        public void Saque(double saq) {
            this._saldo -= saq + 5.00;
        }

        public override string ToString() {
            return $"Conta: {this.NumConta}, Titular: {this.Nome}, Saldo: ${this._saldo.ToString("F2", ponto)}";
        }
    }
}
