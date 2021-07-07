using System;
namespace ConsoleApp1 {
    class Triangulo {
        public double A;
        public double B;
        public double C;

        public double CalcularArea() { // criado esse método para calcular a área direto na classe
            double p1 = (A + B + C) / 2.0; // para usar na formula de Heron
            double area = Math.Sqrt(p1 * (p1 - A) * (p1 - B) * (p1 - C)); // (fórmula de Heron)
            return area;
            // pode ser assim ... return Math.Sqrt(p1 * (p1 - A) * (p1 - B) * (p1 - C));

        }
    }
}
