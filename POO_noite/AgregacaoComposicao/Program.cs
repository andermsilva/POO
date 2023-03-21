// Function main
using AgregacaoComposicao;
Console.Clear();
Console.WriteLine("Hello, World!");
List<Comprador> vetCli = new List<Comprador>();
List<Produto> vetPro = new List<Produto>();
List<Vendedor> vetV = new List<Vendedor>();

Venda v1 = new Venda();
Produto pro = new Produto();
Produto pro1 = new Produto();

Vendedor ve = new Vendedor();
Vendedor ve1 = new Vendedor();

Comprador c = new Comprador();
Comprador c1 = new Comprador();

pro.Codigo=14;
pro.Tamanho = 21;
pro.Preco = 3.5;

pro1.Codigo=20;
pro1.Tamanho = 30;
pro1.Preco = 10.5;
vetPro.Add(pro);
vetPro.Add(pro1);

c.Numero = 101;
c.Nome = "Jose Carlos";
c.Verba = 1500.5;

c1.Numero = 203;
c1.Nome = "Manoel";
c1.Verba = 1250;

vetCli.Add(c);
vetCli.Add(c1);

ve.Numero = 501;
ve.Nome = "Carlos";
ve.Comissao = 5;

ve1.Numero = 703;
ve1.Nome = "Manoel";
ve1.Comissao = 15;

vetV.Add(ve);
vetV.Add(ve1);

v1.Cliente = vetCli;
v1.Numero =1;
v1.Prod = vetPro;
v1.Saler = vetV;

v1.MostrarVedas();


vetCli.Clear();
vetPro.Clear();
vetV.Clear();
/* ==================================================================================== */
System.Console.WriteLine("");
Venda v2 = new Venda();

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

Comprador c2 = new Comprador();


c2.Numero = 333;
c2.Nome = "Maria";
c2.Verba = 1250;

vetCli.Add(c2);

Vendedor ve3 =new Vendedor();
ve3.Comissao=5;
ve3.Numero=441;
ve3.Nome = "Antonia";
vetV.Add(ve3);

v2.Numero = 2;
v2.Cliente = vetCli;
v2.Prod=vetPro;
v2.Saler = vetV;

v2.MostrarVedas();





