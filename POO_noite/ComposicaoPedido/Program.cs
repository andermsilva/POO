// fuction main...
using ComposicaoPedido;
Console.WriteLine("Hello, World!");

Pedido p1 =new Pedido(101,"24/03/2023",31,10);

PedidoItem pi = new(32,65);

PedidoItem pi2 = new PedidoItem(2,36);

Pedido p2 =new Pedido(125,"19/03/2023",pi2);

System.Console.WriteLine("Código do 1-pedido "+p1.CodigoPedido+"\tQtde "+p1._PedidoItem.Quantidade);
System.Console.WriteLine("Código do 2-pedido "+p2.CodigoPedido+"\tQtde "+p2._PedidoItem.Quantidade);





