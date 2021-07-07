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
            Console.WriteLine("git log --oneline -> mostra histórico resumido de logs ");
            Console.WriteLine("Se entrar no editor VIM ... apertar <ESC> e digitar :q! enter para sair");
            Console.WriteLine("git clean -df <enter> e git checkout -- . <enter>  -> voltar ultima versão commit: ");
            Console.WriteLine("git reset --soft HEAD~1 <enter>  -> exclui ultimo commit feito e mantem alterações anteriores ");
            Console.WriteLine("git reset --hard HEAD~1 <enter>  -> exclui ultimo commit feito e as alterações anteriores também");
            Console.WriteLine("git checkout<código do commit>  -> Vai para a versão indicada ");
            Console.WriteLine("git checkout master  -> Vai para a ultima versão branch ");
            Console.WriteLine("github.com  -> Diretório remoto para armazenar os gits locais");
            Console.WriteLine("git remote add origin https://github.com/newtonjnfontes/CursoCSharp.git -> salva endereço git remoto");
            Console.WriteLine("git remote set-url origin https://github.com/newtonjnfontes/CursoCSharp02.git -> altera endereço git remoto");
            Console.WriteLine("git push -u origin master -> envia arquivos para o github setado ( nas proximas vezes basta o git push ");
            Console.WriteLine("git clone 'https://github.com/newtonjnfontes/CursoCSharp.git' -> salva no diretorio local o git remoto");
            Console.WriteLine("git pull origin master -> atualiza o diretório local com o git remoto");

        }

    }
}

