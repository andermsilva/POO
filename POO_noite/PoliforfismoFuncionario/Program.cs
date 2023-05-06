//function main()

using PoliforfismoFuncionario;

Funcionario f  = new Funcionario(1,"funcionario",1000);
Console.WriteLine($"{f.Nome} - Bonificação {f.CalcularBonificao():C}");

Secretaria s = new Secretaria(1,"Secretaria",1000,12);
Console.WriteLine($"{s.Nome} - Bonificação {s.CalcularBonificao():C}");
Gerente g = new Gerente(1,"Secretaria",1000);
Console.WriteLine($"{g.Nome} - Bonificação {g.CalcularBonificao():C}");

Diretor d = new Diretor(1,"Diretor",1000);
Console.WriteLine($"{d.Nome} - Bonificação {d.CalcularBonificao():C}");


