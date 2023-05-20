using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAutenticavel
{
    public class Gerente :  Funcionario, IAutenticavel

    {
        public int Senha {get;set;}   

        public bool Autenticar(int senha){

            return Senha == senha;
        } 
    }
}