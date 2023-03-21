using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoComposicao
{
    public class Venda
    {
        private int numero;

        private List<Comprador> cliente;

        private List<Vendedor> saler;

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


        public List<Vendedor> Saler
        {
            get { return saler; }
            set { saler = value; }
        }

        public List<Comprador> Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public static int GeraCodigo { get; set; }

        static Venda(){
          GeraCodigo =10;
        }
        public Venda() {
            Numero = ++ GeraCodigo;
         }


       
        public void MostrarVedas()
        {


            System.Console.WriteLine($"Venda: {Numero}");
            System.Console.WriteLine("================= Clientes ====================");
            foreach (Comprador cm in Cliente)
            {
                cm.MostrarComprador();
                //System.Console.WriteLine($"Código cliente: {cm.Numero}\t Nome: {cm.Nome}");

            }
            System.Console.WriteLine("================= Prouto(s) ====================");
            foreach (Produto item in prod)
            {
                item.MostrarProduto();

              //  System.Console.WriteLine($"Código produto: {item.Codigo}\t Tamanho: {item.Tamanho}\tPreço: {item.Preco:C}");
            }
            System.Console.WriteLine("================= Vendedor(s) ====================");
            foreach (Vendedor ivend in saler)
            {
                ivend.MostrarVendedor();
                //System.Console.WriteLine($"Código produto: {ivend.Numero}\t Nome: {ivend.Nome}\tPreço: {ivend.Comissao}");
            }
        }


    }
}