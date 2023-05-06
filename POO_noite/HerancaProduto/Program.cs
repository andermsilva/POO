// metodo main()
using HerancaProduto;
Console.Clear();

var p = new Produto();

p.Codigo=2505;
p.Nome = "TV 55' ";
p.Preco = 2.50;

Perecivel pr = new Perecivel();

pr.Codigo =22;
pr.Nome = "Iogorte'";
pr.Data_Fabricacao = "20/01/2023";
pr.Data_Validade = "20/05/2023";
pr.Preco = 3.90;
pr.Lote = 5012;

p.Mostrar();
System.Console.WriteLine();
pr.Mostrar();


