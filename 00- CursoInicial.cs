// Debug -> marca a linha e aperta F9 ou vai no menu Depurar- F5 inicia debug - avança com F10
// https://www.urionlinejudge.com.br/judge/pt/problems/index/1 - para testes
// https://github.com/acenelio/curso-logica-de-programacao-csharp/blob/master/uri1006/uri1006/Program.cs // pgms resulvidos
using System;
// using System.Globalization;
// ctrl k d -> identa tudo

namespace uri1001  // soma de dois numeros

{
    class Program {
        static void Main(string[] args) {
            int A, B, X;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            X = A + B;
            Console.WriteLine("X = " + X);
        }
    }
}
namespace uri1002  // area de uma circunferência conforme o raio R
{
    class Program {
        public static void Main(string[] args) {

            double R, A, pi = 3.14159;

            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            A = pi * R * R;

            Console.WriteLine("A=" + A.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
namespace uri1003 // soma simples
{
    class Program {
        static void Main(string[] args) {

            int A, B, soma;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            soma = A + B;

            Console.WriteLine("SOMA = " + soma);
        }
    }
}
namespace uri1004 // produto simples
{
    class Program {
        static void Main(string[] args) {

            int x, y, prod;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            prod = x * y;
            Console.WriteLine("PROD = " + prod);
        }
    }
}
namespace uri1005 // media com peso
{
    class Program {
        static void Main(string[] args) {

            double A, B, media;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = ((A * 3.5) + (B * 7.5)) / 11;

            Console.WriteLine("MEDIA = " + media.ToString("F5", CultureInfo.InvariantCulture));
        }
    }
}
namespace uri1006 // media de 3 variaveis com peso
{
    class Program {
        static void Main(string[] args) {

            double A, B, C, media;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (A * 2.0 + B * 3.0 + C * 5) / 10.0;

            Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
namespace AreaPedimetroDiagonal {
    class Program {
        static void Main(string[] args) {
            double b, a, area, perimetro, diagonal;
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            area = b * a;
            perimetro = 2 * (b + a);
            // pow - potencia , sqrt - raiz quadrada
            diagonal = Math.Sqrt(Math.Pow(b, 2.0) + Math.Pow(a, 2.0));
            Console.WriteLine("AREA = " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}

namespace TextoNumeroMediaIdade {
    class Program {
        static void Main(string[] args) {
            string nome1, nome2;
            int idade1, idade2;
            double media;
            string[] vet;
            vet = Console.ReadLine().Split(' ');// divide linha em dois campos separados por espaço
            nome1 = vet[0];
            idade1 = int.Parse(vet[1]);
            vet = Console.ReadLine().Split(' ');
            nome2 = vet[0];
            idade2 = int.Parse(vet[1]);
            // colocado a baixo casting double para obter decimal dos int e 2.0 como double
            media = (double)(idade1 + idade2) / 2.0;
            Console.WriteLine("A idade média de " + nome1 + " e " + nome2 + " é de "
            + media.ToString("F1", CultureInfo.InvariantCulture) + " anos"); // f1 com uma casa decimal e CultureInfo.Inv para colocar ponto
            Console.ReadLine();
        }
    }
}
namespace ConsoleAppNew {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Olá Mundo!"); // com salto de linha
            Console.Write(" Sem covid é melhor!"); // sem salto de linha
            Console.WriteLine(" - final "); // sem salto de linha
            Console.WriteLine("Saltando linha!");
            double x = 10.35784;
            int y = 32;
            float f = 6f; // variavel float colocar f no final
            double zz = 2.0; // variavel double indicar .0 no final se não tiver decimal
            string j = "Maria";
            char w = 'F';
            Console.Write("variavel x : ");
            Console.WriteLine(x);
            Console.Write("variavel y : ");
            Console.WriteLine(y);
            Console.Write("com função (x.ToString('F2') : ");
            Console.WriteLine(x.ToString("F2")); // ToString("F2") coloca duas casas decimais 
            Console.Write("com função CultureInfo.InvariantCulture para ponto no decimal : ");
            // necessário no inicio do arquiv using System.Globalization;
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture)); // troca por ponto 
            Console.Write("Produto de x * y ( com duas casas decimais e com ponto : ");
            double z = x * y;
            Console.WriteLine(z.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Cálculo da área de um trapezio e um triangulo- ");
            double baseMaior, baseMenor, altura, area, area1, area2; // pode definir varias variáveis do mesmo lipo em uma linha
            Console.Write("Entre com a Base Menor: ");
            baseMenor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // captura a base Menor com .ReadLine()
            Console.Write("Entre com a base Maior: ");
            baseMaior = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com a Altura: ");
            altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            // calculo da áres base (b + B) / 2.0 * a;
            area = (baseMenor + baseMaior) / 2.0;
            area2 = (baseMaior * altura) / 2.0;
            area1 = area * altura;
            Console.WriteLine("Área do triangulo na base maior ( B * h) / 2  = " + area2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Área1 do trapézio ( b + B) / 2 * h = " + area1.ToString("F2", CultureInfo.InvariantCulture));
            int aa;
            aa = (int)area1; // fazemos o casting para avisar que queremos só o inteiro da area do trapézio
            Console.WriteLine("Área1 do trapézio com castinhg : " + aa);
            Console.WriteLine("Trabalhando com Entradas .ReadLIne que trazem string e uso casting para converter em int  ");
            Console.Write("Entre com um número: ");

            int numero = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // captura a base Menor com .ReadLine()
            Console.Write("Entre com uma letra: ");
            char letra = char.Parse(Console.ReadLine());
            Console.WriteLine("Você digitou : " + numero + " e " + letra);
        }
    }
}
namespace CapturaLinhaComPontoParse {
    class Program {
        static void Main(string[] args) {
            Console.Write("Entre com um número: ");
            int n1 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // captura a base Menor com .ReadLine()
            Console.Write("Entre com uma letra: ");
            char ch = char.Parse(Console.ReadLine());
            Console.Write("Entre com um valor decimal: ");
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Você digitou : " + n1 + " , " + ch + " e " + n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.Write("Entre com Nome sexo idade e altura ( separado por espaço) : ");
            string[] vet = Console.ReadLine().Split(' ');// divide linha em alguns campos separados por espaço
            string nome = vet[0]; // captura o primeiro vetor
            char sexo = char.Parse(vet[1]); // captura o primeiro vetor
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);
            Console.WriteLine("Você digitou : " + nome + " , " + sexo + " , " + idade + " e " + altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
namespace funcMatematica {
    class Program {
        static void Main(string[] args) {

            Console.Write("Entre com um número x : ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // captura a base Menor com .ReadLine()
            Console.Write("Entre com um número y : ");
            double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // captura a base Menor com .ReadLine()
            Console.Write("Entre com um número z : ");
            double z = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // captura a base Menor com .ReadLine()
            double A, B, C;
            A = Math.Sqrt(x); // recebe a raiz quadrada de x
            B = Math.Sqrt(y);
            C = Math.Sqrt(z);

            string AA = A.ToString("F2", CultureInfo.InvariantCulture);
            String BB = B.ToString("F2", CultureInfo.InvariantCulture);
            string CC = C.ToString("F2", CultureInfo.InvariantCulture);
            Console.WriteLine("Raiz quadrada de " + x + " = " + AA);
            Console.WriteLine("Raiz quadrada de " + y + " = " + BB);
            Console.WriteLine("Raiz quadrada de " + z + " = " + CC);
            double D, E, F;
            D = Math.Pow(x, y); // potencia de x elevado a y
            E = Math.Pow(x, 2.0);
            F = Math.Pow(y, z);
            Console.WriteLine(x + " elevado a " + y + " = " + D);
            Console.WriteLine(x + " elevado ao quadrado = " + E);
            Console.WriteLine(y + " elevado a " + z + " = " + F);
            A = Math.Abs(A);  // recebe valor absoluto sem o toString("F2
            B = Math.Abs(B);
            C = Math.Abs(C);
            Console.WriteLine("Valor absoluto de " + AA + " = " + A);
            Console.WriteLine("Valor absoluto de " + BB + " = " + B);
            Console.WriteLine("Valor absoluto de " + CC + " = " + C);
        }
    }
}
namespace funcMatGeom_LinhaComposta_Media {
    class Program {
        static void Main(string[] args) {
            double baseX, alturaY, area, perimetro, diagonal;
            Console.WriteLine("Caldulo de Área,Perimetro e Diagonal de uma figura geométrica");
            Console.Write("Entre com o valor da base : ");
            baseX = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // captura a base com .ReadLine()
            Console.Write("Entre com o valor da altura : ");
            alturaY = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // captura a altura com .ReadLine()

            area = baseX * alturaY; // calculo da área
            perimetro = 2 * (baseX + alturaY);// calculo do perímetro
            // Math.Sqrt() -> rais quadrada    -> Math.Pow() -> potenciação
            diagonal = Math.Sqrt(Math.Pow(baseX, 2.0) + Math.Pow(alturaY, 2.0));// calculo da diagonal
            Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("Caldulo da Média de idades entre alunos");
            string nome1, nome2;
            int idade1, idade2;
            double media;
            string[] vet;
            Console.Write("Entre com nome e idade do primeiro aluno : ");
            vet = Console.ReadLine().Split(' '); // lê dados do aluno 1
            nome1 = vet[0];
            idade1 = int.Parse(vet[1]);
            Console.Write("Entre com nome e idade do segundo aluno : ");
            vet = Console.ReadLine().Split(' ');
            nome2 = vet[0];
            idade2 = int.Parse(vet[1]);
            media = (double)(idade1 + idade2) / 2.0; // colocado o double e 2.0 para obter casas decimais
            Console.WriteLine("A idade média de " + nome1 + " e " + nome2 + " é de "
            + media.ToString("F2", CultureInfo.InvariantCulture) + " anos");

            Console.WriteLine("Converter um número em hh:mm:ss");
            int N, resto, horas, minutos, segundos;
            Console.Write("Entre com um número qualquer : ");
            N = int.Parse(Console.ReadLine());
            horas = N / 3600; // para achar a hora equivalente
            resto = N % 3600;  // operador MOD % para achar o resto da divisão da hora 
            minutos = resto / 60; // para calcular o minuto com base no resto da hora
            segundos = resto % 60; // para achar os segundos obtidos do resto da divisão do minuto
            Console.WriteLine("horário obtido = " + horas + ":" + minutos + ":" + segundos);
        }
    }
}
namespace uri1021 // NOTAS E MOEDAS
{
    class Program {
        static void Main(string[] args) {
            double N;
            int quociente, resto, nota, moeda;

            N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Vamos multiplicar N por 100 e forçar a conversão para int.
            // Desse modo, por exemplo, 576.73 vai se tornar 57673

            // Vamos tambem somar 0.5 antes de converter, para assegurar 
            // que o numero seja devidamente arredondado, pois o tipo double
            // as vezes da problema de arredondamento (por exemplo: se digitarmos
            // 576.81 e multiplicarmos por 100, o resultado sera 57680.99999999,
            // dai o casting resultaria em 57680 e nao 57681 como desejado)

            resto = (int)(N * 100.0 + 0.5);

            Console.WriteLine("NOTAS:");

            // como multiplicamos o valor por 100 acima, o valor de cada nota
            // também deverá ser multiplicado por 100 a seguir

            nota = 100;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 50;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 20;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 10;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 5;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            nota = 2;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ".00");
            resto = resto % (nota * 100);

            Console.WriteLine("MOEDAS:");

            // o valor de cada moeda deverá ser representado em centavos

            moeda = 100;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 1.00");
            resto = resto % moeda;

            moeda = 50;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.50");
            resto = resto % moeda;

            moeda = 25;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.25");
            resto = resto % moeda;

            moeda = 10;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.10");
            resto = resto % moeda;

            moeda = 5;
            quociente = resto / moeda;
            Console.WriteLine(quociente + " moeda(s) de R$ 0.05");
            resto = resto % moeda;

            Console.WriteLine(resto + " moeda(s) de R$ 0.01");
        }
    }
}
namespace ExpressoesComparativasLogicas {   //Comparativos :  maior > , < menor , >= maior ou igual , <= menor ou igual , == igual , != diferente
    //Lógicos : && E, || OU , ! NÃO
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Expressões Condicionais e lógicas");
            Console.Write("Entre com as Horas atuais : ");
            int horas;
            horas = int.Parse(Console.ReadLine()); // captura a hora atual com .ReadLine()
            if (horas < 12) { // logica com comparação
                Console.WriteLine("Bom dia!");
            }
            else // se não
            {
                if (horas < 18) { // se nao se
                    Console.WriteLine("Boa tarde!");
                }
                else {
                    Console.WriteLine("Boa Noite!");
                }
            }

            Console.WriteLine("Expressões com media de notas");

            Console.Write("Entre com nota 01 : ");
            double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // captura a nota1 com .ReadLine()
            Console.Write("Entre com nota 02 : : ");
            double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // captura a nota2 com .ReadLine()
            double soma = nota1 + nota2;
            Console.WriteLine("Nota Final é " + soma.ToString("F2", CultureInfo.InvariantCulture));
            if (soma > 59) { // logica com comparação
                Console.WriteLine("APROVADO!");
            }
            else // se não
            {
                Console.WriteLine("REPROVADO!");
            }

            Console.WriteLine("Expressões com Fórmula de Bhaskara - Equação do segundo grau ax2 + bx + c = 0");
            Console.WriteLine("a, b e c são os coeficientes da equação (pontos flutuantes)");
            Console.WriteLine("Fórmula x = -b + (e) - raiz de Delta / 2a  -> Delta = b2 - 4ac ");
            Console.WriteLine("Delta não pode ser negativo e a não pode ser 0");
            double a1, b1, c1, delta, x1, x2;
            // string[] vet = Console.ReadLine().Split(' ');  -> se fosse na mesma linha a entrada dos coeficientes
            Console.Write("Entre com o coeficiente a : ");
            a1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // captura coeficiente a1 com .ReadLine()
            // a1 = double.Parse(vet[0], CultureInfo.InvariantCulture); se fosse leitura na mesma linha
            Console.Write("Entre com o coeficiente b : ");
            b1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // captura coeficiente b1 com .ReadLine()
            // b1 = double.Parse(vet[1], CultureInfo.InvariantCulture); se fosse leitura na mesma linha
            Console.Write("Entre com o coeficiente c : ");
            c1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // captura coeficiente c1 com .ReadLine()
            // c1 = double.Parse(vet[2], CultureInfo.InvariantCulture); se fosse leitura na mesma linha

            delta = Math.Pow(b1, 2.0) - 4 * a1 * c1;  // delta = b2 - 4ac
            Console.WriteLine("Delta = " + delta);
            if (a1 == 0 || delta < 0.0) { // logica com comparação
                Console.WriteLine("Impossível Calcular!");
                Console.WriteLine("Delta não pode ser menor que 0 e coeficiente a não pode ser 0");
            }
            else // se não
            {
                x1 = (-b1 + Math.Sqrt(delta)) / (2.0 * a1);
                x2 = (-b1 - Math.Sqrt(delta)) / (2.0 * a1);
                Console.WriteLine("Variável x1 =  " + x1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("Variável x2 =  " + x2.ToString("F5", CultureInfo.InvariantCulture));
            }

            Console.WriteLine("Definir qual menor número");
            int num1, num2, num3;
            Console.Write("Entre com os três números (separados por espaço) : ");
            string[] vet = Console.ReadLine().Split(' ');  //Leitura na mesma linha com espaço em branco 
            num1 = int.Parse(vet[0]); // vetor com leitura na mesma linha
            num2 = int.Parse(vet[1]); // vetor com leitura na mesma linha
            num3 = int.Parse(vet[2]); // vetor com leitura na mesma linha
            if (num1 < num2 && num1 < num3) {
                Console.WriteLine("Menor múmero é : " + num1);
            }
            else {
                if (num2 < num3) {
                    Console.WriteLine("Menor múmero é : " + num2);
                }
                else {
                    Console.WriteLine("Menor múmero é : " + num3);
                }
            }
            // ctrl k d -> identa tudo
            Console.WriteLine("Conta até 100 min paga R$ 50,00 . O que passar, acresce R$ 2,00 o minuto");
            int minuto1;
            double conta;
            conta = 50.0;
            Console.Write("Informe o valor da conta: ");
            minuto1 = int.Parse(Console.ReadLine());
            if (minuto1 > 100) {
                conta = conta + (minuto1 - 100) * 2.0;
                // conta += (minuto1 - 100) * 2.0;  -> é a mesma coisa simplificado
                // a += b -> a = a + b  ,  a -= b -> a = a - b , a *= b -> a = a * b ,  a /= b -> a = a / b
                Console.WriteLine("Valor a pagar R$ " + conta.ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.WriteLine("Usando switch-case -> Digitar o número da semana de 1 a 7 :");
            int dia;
            string diasemana;
            Console.Write("Informe o número da semana: ");
            dia = int.Parse(Console.ReadLine());
            switch (dia) {
                case 1:
                    diasemana = "domingo";
                    break;
                case 2:
                    diasemana = "segunda";
                    break;
                case 3:
                    diasemana = "terça";
                    break;
                case 4:
                    diasemana = "quarta";
                    break;
                case 5:
                    diasemana = "quinta";
                    break;
                case 6:
                    diasemana = "sexta";
                    break;
                case 7:
                    diasemana = "sabado";
                    break;
                // se nenhum dos casos acima der certo
                default:
                    diasemana = "valor inválido";
                    break;
            }
            Console.WriteLine("Dia da semana : " + diasemana);
        }
    }
}
namespace ConsoleWrile {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Usando while com switch case - usado quando não sabe a qtde do loop ");
            int numero, soma;
            string diasemana;

            // Console.Write("Informe um número : ");
            // numero = int.Parse(Console.ReadLine());
            numero = 1; soma = 0; // só para iniciar a comparação
            while (numero != 0) {
                Console.Write("Informe um número : ");
                numero = int.Parse(Console.ReadLine());
                soma = soma + numero;
                switch (numero) {
                    case 1:
                        diasemana = "domingo";
                        break;
                    case 2:
                        diasemana = "segunda";
                        break;
                    case 3:
                        diasemana = "terça";
                        break;
                    case 4:
                        diasemana = "quarta";
                        break;
                    case 5:
                        diasemana = "quinta";
                        break;
                    case 6:
                        diasemana = "sexta";
                        break;
                    case 7:
                        diasemana = "sabado";
                        break;
                    // se nenhum dos casos acima der certo
                    default:
                        diasemana = "valor inválido";
                        break;
                }
                Console.WriteLine("Dia da semana : " + diasemana + " soma = " + soma);
            }
            Console.WriteLine("Usando while para leitura de dois números ");
            int x, y, soma1;


            x = 1; y = 2; soma = 0; // só para iniciar a comparação
            while (x != y) {
                Console.Write("Informe dois números separados por espaço : ");
                string[] vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);
                if (x < y) {
                    Console.WriteLine(" Crescente");
                }
                else {
                    Console.WriteLine(" Decrescente");
                }
            }
            Console.WriteLine("Usando while para média de idades ");
            double idade, soma2, media;
            int cont;
            idade = 1.0; soma2 = 0.0; cont = 0;// só para iniciar a comparação
            while (idade >= 0) {
                Console.Write("Informe a idade : ");
                idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (idade > 0) {
                    soma2 = soma2 + idade;
                    cont = cont + 1;
                }


            }
            if (cont == 0) {
                Console.WriteLine("Impossível Calcular a média");
            }
            else {
                media = soma2 / cont;
                Console.WriteLine("Média das idades = " + media.ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.WriteLine("Usando while para validar preenchimento de campo ");
            double nota1, nota2, medianota;
            int contnota1, contnota2;
            nota1 = 11.0; contnota1 = 0;// só para iniciar a comparação
            while ((nota1 < 0.0 || nota1 > 10.0)) {
                if (contnota1 > 0) {
                    Console.WriteLine("nota invalida");
                }
                Console.Write("Informe a nota01 : ");
                nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                contnota1 = contnota1 + 1;
            }
            nota2 = 11.0; contnota2 = 0;// só para iniciar a comparação
            while ((nota2 < 0.0 || nota2 > 10.0)) {
                if (contnota2 > 0) {
                    Console.WriteLine("nota invalida");
                }
                Console.Write("Informe a nota2 : ");
                nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                contnota2 = contnota2 + 1;
            }
            medianota = (nota1 + nota2) / 2.0;
            Console.WriteLine("media = " + medianota.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Tentativas nota 1 = " + contnota1);
            Console.WriteLine("Tentativas nota 2 = " + contnota2);
        }
    }
}
namespace ConsoleWrile_ForPara {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Usando while imprimir a soma dos 5 numeros pares seguintes a partir de um digitado");
            Console.Write("Informe um número : ");
            int x = int.Parse(Console.ReadLine());

            while (x != 0) {

                // se for impar, some mais 1 para transforma-lo em par
                if (x % 2 != 0) {
                    x = x + 1;
                }

                // expressao simplificada: 5 * x + 20
                int soma = x + x + 2 + x + 4 + x + 6 + x + 8;
                Console.WriteLine("soma = " + soma);
                Console.Write("Informe um número : ");
                x = int.Parse(Console.ReadLine());

            }
            int N1, xN1, soma1, cont;
            Console.WriteLine("Usando Estrutura repetitiva com PARA - for");
            Console.Write("Informe um número de repetições : ");
            N1 = int.Parse(Console.ReadLine());
            soma1 = 0; cont = 0; // inicializando variaveis
            for (int i = 1; i <= N1; i++)  // inicio; condição; incremento
            {
                cont = cont + 1;
                Console.Write("Informe um número " + cont + " : ");
                xN1 = int.Parse(Console.ReadLine());

                soma1 = soma1 + xN1;
            }
            Console.WriteLine("soma = " + soma1);
            soma1 = 0;
            Console.WriteLine("Usando for decrescente");
            for (int i = 4; i >= 0; i--)  // inicio; condição; incremento
            {
                cont = cont + 1;
                Console.WriteLine("Valor de i = " + i + " : ");

                soma1 = soma1 + i;
            }
            Console.WriteLine("soma = " + soma1);
            Console.WriteLine("Usando extrutura para e criando tabuada");
            Console.Write("informe um número para calculo da tabuada : ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++) {
                int result = i * num;
                Console.WriteLine(i + " x " + num + " = " + result);
            }
            Console.WriteLine("Usando for para soma de números impares num intervalo");
            Console.Write("informe um número 01 : ");
            int xI = int.Parse(Console.ReadLine());
            Console.Write("informe um número 02 : ");
            int yI = int.Parse(Console.ReadLine());

            int min, max;
            if (xI < yI) // para garantir que o menor valor vem primeiro
            {
                min = xI;
                max = yI;
            }
            else {
                min = yI;
                max = xI;
            }

            int somaI = 0;
            for (int i = min + 1; i < max; i++) {
                if (i % 2 != 0) {
                    somaI = somaI + i;
                }
            }

            Console.WriteLine(" soma de impares = " + somaI);
        }
    }
}
namespace EstruturaFacaEnquanto {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Usando while imprimir a soma dos 5 numeros pares seguintes a partir de um digitado");
            Console.Write("Informe um número : ");
            int x = int.Parse(Console.ReadLine());

            while (x != 0) {

                // se for impar, some mais 1 para transforma-lo em par
                if (x % 2 != 0) {
                    x = x + 1;
                }

                // expressao simplificada: 5 * x + 20
                int soma = x + x + 2 + x + 4 + x + 6 + x + 8;
                Console.WriteLine("soma = " + soma);
                Console.Write("Informe um número : ");
                x = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Usando Estrutura faça com while - conversão de temperaturas");

            double Cel, Far;
            char repetir = 's'; // para s ou n  - um caracter só forçando inicio = 's'
            while (repetir == 's') {
                Console.Write("Informe a temperatura em Ceucius : ");
                Cel = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Far = 9.0 * Cel / 5.0 + 32; // Formula do Fahrenheit
                Console.WriteLine("Equivalente em Fahrenheit : " + Far.ToString("F1", CultureInfo.InvariantCulture));
                Console.Write("Deseja Repetir (s/n) ? : ");
                repetir = char.Parse(Console.ReadLine());
            }
            Console.WriteLine("Usando Estrutura faça enquano (DO-WHILE) - conversão de temperaturas");

            double Cel2, Far2, kel2;
            char repetir2; // para s ou n  - um caracter só sem inicializar

            do {
                Console.Write("Informe a temperatura em Ceucius : ");
                Cel2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Far2 = 9.0 * Cel2 / 5.0 + 32; // Formula do Fahrenheit
                kel2 = Cel2 + 273;
                Console.WriteLine("Equivalente em Fahrenheit : " + Far2.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Equivalente em Kelvin : " + kel2.ToString("F1", CultureInfo.InvariantCulture));
                Console.Write("Deseja Repetir (s/n) ? : ");
                repetir = char.Parse(Console.ReadLine());
            } while (repetir == 's');
            Console.WriteLine("Usando for para ver se numero é primo");
            Console.Write("Qtde de números para testar : ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++) // ler até o numero digitado
            {
                Console.Write("Digite um número : ");
                int x = int.Parse(Console.ReadLine());
                int metade = x / 2;

                bool primo = true;

                for (int j = 2; j <= metade; j++) {
                    if (x % j == 0) {
                        primo = false;
                        break;
                    }
                }

                if (primo) {
                    Console.WriteLine(x + " eh primo");
                }
                else {
                    Console.WriteLine(x + " nao eh primo");
                }
            }
        }
    }
}
namespace Vetores_Arranjos {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Usando for para alimentar Vetor");
            int N;
            double[] vet; // declara vetor
            Console.Write("Qtde de campos para incluir no vetor : ");
            N = int.Parse(Console.ReadLine());
            vet = new double[N]; // instancia qtde de vetores começando do 0
            for (int i = 0; i < N; i++) {
                Console.Write("Informe o valor do campo " + i + " : ");
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            for (int i = 0; i < N; i++) {
                Console.WriteLine("Campos digitados são Campo " + i + " = " + vet[i].ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.WriteLine("Usando for e vetores para selecionar números negativos de uma lista");
            int N1;
            int[] vet1; // declara vetor
            Console.Write("Qtde de números para pesquisa : ");
            N1 = int.Parse(Console.ReadLine());
            vet1 = new int[N1]; // define quantos números serão armazenados no vetor
            Console.Write("informe alguns números separados por espaço : ");
            string[] num = Console.ReadLine().Split(' ');
            for (int i = 0; i < N1; i++) {
                vet1[i] = int.Parse(num[i]);
            }
            for (int i = 0; i < N1; i++) {
                if (vet1[i] < 0) {
                    Console.Write("  " + vet1[i]);
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Varre vetores pega o somatório e média");
            int N2;
            double[] vet2; // declara vetor
            Console.Write("Qtde de números para pesquisa : ");
            N2 = int.Parse(Console.ReadLine());
            vet2 = new double[N2]; // define quantos números serão armazenados no vetor
            Console.Write("informe alguns números separados por espaço : ");
            string[] num2 = Console.ReadLine().Split(' ');
            for (int i = 0; i < N2; i++) {
                vet2[i] = double.Parse(num2[i], CultureInfo.InvariantCulture);
            }
            double soma2 = 0.0;
            for (int i = 0; i < N2; i++) {
                Console.Write("  " + vet2[i].ToString("F1", CultureInfo.InvariantCulture));
                soma2 = soma2 + vet2[i];
            }
            double media2 = soma2 / N2;
            Console.WriteLine("");
            Console.WriteLine("somatório : " + soma2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("média : " + media2.ToString("F2", CultureInfo.InvariantCulture));
            // - novo exercício
            Console.WriteLine("Varre vetores pega pessoas menor de idade");
            int N3;
            Console.Write("Qtde de pessoas para Pesquisa : ");
            N3 = int.Parse(Console.ReadLine());
            string[] nomes = new string[N3];
            int[] idades = new int[N3];
            double[] alturas = new double[N3];
            double soma3 = 0.0;
            for (int i = 0; i < N3; i++) {
                Console.Write("informe Pessoa " + (i + 1) + " com nome, idade e altura : ");
                string[] linha = Console.ReadLine().Split(' ');
                nomes[i] = linha[0];
                idades[i] = int.Parse(linha[1]);
                alturas[i] = double.Parse(linha[2], CultureInfo.InvariantCulture);
                soma3 = soma3 + alturas[i];
            }
            double media3 = soma3 / N3;
            Console.WriteLine("Altura média é de : " + media3.ToString("F2", CultureInfo.InvariantCulture));
            int cont = 0;
            // calculo da aporcentagem de pessoas de menor
            for (int i = 0; i < N3; i++) {
                if (idades[i] < 18) {
                    cont++;   // é como se fosse cont = cont + 1
                }
            }
            double porcent = (double)cont / N3 * 100.0;
            Console.WriteLine("Pessoas com menos de 18 anos: " +
                porcent.ToString("F2", CultureInfo.InvariantCulture) + "%");
            // - novo exercício com foreach - quando precisa percorer o array todo
            Console.WriteLine("Varre vetores pega pessoas menor de idade com Foreach");
            int N4;
            Console.Write("Qtde de pessoas para Pesquisa : ");
            N4 = int.Parse(Console.ReadLine());
            string[] nomes2 = new string[N3];
            Console.WriteLine("");
            for (int i = 0; i < N4; i++) {
                Console.Write("informe Pessoa " + (i + 1) + " com nome, idade e altura : ");

                nomes2[i] = Console.ReadLine();

            }
            Console.WriteLine("Nomes Lidos:");

            // trocado pelo foreach
            //for (int i = 0; i < N4; i++)
            //{
            //    Console.WriteLine("Nome : " + nomes2[i]);
            //}
            foreach (string elemento in nomes2) // usa string porque o vetor é um string
            {
                Console.WriteLine("Nome : " + elemento);
            }
        }
    }
}
namespace Matrizes {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Usando Matrizes");
            int N, M;
            int[,] mat; // declara vetor de duas dimensoes com a virgula
            Console.Write("informe qtde de linha e Coluna da matriz , separado por espaço : ");
            string[] linha = Console.ReadLine().Split(' ');
            M = int.Parse(linha[0]);
            N = int.Parse(linha[1]);
            mat = new int[M, N]; // cria matriz com linhas e colunas definidas
            for (int i = 0; i < M; i++) {
                Console.Write("Informe os valores da linha " + i + ", separado por espaço : ");
                linha = Console.ReadLine().Split(' ');

                for (int j = 0; j < N; j++) {
                    mat[i, j] = int.Parse(linha[j]);
                }
            }
            for (int i = 0; i < M; i++) {
                int soma = 0;

                for (int j = 0; j < N; j++) {
                    soma = soma + mat[i, j];
                }
                Console.WriteLine("Soma da linha " + i + " : " + soma);
            }

        }
    }
}

