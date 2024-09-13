using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstraindo_Um_Curso_Com_POO.Models
{
    public class Aluno
    {
        public Aluno(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
        private string _nome;
        public string Nome 
        {
            get => _nome;
            
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio.");
                }

                _nome = value;
            } 
        }
        private int _idade;
        public int Idade 
        {
            get => _idade;
            
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser negativa.");
                }

                _idade = value;
            } 
        }
    }
}
