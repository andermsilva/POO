using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoliforfismoFuncionario
{
    public class Secretaria : Funcionario
    {
        public int NumSec { get; set; }
       
        public Secretaria(int cod, string nome, double salario,int ns)
        :base(cod,nome,salario)
        {
            NumSec = ns;
        }

        /* public override CalcularBonicacao(){
            return base.CalcularBonificao();
        }
         */
    }
}