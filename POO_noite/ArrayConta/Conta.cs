using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayConta
{
    public class Conta
    {
        public int numero;
        public string titular;
        public double saldo;
    public void MostrarAtributos()
        {
            System.Console.WriteLine("Número: " + numero);
            System.Console.WriteLine("Titular: " + titular);
            System.Console.WriteLine("Saldo: " + saldo);
        }
    }

}