using System;

public class UsoWriteLIne {
    public Class1() {
        static void Main(string[] args) // membro da classe
                                        // indica onde o programa é iniciado
        {
            char genero = 'F'; // para string de um caracter
            int idade = 32; // para numericos
            double saldo = 10.35784; // para decimais
            String nome = "Maria"; // para string de varios caracteres
            Console.Write("Bom dia!");
            Console.WriteLine("Boa tarde!");
            Console.WriteLine("Boa noite!");
            Console.WriteLine("---------------------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4")); // aparece virgula
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture)); // aparece ponto - formatação originaria do system.globalization
            int idade1 = 32;
            double saldo1 = 10.35784;
            String nome1 = "Maria";
            // três forma de escrever com WriteLine
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome1, idade1, saldo1);
            Console.WriteLine($"{nome1} tem {idade1} anos e tem saldo igual a {saldo1:F2} reais");
            Console.WriteLine(nome1 + " tem " + idade1 + " anos e tem saldo igual a "
            + saldo1.ToString("F2", CultureInfo.InvariantCulture) + " reais");
        }
    }
}
