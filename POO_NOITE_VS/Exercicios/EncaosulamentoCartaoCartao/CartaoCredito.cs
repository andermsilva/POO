using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.EncaosulamentoCartaoCartao
{
   public class CartaoCredito
    {
		private int numero;

		public int Numero
		{
			get { return numero; }
			set { numero = value; }
		}

		private int numSeg;

		public int NumSeg
		{
			get { return numSeg; }
			set { numSeg = value; }
		}

		private int anoVencimento;

		public int AnoVencimento
		{
			get { return anoVencimento; }
			set { anoVencimento = value; }
		}

		private string nome;

		public string Nome
		{
			get { return nome; }
			set { nome = value; }
		}

		private double saldo;

		public double Saldo
		{
			get { return saldo; }
			set { saldo = value; }
		}

		public void MostrarAtributos()
		{
            Console.WriteLine("Número: "+Numero);
            Console.WriteLine("Nome: "+Nome);
            Console.WriteLine("Ano Vencimento: "+anoVencimento);
            Console.WriteLine("Numero segurança: "+numSeg);
            Console.WriteLine("Saldo: "+Saldo);

        }

	}
}
