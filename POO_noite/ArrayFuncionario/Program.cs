// function main ....

using ArrayFuncionario;

Funcionario[] vetF = new Funcionario[3];

for (int i = 0; i < vetF.Length; i++)
{
    vetF[i] = new Funcionario();
    System.Console.Write("Digite o código: ");
    vetF[i].codigo = Convert.ToInt32(Console.ReadLine());

    System.Console.Write("Digite o Nome: ");
    vetF[i].nome = Console.ReadLine();

    System.Console.Write("Digite o salário: ");
    vetF[i].salario = Convert.ToDouble(Console.ReadLine());
    System.Console.WriteLine("===============//\\\\=============");
}
System.Console.WriteLine(" ");

for (int i = 0; i < vetF.Length; i++)
{
    System.Console.WriteLine("================== Funcionário =======================");
    vetF[i].MostrarAtributos();
}

System.Console.WriteLine(" ");
double soma = 0;
double media = 0;
for (int i = 0; i < vetF.Length; i++)
{
    soma += vetF[i].salario;
}
if (soma > 0)
    media = soma / vetF.Length;
System.Console.WriteLine($"Média Sálarial: {media:C}");

System.Console.WriteLine(" ");

System.Console.WriteLine("===== Sálarios Acima de R$ 300,00 =====");
foreach (Funcionario funcionario in vetF)
{
    if (funcionario.salario > 300)
    {
        System.Console.WriteLine($"Nome: {funcionario.nome} Salário: {funcionario.salario:C}");
    }
}
System.Console.WriteLine(" ");


System.Console.Write("Informe a taxa de aumento salárial: ");
double taxa = Convert.ToDouble(Console.ReadLine());
foreach (Funcionario funcionario in vetF)
{
    funcionario.Aumento(taxa, funcionario);
    System.Console.WriteLine("================== Funcionário =======================");
    funcionario.MostrarAtributos();
}

