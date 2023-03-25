using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal
{
    public class NotaFiscal
    {
        public int NumerNF { get; set; }

        public string Data { get; set; }

        public List< ItemNf> VetItem { get; set; }

        public NotaFiscal(int n, string dt, List<ItemNf> vItens){
            NumerNF = n;
            Data = dt;
            VetItem = vItens;
        }

        ~NotaFiscal()/* Destrutor da objeto  sem parametros*/
        {
            VetItem = null;
            System.Console.WriteLine("Destruindo a nota fical");
        }
    }
}