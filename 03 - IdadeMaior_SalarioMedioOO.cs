﻿using System;

public class IdadeMaior_SalarioMedioOO
{
	public Class1()
	{
        static void Main(string[] args) // membro da classe
                                        // indica onde o programa é iniciado

        {
            // ================================================
            // Salário Médio
            Console.WriteLine("---------------------------");

            Pessoa p1 = new Pessoa(); // Criada classe Pessoa e instanciada com tipo de variável
            Pessoa p2 = new Pessoa();
            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());
            if (p1.Idade > p2.Idade) {
                Console.WriteLine("Pessoa mais velha: " + p1.Nome);
            }
            else {
                Console.WriteLine("Pessoa mais velha: " + p2.Nome);
            }
            // ================================================
            // Salário Médio
            Console.WriteLine("---------------------------");

            Funcionario f1 = new Funcionario(); // Criada classe Funcionario e instanciada com tipo de variável
            Funcionario f2 = new Funcionario();
            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double media = (f1.Salario + f2.Salario) / 2.0;
            Console.WriteLine("Salário médio = " + media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
