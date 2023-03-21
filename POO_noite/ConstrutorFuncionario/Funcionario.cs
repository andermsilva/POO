using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorFuncionario
{
    public class Funcionario
    {
        public static int Codigo { get; set; }

        public string Nome { get; set; }
        public double Salario { get; set; }

        private double reajuste;

        public static int Contador { get; set; }

        //  ===================== CONSTRUTORES =============================

        static Funcionario()
        {

            Codigo = 100;
        }
        public Funcionario()
        {
            Codigo++;
            Contador++;
        }


        public Funcionario(string nome)
        {
            Codigo++;
            Nome = nome;
            Contador++;
        }
        public Funcionario(string nome, double salario)
        {
            Codigo++;
            Nome = nome;
            Salario = salario;
            Contador++;
        }

        public double Reajuste(double taxa)
        { 
            double tx = (Salario / 100) * taxa;
            Salario = Salario + tx;

            return tx;

        }
        public void MotrarFuncionario()
        {
            System.Console.WriteLine("Código: " + Codigo);
            System.Console.WriteLine("Nome: " + Nome);
            System.Console.WriteLine($"Salário: {Salario:C}");


        }
    }
}