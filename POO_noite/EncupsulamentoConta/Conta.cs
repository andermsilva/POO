using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncupsulamentoConta
{
    public class Conta
    {
        private int numero;
        public int Numero
        {
            get { return numero; }//body expression get  => numero
            set
            {

                if (value > 0)
                    numero = value;
                else
                    System.Console.WriteLine("Código inválido");

            }
        }

        private string titular;
        public string Titular
        {
            get => titular.ToUpper();
            set
            {
                if (value != "")

                    titular = value;
                else
                System.Console.WriteLine("Nome não pode ser vazio");    
            }
        }

        private decimal saldo;
        public decimal Saldo
        {
            get { return saldo; }
            set { 
                if(value >= 0)
                saldo = value;
                else
                System.Console.WriteLine("Saldo insuficiente!");
                 }
        }


    }
}