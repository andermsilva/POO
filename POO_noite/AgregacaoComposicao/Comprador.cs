using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoComposicao
{
    public class Comprador
    {
        private double verba;
        
        public int Numero { get; set; }

        public string Nome { get; set; }

      public double Verba { get; set; }
        

        public Comprador()
        {
            
        }

        public Comprador(int numero, string nome, double verba)
        {

            Numero = numero;
            Nome  = nome;
            Verba = verba;
            
        }

        public void MostrarComprador(){
            System.Console.WriteLine($"Número: {Numero}\tNome: {Nome}\tVerba: {Verba:C}");
        }

    }
}