using  InterfaceAutenticavel;
System.Console.WriteLine("Ola mundo");

Gerente g = new Gerente();
g.Nome = "Gerente";
g.Senha = 123;

Diretor d =  new Diretor();
d.Nome = "Diretor";
d.Senha = 321;

Cliente c = new Cliente();
c.Nome = "Cliente leo";
c.Endereco = "rua b";
c.Senha = 200;

IAutenticavel ia;

ia  = g;

Console.WriteLine(g.Nome+" "+ia.Autenticar(123));
Console.WriteLine(c.Nome+" "+c.Autenticar(200));