using System.Globalization;

namespace ConsoleApp1 {
    class ContaBancaria {
        public int Numero { get; private set; } // encapsulamento com private sem opção de alteração
        public string Titular { get; set; }
        public double Saldo { get; private set; } // só será alterado por deposito ou saque em outra função
        public ContaBancaria(int numero, string titular) { // sobre carga criada para contas com saldo inicial zerada
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular) { // this para aproveitar o construtor acima
            Saldo = saldo;
        }

        public void Deposito(double quantia) {  // operação para incluir quantia no saldo
            Saldo += quantia;
        }

        public void Saque(double quantia) { // operação para diminuir quantia no saldo
            Saldo -= quantia + 5.0; // 5.0 é a taxa de serviço bancário
        }

        public override string ToString() { // Para mostrar a conta quando chamada a variável objeto no program.cs
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
