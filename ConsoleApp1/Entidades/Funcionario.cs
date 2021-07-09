using System.Globalization;
namespace ConsoleApp1 {
    class Funcionario {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;
        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario(double porcentagem) {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.0);
        }
        public override string ToString() { // override indica que a operação veio de outra classe - string é a saida
            return Nome
            + ", R$ "
            + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
