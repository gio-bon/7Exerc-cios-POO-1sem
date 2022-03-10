using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex7.Classes
{
    public class Vendedor : Funcionario
    {
        public override double Bonificacao()
        {
            return Salario + 3000;
        }

        public Vendedor(string nome, int idade, double salario)
        {
            Nome = nome;
            Idade = idade;
            Salario = salario;
        }
    }
}