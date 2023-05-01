using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaProduto
{
    public class Perecivel : Produto
    {
        public string Data_Validade { get; set; }
        public string Data_Fabricacao { get; set; }

        public int Lote { get; set; }

       public Perecivel()
        {
            
        }
        public Perecivel(
            int cod, string nome,
            double preco,string dtv,
            string dtf) : base(cod,nome,preco){

            Data_Validade = dtv;
            Data_Fabricacao = dtf;
        }

        public void Mostrar(){
            base.Mostrar();
            System.Console.WriteLine($"Validade: {Data_Validade}\tFabricação: {Data_Fabricacao} \tLote: {Lote}");

        }
    }

}