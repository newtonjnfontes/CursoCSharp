using ConsoleApp1;
using System;  // contem funções basicas de manipulação de programa
using System.Globalization;
using System.Collections.Generic; // usado para trabalho com listas



namespace Introducao_Git_GitHub // daclaração de namespace desse probrama
{
    class Program  // declaração de classe que é a unidade básica do programa
    {
        static void Main(string[] args) // membro da classe
                                        // indica onde o programa é iniciado

        {
            // ================================================
            // Modificador de parametros params, out, ref

            Console.WriteLine("---------------------------");
            Console.WriteLine("Introdução Git e GitHub ");
            Console.WriteLine("Comandos : ");
            Console.WriteLine("No diretório do projeto abrir o git bash - botão direito do mouse ");
            Console.WriteLine("git init  -> cria area no projeto ");
            Console.WriteLine("git status -> verifica arquivos para incluir na versão (em vermelho)");
            Console.WriteLine("git add .  -> coloca na lista de transferência - com git status fica verde ");
            Console.WriteLine("git commit -m 'texto da versão'  -> inclui arquivos na versão");
            Console.WriteLine("git log -> mostra histórico das versões feitas ");

        }

    }
}
