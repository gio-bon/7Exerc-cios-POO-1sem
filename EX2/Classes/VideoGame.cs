using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EX2.Classes
{
    public class VideoGame : Produto, CalcularImposto
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public bool IsUsado { get; set; }
        public VideoGame(string nome, double preco, int qtd, string marca, string modelo, bool isUsado) : base(nome, preco, qtd)
        {
            Nome = nome;
            Preco = preco;
            Qtd = qtd;
            Marca = marca;
            Modelo = modelo;
            IsUsado = isUsado;
        }
/* 1. Se o vídeo game for usado, calcular imposto de 25% sobre
o preço do videogame.
2. Se o vídeo game não for usado, calcular imposto de 45%
sobre o preço do videogame. */ 
        public double calculaImposto()
        {
            if (IsUsado == true)
            {
                return Preco * 0.25;
            }
            return Preco * 0.45;
        }
    }
}