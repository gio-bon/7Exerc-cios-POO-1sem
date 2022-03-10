using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EX4.Classe
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }
}