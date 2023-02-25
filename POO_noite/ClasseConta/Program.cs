//funcção Main()
using ClasseConta;

Conta c1;// Declaração de variavel
c1 = new Conta(); //Instancia de objeto
c1.Depositar(600);
System.Console.WriteLine("Conta 1");
c1.MostrarAtributos();

Conta c2;// Declaração de variavel
c2 = new Conta(); //Instancia de objeto
c2.numero = 90032;
c2.titular = "Evelyn";
c2.saldo = 100;
c2.Aplicacao(0.6);
System.Console.WriteLine("conta 2");
c2.MostrarAtributos();
/* if (c1.Transferir(1000, c2))
    System.Console.WriteLine("Trasferencia realizada com sucesso");
else
    System.Console.WriteLine("Trasferencia não realizada "); */

System.Console.WriteLine("Conta 1");
c1.MostrarAtributos();
System.Console.WriteLine("Conta 2");
c2.MostrarAtributos();







