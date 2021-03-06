using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EX3.Classes
{
    public class Guerreiro : Personagem
    {
        public List<string> Habilidade { get; set; } 
        public Guerreiro(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level, List<string> habilidades) : base(nome, vida, mana, xp, inteligencia, forca, level)
        {
            Nome = nome;
            Vida = vida;
            Mana = mana;
            Xp = xp;
            Inteligencia = inteligencia;
            Forca = forca;
            Level = level;
            Habilidade = habilidades;
        }
/* Usando o conceito de polimorfismo, implemente o método lvlUp(), de
forma que o Mago ao subir de nível possua um aumento maior nos
atributos Mana e Inteligência e o Guerreiro possua um aumento maior nos
atributos Vida e Força. */

        public override void lvlUp()
        {
            Level++;
            Forca++;
        }

/* Implemente o método attack() de forma que siga a seguinte regra:
Guerreiro ⚔ : ( Força * Level ) + numeroRandomico( 0 até 300 ). */

        public int Attack()
        {
            Random randNum = new Random();
            int numRandonico = randNum.Next(0,300);
            return (Forca * Level) + numRandonico;
        }

        public void AprenderHabilidade(string habilidade)
        {
            Habilidade.Add(habilidade);
        }
    }
}
