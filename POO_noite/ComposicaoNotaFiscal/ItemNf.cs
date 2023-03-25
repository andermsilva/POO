using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal
{
    public class ItemNf
    {
        public int Quantidade { get; set; }

        public ItemNf(int q)
        {
            Quantidade = q;
        }

        ~ItemNf()/* Destrutor da objeto  sem parametros*/
        {
            System.Console.WriteLine("Destruindo o item nota");
        }
    }
}