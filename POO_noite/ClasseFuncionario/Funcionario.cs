using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseFuncionario
{
    public class Funcionario
    {
        public int codigo;
        public string nome;
        public string cargo;
        public double salario;

        public void MostrarAtributos(){
            System.Console.WriteLine("Código: "+codigo);
            System.Console.WriteLine("Nome: "+nome);
            System.Console.WriteLine("Cargo: "+cargo);
            System.Console.WriteLine("Salário: "+salario);
        }

    }
}