using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{
    public class ClienteJuridico : Cliente
    {
        private int cnpj;
        public int Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        private int ie;
        public int Ie
        {
            get { return ie; }
            set { ie = value; }
        }



    }
}