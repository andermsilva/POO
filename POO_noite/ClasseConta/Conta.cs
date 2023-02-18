using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseConta
{
    public class Conta
    {
        //declaração de atributos

        public int numero;
        public string titular;
        public double saldo;


        //      declaração dos métodos

        public void Sacar()
        {

        }
        public void Depositar()
        {

        }

        public void MostrarAtributos()
        {
            System.Console.WriteLine("Número: " + numero);
            System.Console.WriteLine("Titular: " + titular);
            System.Console.WriteLine("Saldo: " + saldo);
        }

    }
}