// Function Main
using AgregacaoContaVetor;
Console.Clear();
Console.WriteLine("Hello, World!");


Conta c1 = new Conta();

c1.Numero  = 101;
c1.Saldo  = 1000;

Cliente cli1 =  new Cliente("Anderson",1011,25);
Cliente cli2 =  new Cliente("Jose",1013,71);
Cliente cli3 =  new Cliente("Carlos",1013,46);

c1.VetTitular = new List<Cliente>();

c1.VetTitular.Add(cli1);
c1.VetTitular.Add(cli2);
c1.VetTitular.Add(cli3);
c1.MostrarConta();
foreach (Cliente c in c1.VetTitular)
{
    c.Mostrar();
}

