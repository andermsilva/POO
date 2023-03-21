//Fuction main

using ConstrutorFuncionario;
Console.Clear();

Funcionario f1 = new Funcionario();
System.Console.WriteLine("==============================================");
double tx;

f1.Nome="Anderson";
f1.Salario = 1500;
f1.MotrarFuncionario();

System.Console.WriteLine("================== Reajuste de Sálarios =================================");
System.Console.Write("Informe a taxa de reajuste: ");
tx = Convert.ToDouble(System.Console.ReadLine());
f1.Reajuste(tx);
f1.MotrarFuncionario();
System.Console.WriteLine("===============================================");

Funcionario f2 = new Funcionario("Maria");
f2.Salario = 1500;
f2.MotrarFuncionario();

System.Console.WriteLine("================== Reajuste de Sálarios =================================");
System.Console.Write("Informe a taxa de reajuste: ");
tx = Convert.ToDouble(System.Console.ReadLine());
f2.Reajuste(tx);
f2.MotrarFuncionario();
System.Console.WriteLine("===============================================");

Funcionario f3 = new Funcionario("Carlos",1600);
f3.MotrarFuncionario();

System.Console.WriteLine("================== Reajuste de Sálarios =================================");

System.Console.Write("Informe a taxa de reajuste: ");
tx = Convert.ToDouble(System.Console.ReadLine());
f3.Reajuste(tx);
f3.MotrarFuncionario();

System.Console.WriteLine("================== "+Funcionario.Contador+" Instancias criadas ======================");