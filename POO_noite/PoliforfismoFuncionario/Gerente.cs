using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoliforfismoFuncionario
{
    public class Gerente : Funcionario
    {

        public Gerente(int cod, string nome, double salario) :base(cod,nome,salario)
        {}
         public override double CalcularBonificao(){

            return Salario * 15 /100;
        }

     
        
    }
}