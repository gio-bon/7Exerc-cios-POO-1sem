using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EX2.Classes
{
    public class Livro : Produto, CalcularImposto
    {
        public string Autor { get; set; }
        public string Tema { get; set; }
        public int QtdPag { get; set; }
        public Livro(string nome, double preco, int qtd, string autor, string tema, int qtdPag) : base(nome, preco, qtd)
        {
            Nome = nome;
            Preco = preco;
            Qtd = qtd;
            Autor = autor;
            Tema = tema;
            QtdPag = qtdPag;
        }
/* 1. Se o livro for de tema = “educativo” não se deve cobrar
imposto, retornar 0.
2. Caso seja de qualquer outro tema, calcular imposto de 10%
sobre o preço do livro. */
        public double calculaImposto()
        {
            if (Tema == "educativo")
            {
                return 0.0;
            }
            return Preco * 0.1;
        }
    }
}