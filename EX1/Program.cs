using System;
using EX1.Classes;

namespace MyApp // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Veiculo carro = new Veiculo();

      //testes pra ver se tudo funciona
      Console.WriteLine(carro.Abastecer(20));
      carro.Abastecer(22);
      Console.WriteLine($"{carro.litrosCombustivel}");
      Console.WriteLine($"{carro.cor}");
      carro.Pintar("amarelo");
      Console.WriteLine($"{carro.cor}");
      Console.WriteLine($"{carro.velocidade}");
      carro.Acelerar();
      carro.Acelerar();
      Console.WriteLine($"{carro.velocidade}");
      Console.WriteLine(carro.Desligar());
      carro.Frear();
      carro.Frear();
      Console.WriteLine($"{carro.velocidade}");
      Console.WriteLine(carro.Desligar());
    }
  }
}