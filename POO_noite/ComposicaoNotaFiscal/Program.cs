//Funtion main..
using ComposicaoNotaFiscal;
Console.WriteLine("Hello, World!");

ItemNf iTf = new ItemNf(10);
ItemNf iTf2 = new ItemNf(15);

List<ItemNf> vI = new List<ItemNf>();

vI.Add(iTf);
vI.Add(iTf2);


NotaFiscal nf = new NotaFiscal(1,"25/03/2023",vI);

foreach (ItemNf item in nf.VetItem)
{
System.Console.WriteLine("Quantidade: "+item.Quantidade);
    
}

nf = null;

GC.Collect();