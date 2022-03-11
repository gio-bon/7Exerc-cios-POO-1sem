using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EX3.Classes
{
    public abstract class Personagem
    {
        public string Nome { get; set; }
        public int Vida { get; set; }
        public int Mana { get; set; }
        public float Xp { get; set; }
        public int Inteligencia { get; set; }
        public int Forca { get; set; }
        public int Level { get; set; }
        public static int QtdPersons = 0;

        public Personagem(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level)
        {
            Nome = nome;
            Vida = vida;
            Mana = mana;
            Xp = xp;
            Inteligencia = inteligencia;
            Forca = forca;
            Level = level;
            QtdPersons++;
        }

        public virtual void lvlUp()
        {
            Level++;
        }

        public void ExibeQtdPersons()
        {
            Console.WriteLine($"Qtd de personagens criados: {Personagem.QtdPersons}");
        }
    }
}
