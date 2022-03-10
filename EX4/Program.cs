using System;
using EX4.Classe;

namespace MyApp // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {

/* Instancie o objeto e a Lista<Pessoa>, adicione os dados conforme a tabela
abaixo e por fim imprima o nome da pessoa mais velha. */
      Pessoa joao = new Pessoa("João", 15);
      Pessoa leandro = new Pessoa("Leandro", 21);
      Pessoa paulo = new Pessoa("Paulo", 17);
      Pessoa jessica = new Pessoa("Jéssica", 18);

      List <Pessoa> pessoas = new List<Pessoa>() {joao, leandro, paulo, jessica};

      var pMaisVelha = pessoas.OrderByDescending(x => x.Idade).ToList()[0];

      Console.WriteLine($"A pessoa mais velha é: {pMaisVelha.Nome}");
/* Aproveitando a questão anterior (4 - Exclua da Lista as pessoas com idade
inferior a 18 anos. E exiba a quantidade da lista antes e depois da
exclusão. Não reescreva o código do item 01. */
      for(int i = 0; i < pessoas.Count; i++)
      {
        if (pessoas[i].Idade < 18)
        {
          pessoas.Remove(pessoas[i]);
        }
/* Aproveitando – o seu código já escrito na questão 4 e na Questão 6 –
Consulte se o objeto Jessica existe na lista e exiba a sua idade. */
        if (pessoas[i].Nome.Contains("Jéssica"))
        {
          Console.WriteLine($"A Jéssica existe na Lista. Sua idade é {pessoas[i].Idade}");
        }
      }

      Console.WriteLine($"Exercício 5 - Pessoas restantes na lista");
      foreach (var item in pessoas)
      {
        Console.WriteLine($" Nome: {item.Nome} Idade: {item.Idade}");
      }

      }
  }
}