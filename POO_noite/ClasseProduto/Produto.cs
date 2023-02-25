using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseProduto
{
    //Declarar Classe...
    public class Produto
    {
        //Declarar atributos..
        public int codigo;
        public string? nome;
        public string? descricao;
        public double preco;

        public void MostrarAtributos()
        {

            System.Console.WriteLine("código: " + codigo);
            System.Console.WriteLine("nome: " + nome);
            System.Console.WriteLine("Descrição: " + descricao);
            System.Console.WriteLine("preço: " + preco);

        }
    }


}