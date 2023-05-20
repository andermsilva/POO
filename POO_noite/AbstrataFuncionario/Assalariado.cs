using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataFuncionario
{
    public class Assalariado : Funcionario
    {

        public Assalariado(int cod, string nome, double salario) : base(cod, nome, salario)
        {

        }

        public override double CalcucularSalario(int diasUteis)
        {
            return Salario = Salario / 30 * diasUteis;
        }

    }
}