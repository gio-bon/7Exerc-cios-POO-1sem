using System;
using Ex7.Classes;

namespace MyApp // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Gerente heitor = new Gerente("Heitor", 33, 10000);
      Console.WriteLine($"{heitor.Idade}");

      Console.WriteLine($"Bonificação Gerente {heitor.Bonificacao()}"); 
      Vendedor charlinho = new Vendedor("Charlinho", 22, 5000);

      Console.WriteLine($"Bonificação Vendedor {charlinho.Bonificacao()}");

      Supervisor joselito = new Supervisor("Joselito", 44, 6500);

      Console.WriteLine($"Bonificação Supervisor {joselito.Bonificacao()}");
    }
  }
}