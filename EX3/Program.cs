using System;
using EX3.Classes;

namespace MyApp // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Guerreiro xena = new Guerreiro("Xena",100, 100, 100, 100, 500, 1);
      xena.ExibeQtdPersons();

      Mago merlin = new Mago("Merlin",50,200,100,500,100,1);
      merlin.ExibeQtdPersons();

    }
  }
}