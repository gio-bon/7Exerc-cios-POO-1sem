using System;
using EX2.Classes;

namespace MyApp // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Livro lordRings = new Livro("O Senhor dos Anéis", 390.90, 1, "J. R. R. Tolkien", "ficcao", 500);
      Console.WriteLine($"{lordRings.Preco}");
      Console.WriteLine(lordRings.calculaImposto());

      VideoGame ps7 = new VideoGame("Playstation 7", 6500.90, 1, "Sony", "StW-2022", false);
      Console.WriteLine($"{ps7.IsUsado}");
      Console.WriteLine(ps7.calculaImposto());
    }
  }
}