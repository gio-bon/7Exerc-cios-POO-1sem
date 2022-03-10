using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex7.Classes
{
    public class Supervisor : Funcionario
    {
        public override double Bonificacao()
        {
            return Salario + 5000;
        }
        public Supervisor(string nome, int idade, double salario)
        {
            Nome = nome;
            Idade = idade;
            Salario = salario;
        }
    }
}