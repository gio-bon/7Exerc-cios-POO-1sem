using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EX2.Classes
{
    public interface CalcularImposto
    {
/* calculaImposto( ): método para calcular imposto sobre um
produto com a seguinte regra:
• Livros:
1. Se o livro for de tema = “educativo” não se deve cobrar
imposto, retornar 0.
2. Caso seja de qualquer outro tema, calcular imposto de 10%
sobre o preço do livro.
• Video Game:
1. Se o vídeo game for usado, calcular imposto de 25% sobre
o preço do videogame.
2. Se o vídeo game não for usado, calcular imposto de 45%
sobre o preço do videogame. */
        public double calculaImposto();
    }
}