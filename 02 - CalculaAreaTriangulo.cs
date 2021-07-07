using System;

public class CalculaAreaTriangulo {
	public Class1()
	{

        static void Main(string[] args) // membro da classe
                                        // indica onde o programa é iniciado

        {
            // ================================================
            // Sem orientação a objeto

            Console.WriteLine("---------------------------");
            double xA, xB, xC, yA, yB, yC;
            Console.WriteLine("Entre com as medidas do triângulo X:");
            Console.Write("Entre com medida xA : ");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com medida xB : ");
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com medida xC : ");
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com as medidas do triângulo Y:");
            Console.Write("Entre com medida yA : ");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com medida yB : ");
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com medida yC : ");
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double p = (xA + xB + xC) / 2.0; // para usar na formula de Heron
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC)); // (fórmula de Heron)
            p = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));
            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            if (areaX > areaY) {
                Console.WriteLine("Maior área: X = " + areaX);
            }
            else {
                Console.WriteLine("Maior área: Y = " + areaY);
            }
            // ================================================
            // Com orientação a objeto
            // Criar classe para a entidade Triangulo que tem três atributos A, B e C ( também tem o metodo = ( funções e Operações )
            // classes pode serm Construtores , Sobrecarga , Encapsulamento , Herança , Polimorfismo
            // classe também pode ser um tipo
            // exemplos •  Entidades: Produto, Cliente, Triangulo
            //          • Serviços: ProdutoService, ClienteService, EmailService, StorageService
            //          • Controladores: ProdutoController, ClienteController
            //          • Utilitários: Calculadora, Compactador
            //          • Outros(views, repositórios, gerenciadores, etc.)
            Triangulo x, y; // Criada classe Triangulo e instanciada com tipo de variável
            x = new Triangulo(); // captura areas da classe com variaveis A, B e C com encereço x
            y = new Triangulo(); // captura areas da classe com variaveis A, B e C com encereço y
            double areaX1, areaY1, p1;
            Console.WriteLine("---  Usando programação orientada a objeto  ----");
            Console.WriteLine("Entre com as medidas do triângulo X:");
            Console.Write("Entre com medida xA : ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // instanciando variaveis da classe triangulo
            Console.Write("Entre com medida xB : ");
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com medida xC : ");
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com as medidas do triângulo Y:");
            Console.Write("Entre com medida yA : ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com medida yB : ");
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com medida yC : ");
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture)
            p1 = (x.A + x.B + x.C) / 2.0; // para usar na formula de Heron
            areaX1 = Math.Sqrt(p1 * (p1 - x.A) * (p1 - x.B) * (p1 - x.C)); // (fórmula de Heron)
            p1 = (y.A + y.B + y.C) / 2.0;
            areaY1 = Math.Sqrt(p1 * (p1 - y.A) * (p1 - y.B) * (p1 - y.C)); // (fórmula de Heron)
            Console.WriteLine("Área de X = " + areaX1.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY1.ToString("F4", CultureInfo.InvariantCulture));
            if (areaX1 > areaY1) {
                Console.WriteLine("Maior área: X = " + areaX1);
            }
            else {
                Console.WriteLine("Maior área: Y = " + areaY1);
            }
            // ================================================
            // Com orientação a objeto e colocando calculo da área na classe triangulo
            Triangulo x2, y2; // Criada classe Triangulo e instanciada com tipo de variável
            x2 = new Triangulo(); // captura areas da classe com variaveis A, B e C com encereço x
            y2 = new Triangulo(); // captura areas da classe com variaveis A, B e C com encereço y
            double areaX2, areaY2;
            Console.WriteLine("---  Usando programação orientada a objeto  ----");
            Console.WriteLine("Entre com as medidas do triângulo X:");
            Console.Write("Entre com medida xA : ");
            x2.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // instanciando variaveis da classe triangulo
            Console.Write("Entre com medida xB : ");
            x2.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com medida xC : ");
            x2.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com as medidas do triângulo Y:");
            Console.Write("Entre com medida yA : ");
            y2.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com medida yB : ");
            y2.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com medida yC : ");
            y2.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture)
            AreaX2 = x2.CalcularArea();
            AreaY2 = y2.CalcularArea();
            Console.WriteLine("Área de X = " + areaX2.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY2.ToString("F4", CultureInfo.InvariantCulture));
            if (areaX2 > areaY2) {
                Console.WriteLine("Maior área: X = " + areaX2);
            }
            else {
                Console.WriteLine("Maior área: Y = " + areaY2);
            }

        }
    }
}
