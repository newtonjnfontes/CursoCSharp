using ConsoleApp1.Entidades;
using ConsoleApp1.Entidades.Enums;
using System;  // contem funções basicas de manipulação de programa
using System.Globalization;
using System.Collections.Generic; // usado para trabalho com listas
namespace Enumeracao_Composicao // daclaração de namespace desse probrama
{
    class Program  // declaração de classe que é a unidade básica do programa
    {
        static void Main(string[] args) // membro da classe
                                        // indica onde o programa é iniciado
        {
            // ================================================
            Console.WriteLine("---------------------------");
            Console.WriteLine("Enumerações ");
            Pedido pedido = new Pedido
            {
                Id = 1080,
                Momento = DateTime.Now,
                Status = PedidoStatus.PagamentoPendente
            };

            Console.WriteLine(pedido); // chama o enum PedidoStatus para informa o status do pedido

            string txt = PedidoStatus.PagamentoPendente.ToString();

            PedidoStatus os = Enum.Parse<PedidoStatus>("Entregue");

            Console.WriteLine(os);
            Console.WriteLine(txt);
            Console.WriteLine("---------------------------");
            Console.WriteLine("Composições ");
            Console.Write("Entre com Nome do Departamento: ");
            string deptNome = Console.ReadLine();
            Console.WriteLine("Entre com data do Trabalho:");
            Console.Write("Nome Trabalhador: ");
            string nome = Console.ReadLine();
            Console.Write("Nivel de Experiêndia : (Junior/NivelMedio/Senior): ");
            NivelTrabalho nivel = Enum.Parse<NivelTrabalho>(Console.ReadLine());
            Console.Write("Salário Base: ");
            double salarioBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departamento depto = new Departamento(deptNome);
            Trabalhador trabalho = new Trabalhador(nome, nivel, salarioBase, depto);

            Console.Write("Quantos Contratos nesse Trabalho? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Entre dados do contrato #{i}:");
                Console.Write("Data (DD/MM/AAAA): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor Por Hora: ");
                double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duração (em Horas): ");
                int horas = int.Parse(Console.ReadLine());
                HoraContrato contrato = new HoraContrato(data, valorPorHora, horas);
                trabalho.AdicionaContrato(contrato);
            }

            Console.WriteLine();
            Console.Write("Entre com o Mês e o Ano para calcular o rendimento (MM/AAAA): ");
            string mesAno = Console.ReadLine();
            int mes = int.Parse(mesAno.Substring(0, 2));
            int ano = int.Parse(mesAno.Substring(3));
            Console.WriteLine("Nome : " + trabalho.Nome);
            Console.WriteLine("Departamento: " + trabalho.Departamento.Nome);
            Console.WriteLine("Rendimento para " + mesAno + ": " + trabalho.Rendimento(ano,mes).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
