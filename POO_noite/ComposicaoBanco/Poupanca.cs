using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class Poupanca
    {
        public int Numero { get; set; }
        
       public double Saldo { get; set; }

        public Poupanca(){
            
        }
        public Poupanca(int num,double saldo){
            Numero = num;
            Saldo = saldo;
        }
        public void Depositar(double valor){
            if(valor > 0){
                Saldo += valor;
                System.Console.WriteLine($"Deposito realizado com sucesso...{valor:C} ");
            }else{
                System.Console.WriteLine("Não foi possível realizar o depósito...");
            }
        }
        public void Sacar(double valor){

            System.Console.WriteLine("============= Saque em C/Poupança:" + Numero + " ================");
            System.Console.WriteLine($"Saque:................... {valor:C}");

            if(valor <= Saldo){
                 Saldo -= valor;
                System.Console.WriteLine($"Transação realizada com sucesso... {Saldo:C}.");
                
            }else{
                System.Console.WriteLine("Não há saldo suficiente para a transação...");
               
            }
            //Saldo -= 50;
           System.Console.WriteLine(" ");
        }
        public void GerarRendimentos(){
            System.Console.WriteLine("Rendimentos C.Poupança "+Numero+":");

            System.Console.WriteLine($"Saldo Anterior:............... {Saldo:C}");
            double rend = Saldo*0.03;
            System.Console.WriteLine($"Rendimentos:.................. {rend:C}");

            Saldo += rend;
            System.Console.WriteLine($"Saldo Total:.................. {Saldo:C}");

        }

        public void MostrarPoupanca(){
            System.Console.WriteLine("================== Conta Poupnça ==================");
            System.Console.WriteLine("número Poupança: "+Numero);
            System.Console.WriteLine($"Saldo: {Saldo:C}");
        }

    }
}