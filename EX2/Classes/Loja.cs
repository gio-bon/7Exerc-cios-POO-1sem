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
    public Loja(string nome, string cnpj, List<Livro> livros, List<VideoGame> videogames)
        {
            Nome = nome;
            CNPJ = cnpj;
            Livros = livros;
            VideoGames = videogames;
        }
/* listaLivros( ): lista todos os livros que uma loja tem, caso a
lista de livros seja vazia, mostrar no console "A loja não tem
livros no seu estoque." . */
    public string ListaLivros()
    {
        if (Livros.Count == 0)
        {
            return "A loja não tem livros no seu estoque.";
        }
        foreach (var item in Livros)
        {
            Console.WriteLine($"{item.Nome}");
        }
    }
/* listaVideoGames ( ): lista todos os vídeo games que uma
loja tem, caso a lista de vídeo games seja vazia, mostrar no
console "A loja não tem video-games no seu estoque.". */
    public string ListaVideoGames()
    {
        if (VideoGames.Count == 0)
        {
            return "A loja não tem video-games no seu estoque.";
        }
        foreach (var item in VideoGames)
        {
            Console.WriteLine($"{item.Nome}");
        }
    }
/* calculaPatrimonio( ): Soma os preços de todos produtos da
loja e retorna este valor como double. */
    public double CalculaPatrimonio()
    {
        double somaLivros = 0;
        double somaGames = 0;

        if (VideoGames.Count != 0)
        {
            foreach (var item in VideoGames)
        {
            somaGames += item.Preco;
        }
        }
        if (Livros.Count != 0)
        {
            foreach (var item in Livros)
        {
            somaLivros += item.Preco;
        }
        }
        return somaLivros + somaGames;
    }
    
    }
}