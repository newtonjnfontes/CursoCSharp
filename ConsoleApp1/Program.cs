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
            /*  Console.WriteLine("---------------------------");
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
              NivelTrabalho nivel = Enum.Parse<NivelTrabalho>(Console.ReadLine()); // armazena no nivel o valor digitado
              Console.Write("Salário Base: ");
              double salarioBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

              Departamento depto = new Departamento(deptNome); // objetos instanciados
              Trabalhador trabalho = new Trabalhador(nome, nivel, salarioBase, depto); // objetos instanciados

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
              int mes = int.Parse(mesAno.Substring(0, 2)); // para os dois primeiros caracteres do mesano e coloca como int
              int ano = int.Parse(mesAno.Substring(3)); // pega da posição 4 em diante os caracteres do mesano e coloca como int
              Console.WriteLine("Nome : " + trabalho.Nome);
              Console.WriteLine("Departamento: " + trabalho.Departamento.Nome);
              Console.WriteLine("Rendimento para " + mesAno + ": " + trabalho.Rendimento(ano,mes).ToString("F2", CultureInfo.InvariantCulture));
              */
            Console.WriteLine("---------------------------");
            Console.WriteLine("Exemplo com variavel StringBuilder ( texto modificável) ");
            Publicar p1 = new Publicar(
                      DateTime.Parse("21/06/2018 13:05:44"),
                      "Viajando  para a Espanha",
                      "Estou indo visitar um Pais encantador!",
                      12);
            Comentario c1 = new Comentario("Tenha uma boa Viagem!");
            Comentario c2 = new Comentario("Isto é muito Interessante!");

            Console.WriteLine(p1);
            Console.ReadLine();
            p1.AdicionaComentario(c1);
            p1.AdicionaComentario(c2);
            Console.ReadLine();
            Console.WriteLine(p1);
            Console.ReadLine();
            Comentario c3 = new Comentario("Boa Noite");
            Comentario c4 = new Comentario("A Paz esteja convosco");
            Publicar p2 = new Publicar(
                    DateTime.Parse("28/07/2018 23:14:19"),
                    "Boa Noite Pessoal",
                    "Vejo Vocês amanhã!",
                    5);
            p2.AdicionaComentario(c3);
            p2.AdicionaComentario(c4);
            Console.ReadLine();
            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
