// function main
using Exercicios.EncaosulamentoCartaoCartao;


CartaoCredito cr = new CartaoCredito();
Console.Clear();
Console.WriteLine("================== Cadastro de Cartões de credito ===================");
int op = 1;

while(op == 1)
{

    Console.Write("Informe o número do Catão: ");
    cr.Numero = Convert.ToInt32(Console.ReadLine());

    Console.Write("Informe o nome do Titutla: ");
    cr.Nome = Console.ReadLine();

    Console.Write("Informe de  segurança: ");
    cr.NumSeg = Convert.ToInt32(Console.ReadLine());

    Console.Write("Informe o ano de vencimento: ");
    cr.AnoVencimento = Convert.ToInt32(Console.ReadLine());

    Console.Write("Informe o Saldo: ");
    cr.Saldo = Convert.ToDouble(Console.ReadLine());


    Console.WriteLine("Deseja cadastrar mais um cartão?");
    Console.Write("Digite um(1) para adicionar ou zero(0) para sair: ");
    op = Convert.ToInt32(Console.ReadLine()) ;
}

cr.MostrarAtributos();

if(op != 1)
    Console.WriteLine("================== Voce saiu do programa. Obrigado! ===================");