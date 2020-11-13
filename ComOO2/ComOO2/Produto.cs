using System;
using System.Globalization;

namespace ComOO2 {
    class Produto {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; set; }


        public Produto() {

        }


        public Produto(string nome, double preco, int qtd) {
            _nome = nome;
            Preco = preco;
            Quantidade = qtd;
        }

        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    this._nome = value;
                }
            }
        }


        

        public double ValorTotalEmEstoque() {
            return this.Preco * this.Quantidade;
        }

        public void AdicionarProdutos(int quantity) {
            this.Quantidade += quantity;
        }
        public void RemoverProdutos(int quantity) {
            this.Quantidade -= quantity;
        }

        public override string ToString() {
            return $"{this._nome}, $ {this.Preco.ToString("F2", CultureInfo.InvariantCulture)}, {this.Quantidade} unidades, Total: $ {this.ValorTotalEmEstoque()}";
        }
    }
}
