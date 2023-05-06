using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FuncionarioPoli
{
    public class Horista : Funcionario
    {
        private double horas;
        public double Horas
        {
            get { return horas; }
            set { horas = value; }
        }


        public Horista()
        {

        }
        public Horista(int cod, string nome, double salario, string cargo, double horas)
        : base(cod, nome, salario, cargo)
        {
            Horas = horas;

        }

        public override double MostrarSalario()
        {
            base.MostrarSalario();
            if (Horas > 160)
            {

                Salario = Horas * 9.80;
                return Salario;
            }

            return Salario;
        }

        public override void MostrarFuncionario()
        {
            base.MostrarFuncionario();

            Console.WriteLine($"Horas Trabalhadas:\t{Horas}");
        }

    }

}