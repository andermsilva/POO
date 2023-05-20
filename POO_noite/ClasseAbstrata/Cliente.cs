using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseAbstrata
{
    public abstract class  Cliente
    {
        public int Codigo { get; set; }
        public string  Nome { get; set; }

        public Cliente(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
            
        }

        public abstract void Mostrar();
    }
}