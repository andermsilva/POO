// método main()

using HerancaCliente;
Console.Clear();


Cliente c = new Cliente();


c.Endereco = "sdasdasda 25";
c.Codigo = 1;
c.Nome = "AAAAA";
c.Mostrar();

ClienteFisico cf = new ClienteFisico();
ClienteFisico cf2 = new ClienteFisico(2001,"Ander","Rua das Flores 45",123,"201100");

cf.Nome = "BBBB";
cf.Codigo=120;
cf.Rg=40021;
cf.Cpf= "45200131";
cf.Endereco = "dsadasdas 52";
cf.Mostrar();

ClienteJuridico cj = new ClienteJuridico();

cj.Nome = "Empresa";
cj.Codigo=120;
cj.Cnpj=40021;
cj.Ie = 45200131;
cj.Endereco = "dsadasdas 52";
