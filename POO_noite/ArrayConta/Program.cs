// functio main

using ArrayConta;

Conta[] vetConta = new Conta[3];

for (int i = 0; i < vetConta.Length; i++)
{
    vetConta[i] = new Conta();

    System.Console.WriteLine("Digite o número");
    vetConta[i].numero = Convert.ToInt32(Console.ReadLine());
    
    System.Console.WriteLine("Digite o titular");
    vetConta[i].titular =Console.ReadLine();

    System.Console.WriteLine("Digite o saldo");
    vetConta[i].saldo = Convert.ToInt32(Console.ReadLine());
}

foreach (Conta c in vetConta)
{
    c.MostrarAtributos();

}

for (int i = 0; i < vetConta.Length; i++)
{
    vetConta[i].MostrarAtributos();
}