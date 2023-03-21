using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoContaVetor
{
    public class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; set; }

        public List<Cliente> VetTitular { get; set; }

        public void MostrarConta(){
            Console.WriteLine("Numero: "+Numero+"\tSaldo: "+Saldo);
        }
    }
}