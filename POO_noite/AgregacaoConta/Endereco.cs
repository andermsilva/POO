using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoConta
{
    public class Endereco
    {
        public string Logradouro { get; set; }

        public string Numero { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public Endereco()
        {
            
        }

        public Endereco(string logr, string numero, string bairro, string cidade)
        {
            Logradouro = logr;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
        }


        public void MostrarEndereco(){
            System.Console.WriteLine("Rua: "+Logradouro+
                                    "\tNumero: "+Numero+"\tBairro: "+
                                    "\tCidade: "+Cidade);
        }
            
    }


}