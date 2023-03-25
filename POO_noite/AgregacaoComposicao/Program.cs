// Function main
using AgregacaoComposicao;
Console.Clear();
Console.WriteLine("Hello, World!");

List<Produto> vetPro = new List<Produto>();

Venda v1 = new Venda();
Vendedor saler = new Vendedor();
Comprador cli = new Comprador();

saler.Numero = 1;
saler.Comissao =5;
saler.Numero=101;
saler.Nome = "jose Alberto";

cli.Numero = 101;
cli.Nome = "Jose Carlos";
cli.Verba = 1500.5;

Produto pro = new Produto();
Produto pro1 = new Produto();

pro.Codigo=14;
pro.Tamanho = 21;
pro.Preco = 3.5;

pro1.Codigo=20;
pro1.Tamanho = 30;
pro1.Preco = 10.5;

vetPro.Add(pro);
vetPro.Add(pro1);

v1.Cliente = cli;
v1.Saler= saler;
v1.Prod = vetPro;

v1.MostrarVedas();

vetPro.Clear();

/* ==================================================================================== */
System.Console.WriteLine("");
Venda v2 = new Venda();
Vendedor saler1 = new Vendedor();

Comprador cli1 = new Comprador();

cli1.Numero = 333;
cli1.Nome = "Maria";
cli1.Verba = 1250;

Produto pro2 = new Produto();
Produto pro3 = new Produto();

pro2.Codigo=47;
pro2.Tamanho = 25;
pro2.Preco = 17.5;

pro3.Codigo=71;
pro3.Tamanho = 30;
pro3.Preco = 51.5;

vetPro.Add(pro2);
vetPro.Add(pro3);

saler1.Comissao=5;
saler1.Numero=441;
saler1.Nome = "Antonia";


v2.Numero = 2;
v2.Cliente = cli1;
v2.Prod=vetPro;
v2.Saler = saler1;

v2.MostrarVedas();





