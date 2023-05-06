using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FuncionarioPoli
{
    public class Mensalista : Funcionario
    {

        public int Dia { get; set; }


        public Mensalista(int cod, string nome, double salario, string cargo, int dia)
        : base(cod, nome, salario, cargo)
        {

            Dia = dia;
        }

        public override double MostrarSalario()
        {

            if (Dia >= 30)
            {
                return Salario = 8 * Dia * 5.5;
                
            }
            return Salario = 8 * Dia * 5.5;

        }

        
        public override void MostrarFuncionario()
        {
           base.MostrarFuncionario();
          
            Console.WriteLine($"Frequencia:\t{Dia} Dias");
        }

    }
}