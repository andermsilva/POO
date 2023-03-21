using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoComposicao
{
    public class Vendedor
    {
        public int Numero { get; set; }

        public string Nome { get; set; }

        public double Comissao { get; set; }


        public Vendedor()
        {

        }

        public Vendedor(int num, string nome, double comissao)
        {
            Numero = num;
            Nome = nome;
            Comissao = comissao;

        }

        public void MostrarVendedor(){
            System.Console.WriteLine($"Número: {Numero}\tNome: {Nome}\tComissão: {Comissao}%");
        }

    }
}