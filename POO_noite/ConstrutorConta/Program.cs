//funtion main

using ConstrutorConta;

Conta c1 = new Conta();

Conta c2 = new Conta(101);

Conta c3 = new Conta(103, "Anderson",150);





c1.Mostrar();
System.Console.WriteLine("============================");
c2.Mostrar();
System.Console.WriteLine("============================");
c3.Mostrar();
System.Console.WriteLine("============== Contador: "+Conta.Contador+" ==============");

//ClasseEstatica.MostrarFrase(); Exemplo de chamada de classe estatica.