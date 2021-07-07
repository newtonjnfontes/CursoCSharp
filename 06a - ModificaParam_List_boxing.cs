using ConsoleApp1;
using System;  // contem funções basicas de manipulação de programa
using System.Collections.Generic; // usado para trabalho com listas



namespace ModifParametros_lista_Boxing  // daclaração de namespace desse probrama
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
            Console.WriteLine("Modificando Parametros ref e out ");
            int a = 10;
            Product.MultRef(ref a, 3); // usa ref para passar valor à classe produto e o muitiplicador 3 para o modulo Mult
            Console.WriteLine(" Ref => quanto é 10 x 3 = " + a);
            a = 50;
            Product.MultRef(ref a, 6); // usa ref para passar valor à classe produto e o muitiplicador 3 para o modulo Mult
            Console.WriteLine(" Ref => quanto é 50 x 6 = " + a);

            a = 70;
            int retorno;
            Product.MultOut(a, out retorno, 8); // usa ref para passar valor à classe produto e o muitiplicador 3 para o modulo Mult
            Console.WriteLine(" Out => quanto é 70 x 8 = " + retorno);

            Console.WriteLine("---------------------------");
            Console.WriteLine("Boxing e Unboxing - valor colocado em objeto e vice versa");

            Object objeto = retorno;
            int retornoy = (int)objeto + 5;
            Console.WriteLine("Object obj = a , que é " + retorno + " e y = obj + 5 , então y = " + retornoy);

            Console.WriteLine("---------------------------");
            Console.WriteLine("Percorrendo listas");
            string[] vect = new string[] { "Maria", "Bob", "Alex" };
            foreach (string obj in vect) { // o obj é um apelido para o vect e não precisa instanciar
                Console.WriteLine(obj);
            }
            List<string> Lista; // declaração de listas simples
            List<string> ListaInst = new List<string>(); // declaração de lista com Instanciamento e vazia
            List<string> ListaInstCont = new List<string> { "Lilian", "Romana", "Oliveira", "Fontes" }; // declaração de lista com Conteúdo


            foreach (string objLista in ListaInstCont) { // captura a lista na variáel objLista
                Console.WriteLine("Lista 02 " + objLista);
            }
            Console.WriteLine("Lista 02 Contador: " + ListaInstCont.Count);

            ListaInst.Add("Maria"); // adicionando elemento à lista
            ListaInst.Add("Alex");
            foreach (string objLista in ListaInst) { // para ler a lista
                Console.WriteLine("Lista 01 " + objLista);
            }
            Console.WriteLine("Lista 01 Contador: " + ListaInst.Count); // contador da lista
            ListaInst.Insert(2, "Márcio"); // define em que posíção o elemento vai entrar na lista com opção Insert
            Console.WriteLine("Márcio foi colocado com comando Insert após a posição 2 lista 1");
            ListaInstCont.Add("Bob");
            ListaInstCont.Add("Anna");
            ListaInstCont.Insert(2, "Marco"); // define em que posíção o elemento vai entrar na lista com opção Insert
            ListaInstCont.Insert(3, "Fernando"); // define em que posíção o elemento vai entrar na lista com opção Insert
            ListaInstCont.Insert(5, "Amália");
            Console.WriteLine("Marco foi colocado com comando Insert após a posição 2 lista 2");
            Console.WriteLine("Amália foi colocado com comando Insert após a posição 5 lista 2 ");
            Console.WriteLine("Fernando foi colocado com comando Insert após a posição 3 lista 2 ");
            foreach (string objLista in ListaInst) {
                Console.WriteLine("Lista 01 após adição " + objLista);
            }
            Console.WriteLine("Lista 01 após adição Contador: " + ListaInst.Count); // contador de lista 1

            foreach (string objLista in ListaInstCont) {
                Console.WriteLine("Lista 02 após adição " + objLista);
            }
            Console.WriteLine("Lista 02 após adição Contador : " + ListaInstCont.Count); // contador lista 2

            Console.WriteLine("Pesquisando conteudo na lista com Find ");

            string s1 = ListaInstCont.Find(x => x[0] == 'A'); // função find pegando conteudo primeira posição começando com 'A'
            Console.WriteLine("Primeiro Nome , na lista 02, começando com 'A': " + s1);
            string s2 = ListaInstCont.FindLast(x => x[0] == 'B'); // função Find pegando conteudo ultima posição começando com 'b'
            Console.WriteLine("Primeiro Nome , na lista 02, terminando com 'B': " + s2);
            int pos1 = ListaInstCont.FindIndex(x => x[0] == 'F'); // pega posição na lista do primeiro elemento começando com 'A'

            Console.WriteLine("Posição do Primeiro Nome , na lista 02, começando com 'F': " + (pos1 + 1));
            int pos2 = ListaInstCont.FindLastIndex(x => x[0] == 'F');  // pega posição do ultimo elemento começando com 'B'
            Console.WriteLine("Posição do último Nome , na lista 02, começando com 'F': " + (pos2 + 1));

            List<string> list2 = ListaInstCont.FindAll(x => x.Length == 6); // Pesquisa todos os elementos que tenham tamanho = 6
            Console.WriteLine("---------------------");
            Console.WriteLine("Mostra todos os elementos com tamanho = 6");
            foreach (string obj in list2) {
                Console.WriteLine(obj);
            }

            List<string> list3 = ListaInstCont.FindAll(x => x[0] == 'A'); // Pesquisa todos os elementos que começa com 'A'
            Console.WriteLine("---------------------");
            Console.WriteLine("Mostra todos os elementos que começa com 'A'");
            foreach (string obj in list3) {
                Console.WriteLine(obj);
            }
            ListaInstCont.Remove("Romana"); // Remove elemento da lista
            Console.WriteLine("---------------------");
            Console.WriteLine("Remove Romana da lista");
            foreach (string obj in ListaInstCont) {
                Console.WriteLine(obj);
            }
            ListaInstCont.RemoveRange(3, 2); // Remove 2 elemento a partir da posição 3
            Console.WriteLine("---------------------");
            Console.WriteLine("Remove 2 elemento a partir da posição 4 na lista 2");
            foreach (string obj in ListaInstCont) {
                Console.WriteLine(obj);
            }
            ListaInstCont.RemoveAt(2); // Remove elemento da posição 2
            Console.WriteLine("---------------------");
            Console.WriteLine("Remove elemento da posição 3 na lista 2");
            foreach (string obj in ListaInstCont) {
                Console.WriteLine(obj);
            }

            ListaInstCont.RemoveAll(x => x[0] == 'F'); // remove todo elemento que começa com 'O'
            Console.WriteLine("---------------------");
            Console.WriteLine("Remove todo elemento que começa com 'F' da lista");
            foreach (string obj in ListaInstCont) {
                Console.WriteLine(obj);
            }
        }

    }
}
