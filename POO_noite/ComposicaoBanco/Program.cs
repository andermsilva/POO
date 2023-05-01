/* Functio main... */

using ComposicaoBanco;
Console.WriteLine("============================= Banco ===========================\n");

ContaCorrete c1 = new ContaCorrete(11, 120, 150);
ContaCorrete c2 = new ContaCorrete(101, 1500, 1000);
ContaCorrete c3 = new ContaCorrete(2001, 900, 300);

/* c3.Sacar(1000);
c3.Depositar(100); */


Poupanca p1 = new Poupanca(11, 100);
Poupanca p2 = new Poupanca(101, 100);
Poupanca p3 = new Poupanca(2001, 150);

/* p2.Depositar(100);
p2.GerarRendimentos();
p2.Sacar(10); */

List<Poupanca> poups = new List<Poupanca>();
poups.Add(p1);
poups.Add(p2);
poups.Add(p3);

List<ContaCorrete> contas = new List<ContaCorrete>();
contas.Add(c1);
contas.Add(c2);
contas.Add(c3);

Banco banco = new Banco(poups, contas);

/* 
    Testes de conta corrente e conta poupança

    deposito / saldo e cheque especial.
 */

/*foreach (ContaCorrete corrente in contas)
{
    corrente.GerarExtrato();
    corrente.Sacar(1000);
    corrente.Depositar(100);
    corrente.GerarExtrato();
    corrente.MostrarConta();
}

 foreach (Poupanca poupa in poups)
{

    poupa.MostrarPoupanca();
    poupa.Depositar(100);
    poupa.GerarRendimentos();
    poupa.Sacar(10);
    poupa.MostrarPoupanca();

} */
banco.Conta[2].MostrarConta();
banco.Conta[2].Sacar(1000);
banco.Conta[2].MostrarConta();

banco.Conta[2].Depositar(100);
banco.Conta[2].MostrarConta();
banco.Conta[2].Depositar(1);
banco.Conta[2].Depositar(300);
banco.Conta[2].MostrarConta();



//banco.MostrarBanco();