using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class Sequencia
    {
        public List<int> lista = new List<int>();

        public bool isFibo { get; set; }
        public void Fibon(int numero)
        {
            int fib = 1;
            int aux = 0;
            int result = 0;
            int i = 0;

            while (i <= numero + 2)
            {
                if (i == 0)
                {

                    lista.Add(0);
                }
                if (i == 1)
                {
                    aux = 0;
                }
                else if (i == 2)
                {
                    fib = 1;
                }
                else
                {
                    result = aux + fib;
                    lista.Add(result);
                    aux = fib;
                    fib = result;
                    if (fib == numero)
                    {
                        i = numero + 2;
                        isFibo = true;
                    }
                    if (result > numero)
                        break;
                }
                i++;
            }

        }
    }
}