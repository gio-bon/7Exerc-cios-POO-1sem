using System;
using EX3.Classes;

namespace MyApp // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
      List<string> habIniciaisGuerreiro = new List<string> {"Porradeiro"};
      Guerreiro xena = new Guerreiro("Xena",100, 100, 100, 100, 500, 1, habIniciaisGuerreiro);
      xena.ExibeQtdPersons();
      xena.AprenderHabilidade("Voadora");

      foreach (var item in xena.Habilidade)
      {
        Console.WriteLine($"{item}");
      }

      Console.WriteLine(xena.Attack());

      xena.lvlUp();
      Console.WriteLine($"{xena.Level}")

      /* Mago merlin = new Mago("Merlin",50,200,100,500,100,1);
      merlin.ExibeQtdPersons(); */

    }
  }
}
