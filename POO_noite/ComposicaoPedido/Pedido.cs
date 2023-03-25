using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoPedido
{
    public class Pedido
    {
        public int CodigoPedido { get; set; }

        public string Data { get; set; }

        public PedidoItem _PedidoItem { get; set; }
        /*                 */
        public Pedido(int cod, string dt, int codItem,int qte)
        {
            CodigoPedido = cod;
            Data = dt;

            /* Relacionamento de composição */
            _PedidoItem = new PedidoItem(codItem,qte);
        }

        public Pedido(int cod, string dt, PedidoItem pi)
        {
            CodigoPedido = cod;
            Data = dt;
            _PedidoItem = pi;
        }
    }
}