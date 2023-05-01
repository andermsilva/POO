using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{
    //Classe derivada...
    public class ClienteFisico : Cliente
    {
        private string cpf;

        public string Cpf { get; set; }
        public int Rg { get; set; }

        public ClienteFisico()
        {
            
        }

        public ClienteFisico(int codigo,
                            string nome,
                            string endereco,
                            int rg, string cpf) :
                            base(codigo, nome, endereco)
        {
            Cpf = cpf;
            Rg = rg;

        }
        public void Mostrar()
        {
            base.Mostrar();
            System.Console.WriteLine("CPF: "+Cpf+ "\tRG: "+Rg);
        }
    }
}