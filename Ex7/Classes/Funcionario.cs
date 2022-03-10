using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex7.Classes
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Salario { get; set; }

        public abstract double Bonificacao();
    }
}