using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_noite
{
    public class  Adicao : Operatios
    {
        protected int Num1 { get; set; }
        protected int Num2 { get; set; }

public Adicao(int n1, int n2){
    this.Num1 = n1;
    this.Num2 = n2;
}
        public void Execute(){

            System.Console.WriteLine(this.Num1 + this.Num2);
        }

       
    }
}