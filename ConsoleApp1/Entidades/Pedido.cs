using System;
using ConsoleApp1.Entidades.Enums; // Abre area de enums permitindo a chamada de um enum que tem a descrição dos campos permitidos

namespace ConsoleApp1.Entidades
{
    class Pedido
    {

        public int Id { get; set; }
        public DateTime Momento { get; set; }
        public PedidoStatus Status { get; set; }

        public override string ToString()
        {
            return Id
                + ", "
                + Momento
                + ", "
                + Status;
        }
    }
}
