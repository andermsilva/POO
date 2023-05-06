// metodo  main()....
using FuncionarioPoli;
Console.Clear();

Funcionario f = new Funcionario(125,"Jose",1320,"Auxiliar geral");

Mensalista fm = new Mensalista(1002,"manoel",1000,"Balconista",30);

Horista fh = new Horista(1005,"Carlos",1000,"Motorisa",160.5);

f.MostrarFuncionario();
Console.WriteLine($"{f.MostrarSalario():C}");

System.Console.WriteLine();

fm.MostrarFuncionario();
Console.WriteLine($"{fm.MostrarSalario():C}");


System.Console.WriteLine("");

fh.MostrarFuncionario();
Console.WriteLine($"{fh.MostrarSalario():C}");
