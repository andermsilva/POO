using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataFuncionario
{
    public class Departamento
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }

        public List<Funcionario> VetF { get; set; }

        public Departamento(int codigo, string desc)
        {
            Codigo = codigo;
            Descricao = desc;

            VetF = new List<Funcionario>();

        }

        public void Admitir(Funcionario f)
        {
            VetF.Add(f);
        }

        public void DemitirFuncionario(int codigo)
        {
            System.Console.WriteLine("\nLista de funcionários do departamento " + Descricao);
            for (int i = 0; i < VetF.Count; i++)
            {
                Funcionario f = VetF.ElementAt<Funcionario>(i);
                if (f.Codigo == codigo)
                    VetF.Remove(f);

            }
        }

        public void ListarFuncionarios()
        {

            for (int i = 0; i < VetF.Count; i++)
            {
                Funcionario f = VetF.ElementAt<Funcionario>(i);
                f.Mostrar();

            }
            System.Console.WriteLine();

        }

        public double CalcularFolha(int diasUteis)
        {

            double folha = 0;

            for (int i = 0; i < VetF.Count; i++)
            {
                Funcionario f = VetF.ElementAt<Funcionario>(i);

                folha = folha + f.CalcucularSalario(30);
            }

            return folha;
        }

        public void MostrarQtdeDependentesFuncuonario()
        {
            System.Console.WriteLine(Descricao);
            for (int i = 0; i < VetF.Count; i++)
            {
                Funcionario f = VetF.ElementAt<Funcionario>(i);
                System.Console.WriteLine($"O funcionário: {f.Nome} tem {f.CalcularTotalDependente()} Dependente(s)");

            }
            System.Console.WriteLine();

        }
    }
}