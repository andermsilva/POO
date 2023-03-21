// Function Main //
using AgregacaoConta;
Console.WriteLine("Contas Bancarias!");

Endereco local = new Endereco("Rua santa maria","5","JD Rosas","Rio Preto");

Cliente cli  =new Cliente("Bia",145,45,local);

Conta c1 = new Conta();

c1.Saldo = 110;
c1.Numero=1021;
c1.Titular = cli;

Cliente cli2  =new Cliente("Mria",250,85);

Conta c3 = new Conta();

c3.Saldo = 110;
c3.Numero=1023;
c3.Titular = cli2;
c3.Titular.Enderco_ = local;



Conta c2 = new Conta();

c2.Numero = 1022;
c2.Saldo = 250;
c2.Titular = new Cliente();
c2.Titular.Nome = "Anderson";
c2.Titular.Cpf = 520;
c2.Titular.Rg = 15;
c2.Titular.Enderco_ = new Endereco();
c2.Titular.Enderco_.Logradouro="Rua Oliveira";
c2.Titular.Enderco_.Numero="450 A";
c2.Titular.Enderco_.Bairro="Sabara";
c2.Titular.Enderco_.Cidade="Martinopolis";



c1.Mostrar();
System.Console.WriteLine("==============================");
c2.Mostrar();
System.Console.WriteLine("==============================");
c3.Mostrar();
