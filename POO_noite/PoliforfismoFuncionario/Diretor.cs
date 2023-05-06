using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoliforfismoFuncionario
{
    public class Diretor : Funcionario
    {
        
        public Diretor(int cod, string nome, double salario) :base(cod,nome,salario)
        {}

        public override double CalcularBonificao()
        {
            return base.CalcularBonificao() + 1000;
             
        }

    }
}