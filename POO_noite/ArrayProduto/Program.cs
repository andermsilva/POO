//function

using ArrayProduto;

Produto [] vetP = new Produto[3];

for (int i = 0; i < vetP.Length; i++)
{
    vetP[i] = new Produto();

    System.Console.WriteLine("Produto "+(i+1));

    System.Console.Write("Informe o Código: ");
    vetP[i].Codigo = Convert.ToInt32(Console.ReadLine());
   
    System.Console.Write("Informe o Nome: ");
    vetP[i].Nome = Console.ReadLine();
    
    System.Console.Write("Informe o Preço: ");
    vetP[i].Preco = Convert.ToDouble(Console.ReadLine());

    System.Console.WriteLine(" ");
}

double media=0;
double precoAlto=0;

foreach (Produto prod in vetP)
{
  media += prod.Preco;  
  System.Console.WriteLine("Código:"+ prod.Codigo+ " \nNome Produto: "+prod.Nome+"\nPreço: "+prod.Preco+"\n");
  if(prod.Preco > 200){
    precoAlto = prod.Preco;
  }
  
}
 
System.Console.WriteLine($"Média de preços: {media/vetP.Length:C}");
System.Console.WriteLine($"Preço mais alto: {precoAlto:C}");

 
