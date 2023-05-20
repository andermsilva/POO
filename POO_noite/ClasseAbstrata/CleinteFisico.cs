using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseAbstrata
{
    public class CleinteFisico : Cliente
    {
        public string Cpf { get; set; }

        public CleinteFisico(int cod, string nome,string cpf):base(cod,nome)
        {
            Cpf = cpf;
        }

        public override void Mostrar()
        {
            Console.WriteLine("Código: "+Codigo+ "\nNome: "+Nome+"\tCpf: "+Cpf);
        }
    }
}