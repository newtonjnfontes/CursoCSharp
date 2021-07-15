using ConsoleApp1.Entidades.Enums;
using System.Collections.Generic; // namespace da classe List


namespace ConsoleApp1.Entidades
{
    class Trabalhador
    {
        public string Nome { get; set; }
        public NivelTrabalho Nivel { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public List<HoraContrato> Contrato { get; private set; } = new List<HoraContrato>(); // new para evitar lista nula

        public Trabalhador()
        {
        }

        public Trabalhador(string nome, NivelTrabalho nivel, double salarioBase, Departamento departamento)
        {
            Nome = nome;
            Nivel = nivel;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AdicionaContrato(HoraContrato contrato)
        {
            Contrato.Add(contrato);
        }

        public void RemoveContract(HoraContrato contrato)
        {
            Contrato.Remove(contrato);
        }

        public double Rendimento(int ano, int mes)
        {
            double soma = SalarioBase; // pega o salario base como inicio da soma
            foreach (HoraContrato contrato in Contrato) // percorre a lista e compara data com o Mês selecionado
            {
                if (contrato.Data.Year == ano && contrato.Data.Month == mes)
                {
                    soma += contrato.TotalValor();
                }
            }
            return soma;
        }
    }
}
