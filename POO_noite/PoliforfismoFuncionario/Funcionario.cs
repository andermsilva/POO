using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoliforfismoFuncionario
{
    public class Funcionario
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }
        public double Salario { get; set; }

       
        public Funcionario(int cod, string nome, double salario)
        {

            Codigo = cod;
            Nome = nome;
            Salario = salario;
        }

        public virtual double CalcularBonificao(){
            return Salario * 10/100;
        }
    }
}