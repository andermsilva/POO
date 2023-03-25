using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class Banco
    {
        public List<Poupanca> Poups { get; set; }

        public List<ContaCorrete> Conta { get; set; }


        public Banco() { }

        public Banco(List<Poupanca> poup, List<ContaCorrete> conta)
        {
            Conta = conta;
            Poups = poup;
        }



        public void MostrarBanco()
        {
            System.Console.WriteLine("============== Conta Poupança ================");
            foreach (Poupanca item in Poups)
            {
                item.MostrarPoupanca();
                System.Console.WriteLine("====================================");

            }
            System.Console.WriteLine("============== Conta Corrente= =======================");
            foreach (ContaCorrete item in Conta)
            {
                item.MostrarConta();
                System.Console.WriteLine("=======================================================");

            }
        }

        ~Banco()
        {

            foreach (ContaCorrete item in Conta)
            {
                if (item.Saldo < 0 && item.ChequeEspecial < item.Saldo)
                {
                    Conta = null;
                   

                    System.Console.WriteLine("Entrou em concordata...");
                }
            }




        }
    }
}