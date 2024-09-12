using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstraindo_Um_Curso_Com_POO.Models
{
    public class Pessoa
    {
        public Pessoa(string nome, string sobrenome, int idade)
        {
            Nome = nome;
            Sobrenome = sobrenome;
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
        private string _sobrenome;
        public string Sobrenome 
        {
            get => _sobrenome;
            
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O sobrenome não pode ser vazio.");
                }

                _sobrenome = value;
            } 
        }
        public string NomeCompleto => $"{Nome} {Sobrenome}";
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
