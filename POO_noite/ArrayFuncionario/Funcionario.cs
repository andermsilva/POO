using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayFuncionario
{
    public class Funcionario
    {

        public int codigo;
        public string nome;
        // public string cargo;
        public double salario;

        public void MostrarAtributos()
        {
            
            System.Console.WriteLine("Código: " + codigo);
            System.Console.WriteLine("Nome: " + nome);

            System.Console.WriteLine($"Salário: {salario:C}");
        }

        public void Aumento(double tx, Funcionario f)
        {

            // TODO
            if (f.salario < 300)
                f.salario += (f.salario / 100) * tx;
        }
    }
}