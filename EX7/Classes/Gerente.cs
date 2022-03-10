using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex7.Classes
{
    public class Gerente : Funcionario
    {
        public override double Bonificacao()
        {
            return Salario + 10000;
        }
        public Gerente(string nome, int idade, double salario)
        {
            Nome = nome;
            Idade = idade;
            Salario = salario;
        }
    }
}