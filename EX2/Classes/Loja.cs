using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EX2.Classes
{
    public class Loja
    { 
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public List<Livro> Livros { get; set; }
        public List<VideoGame> VideoGames { get; set; }
    public Loja(string nome, string cnpj, List<string> livros, List<object> videogames)
        {
            Nome = nome;
            CNPJ = cnpj;
            Livros = livros;
            VideoGames = videogames;
        }
/* listaLivros( ): lista todos os livros que uma loja tem, caso a
lista de livros seja vazia, mostrar no console "A loja não tem
livros no seu estoque." . */
    public void ListaLivros()
    {
        foreach (var item in collection)
        {
            
        }
    }
/* listaVideoGames ( ): lista todos os vídeo games que uma
loja tem, caso a lista de vídeo games seja vazia, mostrar no
console "A loja não tem video-games no seu estoque.". */
    public void ListaVideoGames()
    {
        foreach (var item in collection)
        {
            
        }
    }
/* calculaPatrimonio( ): Soma os preços de todos produtos da
loja e retorna este valor como double. */
    public double CalculaPatrimonio()
    {

    }
    
    }
}