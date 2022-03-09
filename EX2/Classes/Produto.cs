using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EX2.Classes
{
    public abstract class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }   
        public int Qtd { get; set; }

        public Produto(string nome, double preco, int qtd)
        {
            Nome = nome;
            Preco = preco;
            Qtd = qtd;
        }
    }
}