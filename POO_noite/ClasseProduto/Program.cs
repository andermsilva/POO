//function Main

using ClasseProduto;

Produto p1 = new Produto();

System.Console.Write(" Digite o Código: ");
p1.codigo = Convert.ToInt32(Console.ReadLine());

System.Console.Write(" Digite o nome: ");
p1.nome = Console.ReadLine();

System.Console.Write(" Digite o Descrição: ");
p1.descricao=Console.ReadLine();

System.Console.Write(" Digite o preço: ");
p1.preco = Convert.ToDouble(Console.ReadLine());

Produto p2 = new Produto();

System.Console.Write(" Digite o Código: ");
p2.codigo = Convert.ToInt32(Console.ReadLine());

System.Console.Write(" Digite o nome: ");
p2.nome = Console.ReadLine();

System.Console.Write(" Digite o Descrição: ");
p2.descricao=Console.ReadLine();

System.Console.Write(" Digite o preço: ");
p2.preco = Convert.ToDouble(Console.ReadLine());

p1.MostrarAtributos();
p2.MostrarAtributos();
double soma = p1.preco + p2.preco;
System.Console.WriteLine($"Soma dos preços {soma:C}\n");
System.Console.WriteLine($"Soma dos preços {soma:N}");
