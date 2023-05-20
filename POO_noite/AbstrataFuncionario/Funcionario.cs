using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataFuncionario
{
    public abstract class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public List<Dependente> Filhos { get; set; }

        public Funcionario(int codigo, string nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
            Filhos = new List<Dependente>();
        }

        public abstract double CalcucularSalario(int diaUteis);

        public int CalcularTotalDependente()
        {

            return Filhos.Count;
        }
        public void AdicionarDependente(Dependente dep)
        {

            Filhos.Add(dep);
        }
        public void RemoverDependentesMaioridade(int cod)
        {

            foreach (Dependente item in Filhos)
            {
                if (item.Codigo == cod)
                {
                    if (item.verificarMaioridade())
                    {

                        Filhos.Remove(item);
                        break;
                    }
                }
                
               
            }

        }

        public void ListarDependentes()
        {
            if (Filhos.Count > 0)
            {
                Console.WriteLine("Dependentes cadastrados para: " + Nome + ":");
                foreach (Dependente item in Filhos)
                {
                    item.Mostrar();
                }
                System.Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Funcionário: "+Nome+" não pussui dependentes...");
            }

        }
        public virtual void Mostrar()
        {
            Console.WriteLine($"Código: {Codigo}\nNome: {Nome}\tSalario: {Salario:C}");
        }
    }
}