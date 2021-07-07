using ConsoleApp1;
using System;  // contem funções basicas de manipulação de programa
using System.Globalization;
using System.Collections.Generic; // usado para trabalho com listas



namespace Matrizes_Empregados // daclaração de namespace desse probrama
{
    class Program  // declaração de classe que é a unidade básica do programa
    {
        static void Main(string[] args) // membro da classe
                                        // indica onde o programa é iniciado

        {
            // ================================================
            // Modificador de parametros params, out, ref

            Console.WriteLine("---------------------------");
            Console.WriteLine("Modificando Parametros params ");
            int result = Soma.Sum(10, 20, 30, 40); // usando modificador de parametros na classe Soma contida na Calculadora.cs
                                                   // variando a quantidade de elementos a serem passados para classe Soma
            Console.WriteLine("soma de 10 + 20 + 30 + 40 = " + result);

            result = Soma.Sum(50, 60, 70); // usando modificador de parametros na classe Soma com qtde variável

            Console.WriteLine("soma de 50 + 60 + 70 = " + result);

            Console.WriteLine("---------------------------");
            Console.WriteLine("Lista - trabalhando com funcionários ");

            Console.Write("Quantos empregados serão registrados? ");
            int n = int.Parse(Console.ReadLine() + 0);
            n = n / 10;
            List<Empregado> list = new List<Empregado>();
            if (n != 0) {
                for (int i = 1; i <= n; i++) {
                    Console.WriteLine("Empregado #" + i + ":");
                    Console.Write("Id: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Salário: ");
                    double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Empregado(id, nome, salario));
                    Console.WriteLine("Empregado adicionado");
                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.WriteLine("Lista de Empregados:");
                foreach (Empregado obj in list) {
                    Console.WriteLine(obj);
                }
                Console.Write("Entre com o id do Empregado que terá aumento : ");
                int IdPesquisa = int.Parse(Console.ReadLine());

                Empregado emp = list.Find(x => x.Id == IdPesquisa);
                if (emp != null) {
                    Console.Write("Entre com o percentual: ");
                    double percentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    emp.AumentaSalario(percentagem);
                }
                else {
                    Console.WriteLine("Este Id não existe!");
                }

                Console.WriteLine();
                Console.WriteLine("Alterada Lista de Empregados:");
                foreach (Empregado obj in list) {
                    Console.WriteLine(obj);
                }
            }
            Console.WriteLine("---------------------------");
            Console.WriteLine("Matriz ");
            double[,,] mat1 = new double[2, 3, 4]; // define matriz de suas dimensoes
            Console.WriteLine("Qtde de elementos da matriz : " + mat1.Length); // define qtde de elementos da matriz
            Console.WriteLine("Qtde de dimensoes da matriz : " + mat1.Rank); // define quantidade de linhas
            Console.WriteLine("Qtde de elementos da primeira dimensão : " + mat1.GetLength(0)); // qtde de elementos da primeira dimensão
            Console.WriteLine("Qtde de elementos da segunda dimensão : " + mat1.GetLength(1)); // qtde de elementos da segunda dimensão
            Console.WriteLine("Qtde de elementos da terceira dimensão : " + mat1.GetLength(2));
            Console.Write("Quantas dimensoes da matriz quadrada? ");
            int n1 = int.Parse(Console.ReadLine() + 0);
            n1 = n1 / 10;
            if (n1 != 0) {
                int[,] mat = new int[n1, n1];

                for (int i = 0; i < n1; i++) {
                    Console.Write("Entre com os números da linha " + (i + 1) + " separado por espaço : ");
                    string[] values = Console.ReadLine().Split(' '); // array values contendo os numeros digitados na linha
                    for (int j = 0; j < n1; j++) {
                        mat[i, j] = int.Parse(values[j]);
                    }
                }

                Console.WriteLine("Diagonal Principal:");
                for (int i = 0; i < n1; i++) {
                    Console.Write(mat[i, i] + " ");
                }
                Console.WriteLine();

                int count = 0;
                for (int i = 0; i < n1; i++) {
                    for (int j = 0; j < n1; j++) {
                        if (mat[i, j] < 0) {
                            count++;
                        }
                    }
                }
                Console.WriteLine("Qtde de números negativos: " + count);
            }
            Console.WriteLine("---------------------------");
            Console.WriteLine("Matriz não quadrada ");
            Console.Write("Entre com os número da linha e colula da Matriz, separado por espaço : ");
            string[] MatMult = Console.ReadLine().Split(' '); // array values contendo os numeros digitados na linha
            int mm = int.Parse(MatMult[0]);
            int nn = int.Parse(MatMult[1]);

            int[,] mat02 = new int[mm, nn];

            for (int i = 0; i < mm; i++) {
                Console.Write("Entre com os " + nn + " números da linha " + (i + 1) + " separado por espaço : ");
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < nn; j++) {
                    mat02[i, j] = int.Parse(values[j]);
                }
            }

            Console.Write("Entre com número a ser comparado : ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < mm; i++) {
                for (int j = 0; j < nn; j++) {
                    if (mat02[i, j] == x) {
                        Console.WriteLine("Posição " + i + "," + j + ":");
                        if (j > 0) {
                            Console.WriteLine("Esquerda: " + mat02[i, j - 1]);
                        }
                        if (i > 0) {
                            Console.WriteLine("Acima: " + mat02[i - 1, j]);
                        }
                        if (j < nn - 1) {
                            Console.WriteLine("Direita: " + mat02[i, j + 1]);
                        }
                        if (i < mm - 1) {
                            Console.WriteLine("Abaixo: " + mat02[i + 1, j]);
                        }
                    }
                }

            }
        }

    }
}

