using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstraindo_Um_Curso_Com_POO.Models
{
    public class Curso
    {
        public Curso(string nome)
        {
            Nome = nome;
        }
        private string _nome;
        public string Nome
        {
            get => _nome;

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome do curso não pode ser vazio.");
                }

                _nome = value;
            }
        }
        public List<Aluno> Aluno { get; set; }
        public List<DateTime> Data { get; set; }
        public List<int> Matricula { get; set; }

        public void AdicionarAluno(int numeroMatricula)
        {
            Console.WriteLine("Digite o nome, o sobrenome e a idade do novo(a) aluno(a).");
            string nome = Console.ReadLine();
            int idade = Convert.ToInt32(Console.ReadLine());

            Aluno p = new Aluno(nome, idade);

            Aluno.Add(p);
            Console.WriteLine($"\nAluno(a) {p.Nome} foi adicionado(a) com sucesso!");

            Matricula.Add(numeroMatricula);
            Console.WriteLine($"Seu número de matrícula é {numeroMatricula}");

            DateTime data = DateTime.Now;
            Data.Add(data);

            Console.WriteLine("\nPressione 'Enter' para continuar...");
            Console.ReadLine();
            Console.Clear();
        }

        public void RemoverAluno(int numeroMatricula)
        {
            Console.WriteLine("Digite o nome, o sobrenome e a matrícula para remover o(a) aluno(a).");
            string nome = Console.ReadLine();
            int idade = Convert.ToInt32(Console.ReadLine());

            Aluno p = new Aluno(nome, idade);

            Aluno.Remove(p);
            Console.WriteLine($"\nAluno(a) {p.Nome} foi removido(a) com sucesso!");

            DateTime data = DateTime.Now;
            Data.Add(data);

            Console.WriteLine("\nPressione 'Enter' para continuar...");
            Console.ReadLine();
            Console.Clear();
        }

        public void ListarAlunos()
        {
            Console.WriteLine(@"
=====================================================================           
|Nome                |Número da matrícula         |Data da matrícula| 
=====================================================================");

            for (int cont = 0; cont < Aluno.Count; cont++)
            {
                Console.WriteLine($"|{Aluno[cont].Nome}           |{Matricula[cont]}                             |{Data[cont].ToString("dd/MM/yyyy HH:mm")} |");
                Console.WriteLine("---------------------------------------------------------------------");
            }

            Console.WriteLine("\nPressione 'Enter' para continuar...");
            Console.ReadLine();
            Console.Clear();
        }

        public void ObrterQuantidadeDeAlunoMatriculados()
        {
            Console.WriteLine("\nQuantidade de alunos matriculados:");
            Console.WriteLine(Aluno.Count);

            Console.WriteLine("\nPressione 'Enter' para continuar...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
