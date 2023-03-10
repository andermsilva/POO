using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayProduto
{
    public class Produto
    {
        private int codigo;
        private double preco;
        private string nome;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        private void Mostrar(){
            System.Console.WriteLine($"Código: {Codigo}");
            System.Console.WriteLine($"Nome: {Nome}");
            System.Console.WriteLine($"Preço: {Preco:C}");
        }


    }
}