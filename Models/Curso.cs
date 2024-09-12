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
        public List<Pessoa> Aluno { get; set; }
        public List<DateTime> Data { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Aluno.Add(aluno);
            Console.WriteLine($"Aluno(a) {aluno} foi adicionado(a) com sucesso!");
        
            DateTime data = DateTime.Now;
            Data.Add(data);

            Console.Clear();
        }

        public void RemoverAluno(Pessoa aluno)
        {
            Aluno.Remove(aluno);
            Console.WriteLine($"Aluno(a) {aluno} foi removido(a) com sucesso!");

            DateTime data = DateTime.Now;
            Data.Add(data);

            Console.Clear();
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do {Nome}");

            for (int cont = 0; cont < Aluno.Count; cont++)
            {
                Console.WriteLine($"{cont + 1} - {Aluno[cont].NomeCompleto} - {Data[cont]}");
            }

            Console.Clear();
        }

        public void ObrterQuantidadeDeAlunoMatriculados()
        {
            Console.WriteLine("Quantidade de alunos matriculados:");
            Console.WriteLine(Aluno.Count);

            Console.Clear();
        }
    }
}
