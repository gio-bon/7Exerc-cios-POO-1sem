using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EX1.Classes
{
    public class Veiculo
    {
        public int velocidade { get; protected set; }
        public int litrosCombustivel { get; protected set; }
        public string cor { get; set; }
        public bool estado { get; protected set; }
        public Veiculo()
        {
            velocidade = 0;
            litrosCombustivel = 20;
            cor = "preta";
            estado = true;
        }

/* acelerar(): este método acrescenta um valor de 20 no atributo velocidade.
abastecer(int combustivel): recebe como parâmetro uma quantidade de
combustível e atribui a listrosCombustivel. OBS O limite do tanque de
combustível é de 60 litros, validar para não ultrapassar. */
        public void Acelerar()
        {
            velocidade += 20;
        }

        public bool Abastecer(int combustivel)
        {
            if((litrosCombustivel < 60) && ((litrosCombustivel + combustivel) <= 60))
            {
                litrosCombustivel += combustivel;
                return true;
            }
            Console.WriteLine($"O tanque está cheio ou vai ficar.");
            return false;
        }
/* frear(): a cada chamada do método diminui a velocidade em 20. Não
aceitar a chamada do método se o veiculo estiver parado. */
        public bool Frear()
        {
            if (velocidade > 20)
            {
                velocidade -= 20;
                return true;
            }
            else if(velocidade > 0 && velocidade <= 20)
            {
                velocidade = 0;
                return true;
            }
            Console.WriteLine($"O carro está parado.");
            return false;
        }
// pintar(String cor): recebe uma cor como parâmetro e altera o atributo.
        public void Pintar(string novaCor)
        {
            cor = novaCor;
        }
//ligar(): Verifica se o veículo já se encontra ligado, caso não, liga o carro.
        public bool Ligar()
        {
            if (estado == false)
            {
                estado = true;
                return true;
            }
            Console.WriteLine($"O carro já está ligado.");
            return false;
        }
/*desligar(): Verifica se o veículo já se encontra desligado, caso não, desliga
o carro. Não permitir que desligue o veículo com (velocidade > 0. */
        public bool Desligar()
        {
            if (estado == true && velocidade == 0)
            {
                estado = false;
                return true;
            }
            Console.WriteLine($"O carro já está desligado ou em velocidade");
            return false;
        }
    }
}