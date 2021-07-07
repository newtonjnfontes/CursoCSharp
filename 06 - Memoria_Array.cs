using ConsoleApp1;
using System;  // contem funções basicas de manipulação de programa
using System.Globalization; // contem funções para padrões de formato para datas, moeda, números 


namespace Memorias_Array_lista  // daclaração de namespace desse probrama
{
    class Program  // declaração de classe que é a unidade básica do programa
    {
        static void Main(string[] args) // membro da classe
                                        // indica onde o programa é iniciado

        {
            // ================================================
            // Memoria, Array e Lista

            Console.WriteLine("---------------------------");
            Console.WriteLine("Transformando classe em structs ");
            PointStruct p;  // chama o struct em vez da classe
            // Console.WriteLine(p); // erro: variável não atribuída
            p.Z = 10;
            p.X = 3;

            // tambem pode ser double? x = null;
            string resultado = Convert.ToString(p.X); // converte double para string com objetivo de tratar tamanho
            if (resultado.Length == 1) {
                p.X = p.X * 100;
            }
            else {
                if (resultado.Length == 2) {
                    p.X = p.X * 10;
                }
            }
            p.Y = 20;

            Console.WriteLine(p);
            Console.WriteLine("---------------------------");
            Console.WriteLine("Variáveis nullable, coalescência e parametro HasValue");
            Nullable<double> x = null; // consegue com nullable fazer variavel double nula
            Console.WriteLine("variável nullable : " + x);
            Console.WriteLine("variável nullable com HasValue: " + x.HasValue); // intica se a variável é null ou não
            Console.WriteLine("variável nullable com GetValueOrDefault() : " + x.GetValueOrDefault()); // atribui valor default do double
            double? y = null; // definir para usar o GetValueOrDefalut
            y = Convert.ToDouble(p.X); // volta string para double
            Console.WriteLine("variável nullable com parametros e GetValueOrDefault()  : " + y.GetValueOrDefault());
            Console.WriteLine("variável nullable com HasValue: " + y.HasValue);
            if (x.HasValue) // para verificar se uma variável é null evitando excessão
                Console.WriteLine("x = " + x.Value);
            else
                Console.WriteLine("X é null");
            if (y.HasValue)
                Console.WriteLine("y = " + y.Value);
            else
                Console.WriteLine("Y é null");
            double z = x ?? 5; // atribui a variável z , se a variável x for null , o valor 5
            Console.WriteLine("variável coalescência x ?? : " + z);

            // colocado aqui para não zerar o p.X usado no y
            p = new PointStruct(); // para zerar ponteiro p
            Console.WriteLine(p);
            Console.WriteLine("---------------------------");
            Console.WriteLine("Leitura de Vetores tipo struct - Media de Alturas");
            Console.Write("Entre Com Qtde de Alturas : ");
            int alt = int.Parse(Console.ReadLine()); // obtem qtde de alturas
            double[] vet = new double[alt];
            for (int i = 0; i < alt; i++) {
                Console.Write("Entre Com Altura " + (i + 1) + ": ");
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            double sum = 0.0;
            for (int i = 0; i < alt; i++) {
                sum += vet[i]; // percorre os elementos do vetor e soma seus valores
            }
            double avg = sum / alt; // divide pela qtde de alturas para obter a média
            Console.WriteLine("Altura média é = " + avg.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("---------------------------");
            Console.WriteLine("Leitura de Vetores tipo classe - Media de Precos");
            Console.Write("Entre Com Qtde de Produtos : ");

            int Prod = int.Parse(Console.ReadLine()); // obtem qtde de alturas

            Produto[] vetprod = new Produto[Prod]; // usar vetores com os campos contidos na classe produto ( nome, preco, qtde )

            for (int i = 0; i < Prod; i++) {
                Console.WriteLine("Entre Com Dados do produto " + (i + 1) + ": ");
                Console.Write("Entre Com Nome do Produto : "); // informar os dados do produto
                string name = Console.ReadLine();
                Console.Write("Entre Com Preço do Produto : ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Entre Com Quantidade do Produto : ");
                int qtde = int.Parse(Console.ReadLine());
                vetprod[i] = new Produto { Nome = name, Preco = price, Qtde = qtde }; // chama a classe do produto

            }
            double sumpreco = 0.0;
            int sumqtde = 0;
            for (int i = 0; i < Prod; i++) {
                sumpreco += vetprod[i].Preco; // percorre os elementos do vetor.preco e soma seus valores
                sumqtde += vetprod[i].Qtde; // percorre os elementos do vetor.qtde e soma seus valores
                Console.WriteLine("Produto : " + (i + 1) + " É " + vetprod[i]);
            }
            double avgpreco = sumpreco / Prod; // divide pela qtde de Produtos para obter a média dos preços
            int avgqtde = sumqtde / Prod; // divide pela qtde de Produtos para obter a média das quantidades

            Console.WriteLine("A média de preços é = " + avgpreco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("A média de quantidades é = " + avgqtde.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("---------------------------");
            Console.WriteLine("Leitura de Vetores tipo classe - Quartos para Aluguel");
            Estudante[] vect = new Estudante[10];
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Estudante(nome, email);
            }
            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++) {
                if (vect[i] != null) {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }


        }

    }
}
