using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class ContaCorrete
    {
        public int Numero { get; set; }
        public double Saldo { get; set; }

        public double ChequeEspecial { get; set; }

        public void Depositar(double valor)
        {
            System.Console.WriteLine("================ Deposito em C/C: " + Numero + " =================");
            if (valor > 0)
            {
                if (ChequeEspecial <= 0)
                {
                    ChequeEspecial += valor;
                    System.Console.WriteLine($"Deposito, realizado com sucesso...{valor:C}");
                }
                else
                {
                    Saldo += valor;
                    System.Console.WriteLine($"Deposito, realizado com sucesso...{valor:C}");
                }
            }
            else
            {
                System.Console.WriteLine("Nenhum deposito efetuado...");
            }
            System.Console.WriteLine(" ");
        }

        public ContaCorrete() { }
        public ContaCorrete(int num, double saldo, double cheque)
        {
            Numero = num;
            Saldo = saldo;
            ChequeEspecial = cheque;
        }

        public void Sacar(double valor)
        {
            System.Console.WriteLine("============= Saque em C/C:" + Numero + " ================");
            System.Console.WriteLine($"Saque:................... {valor:C}");

            if (valor <= Saldo)
            {
                Saldo -= valor;
                System.Console.WriteLine($"Transação realizada com sucesso...{valor:C}");

            }
            else
            {
                if (valor <= (ChequeEspecial + Saldo))
                {
                    Saldo = Saldo - valor;
                    double aux = Saldo;
                    ChequeEspecial += aux;
                    System.Console.WriteLine($"Transação realizada com sucesso...{valor:C}  ");

                }
                else
                {
                    ChequeEspecial -= valor;
                    Saldo -= ChequeEspecial;
                    System.Console.WriteLine("Não foi possível realizar a transação...");

                }

            }
            System.Console.WriteLine(" ");
        }
        public void GerarExtrato()
        {
            System.Console.WriteLine("================= Extrato C/C: " + Numero + " ====================");
            System.Console.WriteLine($"Saldo:.................... {Saldo:C}");
            System.Console.WriteLine($"Especial:................. {ChequeEspecial:C}");
            double total = Saldo + ChequeEspecial;
            System.Console.WriteLine($"Extrato consololidadado... {total:C}");
        }


        public void MostrarConta()
        {
            System.Console.WriteLine("\n================== Informações da Conta ===================");
            System.Console.WriteLine("Número C/C: " + Numero);
            System.Console.WriteLine($"Saldo: {Saldo:C}\tEspecial: {ChequeEspecial:C}");

            System.Console.WriteLine(" ");

        }


    }

}