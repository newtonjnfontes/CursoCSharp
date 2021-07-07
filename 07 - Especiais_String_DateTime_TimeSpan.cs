using ConsoleApp1;
using System;  // contem funções basicas de manipulação de programa
using System.Globalization;
using System.Collections.Generic; // usado para trabalho com listas



namespace Especiais_String_DateTime_TimeSpan // daclaração de namespace desse probrama
{
    class Program  // declaração de classe que é a unidade básica do programa
    {
        static void Main(string[] args) // membro da classe
                                        // indica onde o programa é iniciado

        {
            // ================================================
            // Modificador de parametros params, out, ref

            Console.WriteLine("---------------------------");
            Console.WriteLine("Topicos Especiais - Palavra Var ");
            var x1 = 10; // como INT - com var é inferido à variavel o seu tipo conforme a atribuição
            var y = 20.0;  // como DOUBLE - com var é inferido à variavel o seu tipo conforme a atribuição
            var z = "Maria"; // como STRING - com var é inferido à variavel o seu tipo conforme a atribuição
            Console.WriteLine(x1);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine("---------------------------");
            Console.WriteLine("Topicos Especiais - Switck-case ");
            Console.Write("Informe um número correspondente ao dia da semana : ");
            int x = int.Parse(Console.ReadLine());
            string day;
            switch (x) {
                case 1:
                    day = "Domingo";
                    break;
                case 2:
                    day = "Segunda";
                    break;
                case 3:
                    day = "Terça";
                    break;
                case 4:
                    day = "Quarta";
                    break;
                case 5:
                    day = "Quinta";
                    break;
                case 6:
                    day = "Sexta";
                    break;
                case 7:
                    day = "Sabado";
                    break;
                default:
                    day = "Valor inválido";
                    break;
            }
            Console.WriteLine("Dia da Semana: " + day);
            Console.WriteLine("---------------------------");
            Console.WriteLine("Topicos Especiais - Condicional Ternária ");
            Console.WriteLine("(condição) ? valor_se_verdadeiro : valor_se_falso ");
            Console.Write("Exemplo : ( 2 > 4 ) ? 50 : 80  -> resultado = ");
            int n1 = (2 > 4) ? 50 : 80;
            Console.WriteLine(n1);
            Console.Write("Exemplo : ( 2 < 4 ) ? 50 : 80  -> resultado = ");
            int n2 = (2 < 4) ? 50 : 80;
            Console.WriteLine(n2);
            Console.Write("Informe preço do produto : ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;
            Console.WriteLine("Preço com Desconto : " + (preco - desconto).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("---------------------------");
            Console.WriteLine("Topicos Especiais - Funções para String ");
            string original = "abcde FGHIJ ABC abc DEFG ";
            string s1 = original.ToUpper(); // coloca todo o string em maiusculo
            string s2 = original.ToLower(); // coloca todo o string em minusculo
            string s3 = original.Trim(); // tira espaços em branco no inicio e no final da string se tiver
            int n11 = original.IndexOf("bc"); // onde começa o primeiro substring
            int n12 = original.LastIndexOf("bc"); // onde começa o último substring
            string s4 = original.Substring(3); // pega o substring do caracter 4 até o final
            string s5 = original.Substring(3, 5);// pega o substring do caracter 4 até mais 5 caracteres
            string s6 = original.Replace('a', 'x'); // troca todo caracter a por x no string
            string s7 = original.Replace("abc", "xy");// troca todo caracter abc por xy no string
            bool b1 = String.IsNullOrEmpty(original); // testa se a variável e nula ou vazia
            bool b2 = String.IsNullOrWhiteSpace(original);// testa se a variável está só com espaço em branco
            Console.WriteLine("Original     : (" + original + ")");
            Console.WriteLine("ToUpper      : (" + s1 + ")");
            Console.WriteLine("ToLower      : (" + s2 + ")");
            Console.WriteLine("Trim         : (" + s3 + ")");
            Console.WriteLine("IndexOf('bc'): " + n11);
            Console.WriteLine("LastIndexOf('bc'): " + n12);
            Console.WriteLine("Substring(3) : (" + s4 + ")");
            Console.WriteLine("Substring(3, 5): (" + s5 + ")");
            Console.WriteLine("Replace('a', 'x'): (" + s6 + ")");
            Console.WriteLine("Replace('abc', 'xy'): (" + s7 + ")");
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);
            string str = "1234";
            int xx = int.Parse(str); // converte string para inteiro
            Console.WriteLine("converte a string " + str + "para : inteiro (int.Parse) : " + xx);
            int xy = Convert.ToInt32(str); // converte string para inteiro
            Console.WriteLine("converte a string " + str + "para : inteiro (Convert.ToInt32) : " + xy);
            string str1 = x.ToString();
            Console.WriteLine("Original de x :  " + x);
            Console.WriteLine("x.ToString() :  " + str1); // valor original
            string str2 = x.ToString("C");
            Console.WriteLine("x.ToString('C') :  " + str2); // valor em reais com centavos
            string str3 = x.ToString("C3");
            Console.WriteLine("x.ToString('C3') :  " + str3); // valor em reais com 3 casas decimais
            string str4 = x.ToString("F2");
            Console.WriteLine("x.ToString('FC') :  " + str4);// duas casas decimais sem reais
            Console.WriteLine("---------------------------");
            Console.WriteLine("Topicos Especiais - DateTime ");
            DateTime d1 = DateTime.Now; // Variavel do tipo DateTime pegando o instante atual ( precisa do using System )
            DateTime d2 = DateTime.UtcNow; // Builder
            DateTime d3 = DateTime.Today; // Builder
            Console.WriteLine("DataHora atual Builder Now: " + d1);
            Console.WriteLine("DataHora Builder UtcNow : " + d2); // horatio de Greenwich
            Console.WriteLine("DataHora Builder Today: " + d3); // dia e hora a meia noite
            Console.WriteLine("DataHora atual Ticks: " + d1.Ticks);
            DateTime d4 = new DateTime(2021, 6, 15, 13, 5, 58); // Usando construtores para pegar uma data e colocar na variável
            Console.WriteLine("DataHora setada Construtores : " + d4);
            DateTime d7 = DateTime.Parse("15/08/2000");
            DateTime d8 = DateTime.Parse("15/08/2000 13:05:58");
            Console.WriteLine("Parse sem horas " + d7);
            Console.WriteLine("Parse com horas " + d8);
            DateTime d5 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture); // com mascara de edição
            DateTime d6 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine("ParseExact sem horas " + d5);
            Console.WriteLine("ParseExact com horas " + d6);
            Console.WriteLine("---------------------------");
            Console.WriteLine("Topicos Especiais - TimeSpan ");
            TimeSpan t1 = new TimeSpan(1, 10, 1, 30); // TimeSpan(dias, horas, minutos, segundos, milissegundos)
            Console.WriteLine("TimeSpan : " + t1);
            Console.WriteLine("TimeSpan ticks: " + t1.Ticks);
            TimeSpan t11 = TimeSpan.FromDays(1.5);
            TimeSpan t2 = TimeSpan.FromHours(1.8);
            TimeSpan t3 = TimeSpan.FromMinutes(3.2);
            TimeSpan t4 = TimeSpan.FromSeconds(4.7);
            TimeSpan t5 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t6 = TimeSpan.FromTicks(900000000L);
            Console.WriteLine("FromDays(1.5) " + t11);
            Console.WriteLine("FromHours(1.8) " + t2);
            Console.WriteLine("FromMinutes(3.2) " + t3);
            Console.WriteLine("FromSeconds(4.7) " + t4);
            Console.WriteLine("FromMilliseconds(1.5) " + t5);
            Console.WriteLine("FromTicks(900000000L) " + t6);
            Console.WriteLine("---------------------------");
            Console.WriteLine("Topicos Especiais - Propriedades DateTime");
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine("original d : " + d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek); // dia da semana
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);// dia do ano
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);
            string ss1 = d.ToLongDateString(); // data alongada
            string ss2 = d.ToLongTimeString();
            string ss3 = d.ToShortDateString();// data curta
            string ss4 = d.ToShortTimeString();
            string ss5 = d.ToString();
            string ss6 = d.ToString("yyyy-MM-dd HH:mm:ss");
            string ss7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Console.WriteLine("ToLongDateString() " + ss1);
            Console.WriteLine("ToLongTimeString() " + ss2);
            Console.WriteLine("ToShortDateString() " + ss3);
            Console.WriteLine("ToShortTimeString() " + ss4);
            Console.WriteLine("ToString()" + ss5);
            Console.WriteLine("ToString('yyyy - MM - dd HH: mm:ss')" + ss6);
            Console.WriteLine("ToString('yyyy - MM - dd HH: mm:ss.fff')" + ss7);
            Console.WriteLine("---------------------------");
            Console.WriteLine("Topicos Especiais - Operações DateTime");
            DateTime dd1 = d.Add(t1); // adiciona um timeSpan t1 = new TimeSpan(1, 10, 1, 30); 
            DateTime dd2 = d.AddDays(3);
            DateTime dd3 = d.AddHours(5);
            DateTime dd4 = d.AddMilliseconds(500);
            DateTime dd5 = d.AddMinutes(23);
            DateTime dd6 = d.AddMonths(13);
            DateTime dd7 = d.AddSeconds(200);
            DateTime dd8 = d.AddTicks(14900000);
            DateTime dd9 = d.AddYears(3);
            TimeSpan dd10 = dd9.Subtract(d); // diferença entre datas e com TimeSpan
            DateTime dd11 = d.Subtract(dd10); // subtrair de uma variável timespan
            Console.WriteLine("original d : " + d);
            Console.WriteLine("1) d.Add(TimeSpan(1, 10, 1, 30)): " + dd1);
            Console.WriteLine("2) d.AddDays(3): " + dd2);
            Console.WriteLine("3) d.AddHours(5): " + dd3); // dia da semana
            Console.WriteLine("4) d.AddMilliseconds(500): " + dd4);// dia do ano
            Console.WriteLine("5) d.AddMinutes(23): " + dd5);
            Console.WriteLine("6) d.AddMonths(13):  " + dd6);
            Console.WriteLine("7) d.AddSeconds(200): " + dd7);
            Console.WriteLine("8) d.AddTicks(14900000): " + dd8);
            Console.WriteLine("9) d.AddYears(3): " + dd9);
            Console.WriteLine("10) timeSpan dd9.Subtract(d): " + dd10);
            Console.WriteLine("11)  d.Subtract(dd10): " + dd11);
            TimeSpan tt1 = TimeSpan.MaxValue; // valor máximo do TimeSpan
            TimeSpan tt2 = TimeSpan.MinValue; // valor mínimo do timeSpan
            TimeSpan tt3 = TimeSpan.Zero;
            Console.WriteLine("Valor Máximo TimeSpan : " + tt1);
            Console.WriteLine("Valor Mínimo TimeSpan : " + tt2);
            Console.WriteLine("Valor zero TimeSpan : " + tt3);
            Console.WriteLine("---------------------------");
            Console.WriteLine("Topicos Especiais - Operações DateSpan");
            Console.WriteLine("TimeSpan dd10 : " + dd10); // operado com TimeSpan
            Console.WriteLine("TotalDays: " + dd10.TotalDays);
            Console.WriteLine("TotalHours: " + dd10.TotalHours);
            Console.WriteLine("TotalMinutes: " + dd10.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + dd10.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + dd10.TotalMilliseconds);
            TimeSpan dd12 = new TimeSpan(1, 30, 10);
            TimeSpan sum = dd10.Add(dd12);
            TimeSpan dif = dd10.Subtract(dd12);
            TimeSpan mult = dd12.Multiply(2.0);
            TimeSpan div = dd12.Divide(2.0);
            Console.WriteLine("dd10 : " + dd10);
            Console.WriteLine("dd12 : " + dd12);
            Console.WriteLine("sum = dd10.Add(dd12): " + sum);
            Console.WriteLine("dif = dd10.Subtract(dd12)" + dif);
            Console.WriteLine("mult = dd12.Multiply(2.0)" + mult);
            Console.WriteLine("div = dd12.Divide(2.0)" + div);
            Console.WriteLine("---------------------------");
            Console.WriteLine("Topicos Especiais - DateTimeKind"); // com relação a GreenWich
            DateTime dtk1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime dtk2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime dtk3 = new DateTime(2000, 8, 15, 13, 5, 58);
            Console.WriteLine("dtk1: " + dtk1);
            Console.WriteLine("dtk1 Kind: " + dtk1.Kind);
            Console.WriteLine("dtk1 to Local: " + dtk1.ToLocalTime());
            Console.WriteLine("dtk1 to Utc: " + dtk1.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("dtk2: " + dtk2);
            Console.WriteLine("dtk2 Kind: " + dtk2.Kind);
            Console.WriteLine("dtk2 to Local: " + dtk2.ToLocalTime());
            Console.WriteLine("dtk2 to Utc: " + dtk2.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("dtk3: " + dtk3);
            Console.WriteLine("dtk3 Kind: " + dtk3.Kind);
            Console.WriteLine("dtk3 to Local: " + dtk3.ToLocalTime());
            Console.WriteLine("dtk3 to Utc: " + dtk3.ToUniversalTime());

        }

    }
}

