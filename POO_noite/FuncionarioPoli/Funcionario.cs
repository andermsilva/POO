using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FuncionarioPoli
{
    public class Funcionario
    {

        protected int codigo;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        protected string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        
        protected double salario;
        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        protected string cargo;
        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }
        
        public Funcionario()
        {
            
        }
        public Funcionario(int cod, string nome, double salario,string cargo)
        {
            Codigo = cod;
            Nome = nome;
            Salario = salario;
            Cargo = cargo;
        }

        public virtual double MostrarSalario(){
            return Salario;
        }

        public virtual void MostrarFuncionario()
        {
                System.Console.Write($"Código:\t{Codigo}\nNome:\t{Nome}\nCargo: {Cargo}\n");
        }
        
        
    }
}