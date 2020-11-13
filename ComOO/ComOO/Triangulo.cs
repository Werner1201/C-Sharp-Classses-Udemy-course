using System;

namespace ComOO {
    class Triangulo {
        public double A, B, C;

        public double Area() {
            double p = (this.A + this.B + this.C) / 2.0;
            return Math.Sqrt(p * (p - this.A) * (p - this.B) * (p - this.C));
           
        }
    }
}
