using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataFuncionario
{
    public class Dependente
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }

        public int Idade { get; set; }


        public Dependente(int cod, string nome, int idade)
        {
            Codigo = cod;
            Nome = nome;
            Idade = idade;
        }

        public bool verificarMaioridade()
        {

            if (Idade > 17)
            {
                return true;
            }

            return false;
        }

        public void Mostrar(){

            System.Console.WriteLine("Código: "+Codigo+" Nome: "+Nome+" Idade: "+Idade);
        }
    }
}