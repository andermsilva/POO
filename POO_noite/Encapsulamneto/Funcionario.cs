using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encapsulamneto
{
    public class Funcionario
    {
        private int codigo;
        private string nome;
        private double salario;


        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public double Salario { get; set; }

    }
}