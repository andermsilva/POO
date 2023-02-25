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

        public void Aplicacao(double porcentagem){
            saldo = saldo +(saldo * porcentagem/100);
        }

        public bool Transferir(double valorTranferir, Conta objContaDestino)
        {
            if (saldo >= valorTranferir)
            {
                saldo = saldo - valorTranferir;
                objContaDestino.saldo += valorTranferir;

                return true;
            }

            return false;
        }
        public void Sacar(double valorSacar)
        {
            saldo = saldo - valorSacar;
        }
        public void Depositar(double valorDepositar)
        {
            saldo += valorDepositar;
        }

        public void MostrarAtributos()
        {
            System.Console.WriteLine("Número: " + numero);
            System.Console.WriteLine("Titular: " + titular);
            System.Console.WriteLine("Saldo: " + saldo);
        }

    }
}