using System;

namespace ExerciciosClasses1 {
    class Retangulo {
        public double Largura, Altura;

        public double Area() {
            return this.Largura * this.Altura;
        }
        public double Perimetro() {
            return 2 * (this.Largura + this.Altura);
        }
        public double Diagonal() {
            return Math.Sqrt((this.Largura * this.Largura) + (this.Altura * this.Altura));
        }
    }
}
