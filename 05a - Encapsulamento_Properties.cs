using ConsoleApp1;
using System;  // contem funções basicas de manipulação de programa
using System.Globalization; // contem funções para padrões de formato para datas, moeda, números 


namespace Encapsulamento_Properties  // daclaração de namespace desse probrama
{
    class Program  // declaração de classe que é a unidade básica do programa
    {
        static void Main(string[] args) // membro da classe
                                        // indica onde o programa é iniciado

        {
            // ================================================
            // Encapsulamento - Atributos são private na classe, esconde objetos

            Console.WriteLine("---------------------------");
            Console.WriteLine("Encapsulamento");
            Produto p1 = new Produto(); // chama o construtor padrão para zerar variáveis
            Console.WriteLine("Dados atualizados zerados no encapsulamento: " + p1);
            Produto p2 = new Produto("TV", 100.00, 15); // sem chamar construrotes iniciando variáveis
            Console.WriteLine("Dados atribuidos no encapsulamento: " + p2);
            p1.SetNome("Rádio");
            p1.SetPreco(900.00);
            p1.SetQtde(25);
            Console.WriteLine("obtendo Nome com metodo Get: " + p1.GetNome());
            Console.WriteLine("objeto p1 agora é : " + p1);
            // ================================================
            // Properties -  métodos encapsulados, porém expondo uma sintaxe similar de atribudos

            Console.WriteLine("---------------------------");
            Console.WriteLine("Properties");
            p1.Nome = "CD";
            p1.Preco = 150.00;
            p1.Qtde = 20;
            Console.WriteLine("objeto p1 com properties agora é : " + p1);
            // ================================================
            // Exercicio fixação

            Console.WriteLine("---------------------------");
            Console.WriteLine("Conta Bancária ");
            ContaBancaria conta;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S') {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

        }

    }
}
