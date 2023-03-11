using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorConta
{
    public class Conta
    {
        public int Numero { get; set; }

        public string Titular { get; set; }

        public double Saldo { get; set; }

        public static int Contador { get; set; }

        
        public Conta()
        {
            Contador ++;
        }
        static Conta(){
            Contador = 23;
        }
        public Conta(int numero)
        {

            Numero = numero;
            Contador ++;
        }
        public Conta(int numero, string tit, double saldo)
        {

            Numero = numero;
            Titular = tit;
            Saldo = saldo;
            Contador ++;
        }

        public void Mostrar()
        {
            ClasseEstatica.MostrarFrase();
            System.Console.WriteLine("Numero: " + Numero);
            System.Console.WriteLine("Titular: " + Titular);
            System.Console.WriteLine($"Saldo: {Saldo:C}");
        }

    }
}