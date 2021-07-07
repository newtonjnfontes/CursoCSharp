using ConsoleApp1;
using System;  // contem funções basicas de manipulação de programa
using System.Globalization; // contem funções para padrões de formato para datas, moeda, números 


namespace ConstruturesPalavraThis  // daclaração de namespace desse probrama
{
    class Program  // declaração de classe que é a unidade básica do programa
    {
        static void Main(string[] args) // membro da classe
                                        // indica onde o programa é iniciado

        {
            // ================================================
            // Captura dados do Produto

            Console.WriteLine("---------------------------");
            Console.WriteLine("SobreCarga vazia");
            Produto p1 = new Produto(); // chama o construtor padrão para zerar variáveis
            Console.WriteLine("Dados atualizados com SobreCarga vazia: " + p1);
            //  Produto p = new Produto("TV", 500.00, 10); // é nessa hora que o Construtor é acionado - para inicializar as variáveis
            Console.WriteLine("---------------------------");
            Console.WriteLine("Construtores");
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            // p.Nome = Console.ReadLine();  mudado para inicialiar no construtor
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            // p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            // p.Quantidade = int.Parse(Console.ReadLine());
            int quantidade = int.Parse(Console.ReadLine());
            Produto p = new Produto(nome, preco, quantidade); // construtor colocado após obter as variáveis inicializadas
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine("---------------------------");
            Console.WriteLine("Uso da palavra this na classe produto");
            Produto p3 = new Produto();
            Console.WriteLine("Dados atualizados Vazio: " + p3);
            Produto p4 = new Produto(nome, preco);
            Console.WriteLine("Dados atualizados com nome e preço: " + p4);
            Produto p5 = new Produto(nome, preco, quantidade);
            Console.WriteLine("Dados atualizados com nome, preço e quantidade: " + p5);
            Console.WriteLine("---------------------------");
            Console.WriteLine(" Inicialização sem construtores");
            Produto p2 = new Produto(nome = "Rádio", preco = 100.00, quantidade = 15); // sem chamar construrotes iniciando variáveis
            Console.WriteLine("Dados atualizados sem construtores: " + p2);


        }

    }
}
