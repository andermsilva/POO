// Main();

using AbstrataFuncionario;
Console.WriteLine("Hello, World!");

Assalariado a1 = new Assalariado(12,"Andrea",1421);
Assalariado a2 = new Assalariado(13,"José",1320);
Comissionado c1 = new Comissionado(14,"Maria",1000,0.7);
Comissionado c2 = new Comissionado(15,"Carlos",1000,0.7);

Dependente fi1 =  new Dependente(111, "Rodrigo filho",15);
Dependente fi2 =  new Dependente(102, "Daiana filho",18);
Dependente fi3 =  new Dependente(188, "Felipe filho",11);
Dependente fi4 =  new Dependente(201, "Enzo filho",9);
Dependente fi5 =  new Dependente(211, "Lara filho",7);
Dependente fi6 =  new Dependente(344, "Luana Souza",21);
Dependente fi7 =  new Dependente(350, "Eduarda Souza",16);


c2.AdicionarDependente(fi1);
c2.AdicionarDependente(fi3);
c2.AdicionarDependente(fi2);

c1.AdicionarDependente(fi4);

a1.AdicionarDependente(fi5);

a2.AdicionarDependente(fi6);
a2.AdicionarDependente(fi7);

/* a1.Mostrar();
System.Console.WriteLine($"{a1.CalcucularSalario(30):C}");
a2.Mostrar();
c1.Mostrar();
c2.Mostrar();
System.Console.WriteLine($"{c2.CalcucularSalario(20):C}"); */

Departamento d1 = new Departamento(10,"TI");
d1.Admitir(a1);
d1.Admitir(c1);
Departamento d2 = new Departamento(11,"RH");
d2.Admitir(a2);
d2.Admitir(c2);

d1.ListarFuncionarios();
d2.ListarFuncionarios();

/* d2.DemitirFuncionario(15);
d2.ListarFuncionarios(); 
 */
System.Console.WriteLine($"Total da folha de pagamento {d1.Descricao} {d1.CalcularFolha(30):C}");
System.Console.WriteLine($"Total da folha de pagamento {d2.Descricao} {d2.CalcularFolha(30):C}");

/* ----------------- Listar Dependentes por funcionário -------------------- */
c1.ListarDependentes();
c2.ListarDependentes();
a1.ListarDependentes();
a2.ListarDependentes();


/* ----------------- Remover Dependentes com mioridade (18 anos) -------------------- */
a2.RemoverDependentesMaioridade(344);
a2.ListarDependentes();

c2.RemoverDependentesMaioridade(102);
c2.ListarDependentes();


/* ----------------- Mostrar quantidade de dependentes por funcionario -------------------- */
d2.MostrarQtdeDependentesFuncuonario();

d1.MostrarQtdeDependentesFuncuonario();
