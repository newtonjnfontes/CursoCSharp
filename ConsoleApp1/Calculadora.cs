using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    class Calculadora {
        public double Pi = 3.1415926535;
        public double Circunferencia(double r) {
            return 2.0 * Pi * r;
        }
        public double Volume(double r) {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);  // em vez de r * r * r coloca-se a potencia math.pow(r, 3.0)
        }
    }
    class Soma {
        public static int Sum(params int[] numeros) { // usando modificador de parametros 
                                                      // variando a quantidade de elementos passados
            int sum = 0;
            for (int i = 0; i < numeros.Length; i++) {
                sum += numeros[i];
            }
            return sum;
        }
    }

    class Product {  // usando ref e out como modificador de parametros
        public static void MultRef(ref int x, int num) { // referencia a variavel chamada e num é a qtde de vezes a ser multiplicada
            x = x * num;
        }
        public static void MultOut(int origem, out int resultado, int numout) { // referencia a variavel chamada e num é a qtde de vezes a ser multiplicada
            resultado = origem * numout; 
        }

    }
}

