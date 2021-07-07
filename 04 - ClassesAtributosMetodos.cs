using System;
using System.Globalization;

public class ClassesAtributosMetodos {
	public Class1()
	{
        static void Main(string[] args) // membro da classe
                                        // indica onde o programa é iniciado

        {
            // ================================================
            // Captura dados do Produto
            Console.WriteLine("---------------------------");
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            Produto p = new Produto(); // cria o objeto p derivado da classe Produto() com os campos definidos na classe
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p); // incluido ToString() no produto.cs para transformar objeto em string
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte); // valor qte que irá para a função que adiciona estoque
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            // ================================================
            // Aumentar salário de Funcionário
            Console.WriteLine("---------------------------");
            Console.WriteLine("Entre os dados do um Funcionário:");
            Funcionario func = new Funcionario(); // cria o objeto func derivado da classe Funcionario() com os campos definidos na classe
            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salario bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("Funcionário: " + func);
            Console.WriteLine();
            Console.Write("Deseja aumentar o salário em qual porcentagem? ");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentarSalario(porcent); // chama a função da classe Funcionario e adiciona percentual ao objeto func
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + func);

            // ================================================
            // Média de notas e ver se aluno foi aprovado
            Console.WriteLine("---------------------------");
            Console.WriteLine("Entre os dados de um aluno");
            Aluno aluno = new Aluno(); // cria o objeto aluno derivado da classe Aluno() com os campos definidos na classe
            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            Console.Write("Nota 01 : ");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Nota 02 : ");
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Nota 03 : ");
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("NOTA FINAL = "
            + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            if (aluno.Aprovado()) {
                Console.WriteLine("APROVADO");
            }
            else {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM "
                + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)
                + " PONTOS");
            }

            // ================================================
            // Calculo da circunferência
            Console.WriteLine("---------------------------");
            Console.WriteLine("Cálculo da Circunferência - Valores Estáticos");
            Calculadora calc = new Calculadora(); // objeto calc da classe Calculadora
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ = calc.Circunferencia(raio); // função da classe Calculadora chamada pelo objeto calc
            double volume = calc.Volume(raio);  // poderia ser também double volume = Calculadora.Volume(raio) sem o objeto calc
            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + calc.Pi.ToString("F6", CultureInfo.InvariantCulture));
        }
    }
}
