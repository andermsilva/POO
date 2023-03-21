using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoContaVetor
{
       public class Cliente
    {
        public string Nome { get; set; }

        public int Cpf { get; set; }

        public int Rg { get; set; }

        public Endereco Enderco_ { get; set; }

        public Cliente()
        {
            
        }
        public Cliente(string nome, int cpf,int rg, Endereco ender)
        {
            Nome =nome;
            Cpf = cpf;
            Rg = rg;
            Enderco_ = ender;
        }
        public Cliente(string nome, int cpf,int rg)
        {
            Nome =nome;
            Cpf = cpf;
            Rg = rg;
            
        }

        public void Mostrar(){
            System.Console.Write("Nome: "+Nome+"\t|Cpf: "+Cpf+"\t|Rg: "+Rg+"\n");

            //Enderco_.MostrarEndereco();
        }
    }
}