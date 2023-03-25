using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoComposicao
{
    public class Venda
    {
        private int numero;

        private Comprador cliente;

        private Vendedor saler;

        private List<Produto> prod;
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public List<Produto> Prod
        {
            get { return prod; }
            set { prod = value; }
        }


        public Vendedor Saler
        {
            get { return saler; }
            set { saler = value; }
        }

        public Comprador Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }


        public Venda() {}


       
        public void MostrarVedas()
        {


            System.Console.WriteLine($"Venda: {Numero}");
            System.Console.WriteLine("================= Cliente(s) ====================");
            Cliente.MostrarComprador();
            System.Console.WriteLine("================= Prouto(s) ====================");
            foreach (Produto item in prod)
            {
                item.MostrarProduto();

            }
            System.Console.WriteLine("================= Vendedor(s) ====================");
            Saler.MostrarVendedor();
        }


    }
}