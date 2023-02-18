// main()
/*
Console.WriteLine("Hello, World!");
System.Console.WriteLine("...Programa para calaular a idade...");
System.Console.Write("Informe o ano de nascimento: ");
int ano_nasc = Convert.ToInt32(   Console.ReadLine()   );
int idade = 2023 - ano_nasc;
System.Console.WriteLine("Sua idade é " + idade + " anos.\n");

//exemplo de estrutura de decisão
if (idade >= 18)
    System.Console.WriteLine("Maior de idade\n");
else
    System.Console.WriteLine("Menor de idade\n");
char opcao = '@';
switch(opcao)
{
    case '@': System.Console.WriteLine("Realizar uma soma");
            break;
    case 'm': System.Console.WriteLine("Realiza uma multiplição");
            break;
    default: System.Console.WriteLine("Opção inxistente");
             break;
}
//operador ternário
double media = 5;
string frase = (media >= 6) ? "Aluno aprovado" : "Aluno reprovado";
System.Console.WriteLine(frase+"\n");

//estruturas de repetição
int cont = 1;
while (cont < 5)
{
    System.Console.WriteLine(cont);
    //cont = cont + 1; Python
    //cont += 1 Python
    cont++;
}
while (cont >= 0)
{
    System.Console.WriteLine(cont);
    cont --;
}
*/
int cont;
for (cont = 23; cont < 30; cont++)
    System.Console.WriteLine(cont);
System.Console.WriteLine();
//estrutura de repetição - repita até
do
{
    System.Console.WriteLine(cont);
    cont++;
} while(cont < 33);