//functio main

using EncapsulamentoCartaoCredito;
Console.Clear();
CartaoCredito credito = new CartaoCredito();

int op = 1;
while(op == 1)
{

    Console.Write("Informe o número do Catão: ");
    credito.Numero = Convert.ToInt32(Console.ReadLine());

    Console.Write("Informe o nome do Titutla: ");
    credito.Nome = Console.ReadLine();

    Console.Write("Informe de  segurança: ");
    credito.NumSeg = Convert.ToInt32(Console.ReadLine());

    Console.Write("Informe o ano de vencimento: ");
    credito.AnoVencimento = Convert.ToInt32(Console.ReadLine());

    Console.Write("Informe o Saldo: ");
    credito.Saldo = Convert.ToDouble(Console.ReadLine());


    Console.WriteLine("Deseja cadastrar mais um cartão?");
    Console.Write("Digite um(1) para adicionar ou zero(0) para sair: ");
    op = Convert.ToInt32(Console.ReadLine()) ;
}

credito.MostrarCartao();

if(op != 1)
    Console.WriteLine("================== Voce saiu do progrma. Obrigado! ===================");
