using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoComposicao
{
    public class Produto
    {
        private int codigo;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public int Tamanho { get; set; }

        public double Preco { get; set; }

       public Produto(){

       }
        public Produto(int codigo, int tamanho, double preco)
        {
            Codigo = codigo;
            Tamanho = tamanho;
            Preco = preco;

        }

        public void MostrarProduto()
        {
            System.Console.WriteLine($"Código: {Codigo} \tTamanho: {Tamanho}\t Preço: {Preco:C}");
        }

       
    }
}