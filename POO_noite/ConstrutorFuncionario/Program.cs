//Fuction main

using ConstrutorFuncionario;

System.Console.WriteLine("===============================================");

Funcionario f1 = new Funcionario();
f1.Nome="Anderson";
f1.Salario = 1500;
f1.MotrarFuncionario();

System.Console.WriteLine("===============================================");

Funcionario f2 = new Funcionario("Maria");
f2.Salario = 1500;
f2.MotrarFuncionario();


System.Console.WriteLine("===============================================");

Funcionario f3 = new Funcionario("Carlos",1600);
f3.MotrarFuncionario();

System.Console.WriteLine("================== Reajuste de Sálarios =================================");

System.Console.Write("Informe a taxa de reajuste: ");
double tx = Convert.ToDouble(System.Console.ReadLine());
f1.Reajuste(tx);
f2.Reajuste(tx);
f3.Reajuste(tx);

System.Console.WriteLine("================= Ajuste de "+tx+"% =========================");
f1.MotrarFuncionario();
System.Console.WriteLine("===============================================");
f2.MotrarFuncionario();
System.Console.WriteLine("===============================================");
f3.MotrarFuncionario();



System.Console.WriteLine("================== Contagem de Instancias =============================");

System.Console.WriteLine(Funcionario.Contador+" Instacias criadas");






