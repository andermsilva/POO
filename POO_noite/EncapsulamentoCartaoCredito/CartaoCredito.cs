using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoCartaoCredito
{
    public class CartaoCredito
    {
        private int numSeg;
        private int numero;
        private int anoVencimento;

        public int Numero
        {
            get => numero;

            set
            {
                if (value > 0)
                    numero = value;
                else
                    Console.WriteLine("informe numero maior que 0 (zero)");
            }

        }
        public string Nome { get; set; }

        public double Saldo { get; set; }


        public int AnoVencimento
        {
            get { return anoVencimento; }
            set
            {
                if (value > 2022)
                    anoVencimento = value;
                else
                    Console.WriteLine("Informe o ano maior que 2022");
            }
        }

        public int Numseg { get; set; }

             public int NumSeg
             {
                 get { return numSeg; }
                 set
                 {
                     if (value > 0)
                         numSeg = value;
                     else
                         Console.WriteLine("Informe o numero de segurança maior que zero(0)");
                 }
             }


        public void MostrarCartao()
        {
            Console.WriteLine("Número Cartão: " + Numero);
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Ano Vencimento: " + anoVencimento);
            Console.WriteLine("Número de Segurança: " + NumSeg);
            Console.WriteLine("Saldo: " + Saldo);

        }

    }
}