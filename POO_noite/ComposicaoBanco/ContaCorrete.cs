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

        public double Limite { get; set; }

        public double ChequeEspecial { get; set; }


        public ContaCorrete()
        {

        }
        public void Depositar(double valor)
        {
            double dif =0;
            double restante =0;
            
            System.Console.WriteLine("================ Deposito em C/C: " + Numero + " =================");
            if (valor > 0)
            {
                if (ChequeEspecial < Limite)
                {
                    if( valor+ChequeEspecial > Limite){
                        dif = Limite - ChequeEspecial;
                        ChequeEspecial += dif;
                        restante = valor - dif;
                        Saldo+= valor + restante;

                        System.Console.WriteLine($"restante: {restante} dif: {dif}  ");
                    }else{

                        ChequeEspecial += valor;
                        Saldo+=valor;
                    }
                    
                       
                    
                    System.Console.WriteLine($"-Deposito, realizado com sucesso...{valor:C}  {restante}");
                }
                else
                { 
                    Saldo += valor;
                    System.Console.WriteLine($"+Deposito, realizado com sucesso...{valor:C}");

                }
            }
            else
            {
                System.Console.WriteLine("Nenhum deposito efetuado...");
            }
            System.Console.WriteLine(" ");
        }



        public ContaCorrete(int num, double saldo, double cheque)
        {
            Numero = num;
            Saldo = saldo;
            ChequeEspecial = cheque;
            Limite = cheque;
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
                    System.Console.WriteLine($"Transação realizada com sucesso... {valor:C}  ");
                    System.Console.WriteLine($"Saldo atual....................... {Saldo:C}  ");



                }
                else
                {

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
            System.Console.WriteLine($"Extrato consolidado....... {total:C}");
        }


        public void MostrarConta()
        {
            System.Console.WriteLine("\n================== Conta Corrente ===================");
            System.Console.WriteLine("Número C/C: " + Numero);
            System.Console.WriteLine($"Saldo: {Saldo:C}\tEspecial: {ChequeEspecial:C} ");

            System.Console.WriteLine(" ");

        }


    }

}