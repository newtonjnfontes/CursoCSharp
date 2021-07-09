using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entidades.Enums
{
    enum PedidoStatus : int // quando cria aparece a palavra class -  trocar para enum  ( : int -> tem a ver com herança)
    {
        PagamentoPendente = 0, // colocando o numero forçamos a indexação
        Processando = 1,
        Enviado = 2,
        Entregue = 3
    }
}
