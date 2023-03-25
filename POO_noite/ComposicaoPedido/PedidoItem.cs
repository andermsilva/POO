using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoPedido
{
    public class PedidoItem
    {
        public int CodigoPedidoItem { get; set; }
        public int Quantidade { get; set; }

        public PedidoItem(int codPItem,int qtde)
        {
            CodigoPedidoItem = codPItem;
            Quantidade = qtde;
        }
    }
}