using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataFuncionario
{
    public class Comissionado : Funcionario
    {
        public double Porcentagem { get; set; }

        public Comissionado(int cod,string nome,double salario,double percent):base(cod,nome,salario)
        {

            Porcentagem = percent;
        }
        public override  double CalcucularSalario(int diasUteis)
        {
            return Salario += Salario / 30 * diasUteis * Porcentagem;
    

        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.Write($"Porcentagem: {Porcentagem:N}%\n");
        }
    }
}