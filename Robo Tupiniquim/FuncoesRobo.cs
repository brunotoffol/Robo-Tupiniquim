using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robo_Tupiniquim
{
    class FuncoesRobo
    {

        public int eixoX;
        public int eixoY;

        public string direcao;

        private int valorMaximoX;
        private int valorMaximoY;
        public FuncoesRobo(string localizacao, int limiteAreaExploravelX, int limiteAreaExploravelY)
        {
            Int32.TryParse(localizacao.Split(' ')[0], out eixoX);
            Int32.TryParse(localizacao.Split(' ')[1], out eixoY);
            direcao = localizacao.Split(' ')[2];

            valorMaximoX = limiteAreaExploravelX;
            valorMaximoY = limiteAreaExploravelY;
        }
        public void GirarParaDireita()
        {
            switch (direcao)
            {
                case "N":
                    direcao = "L";
                    break;
                case "L":
                    direcao = "S";
                    break;
                case "S":
                    direcao = "O";
                    break;
                case "O":
                    direcao = "N";
                    break;
            }
        }
        public void GirarParaEsquerda()
        {
            switch (direcao)
            {
                case "N":
                    direcao = "O";
                    break;
                case "O":
                    direcao = "S";
                    break;
                case "S":
                    direcao = "L";
                    break;
                case "L":
                    direcao = "N";
                    break;

            }
        }
        public void MoverParaFrente()
        {
            switch (direcao)
            {
                case "N":
                    if (eixoY + 1 <= valorMaximoY)
                        eixoY += 1;
                    else
                        Console.WriteLine("\nAtenção! O robô saiu dos limites estabelecidos!");
                    break;
                case "L":
                    if (eixoX + 1 <= valorMaximoX)
                        eixoX += 1;
                    else
                        Console.WriteLine("Atenção! O robô saiu dos limites estabelecidos!");
                    break;
                case "S":
                    if (eixoY - 1 >= 0)
                        eixoY -= 1;
                    else
                        Console.WriteLine("Atenção! O robô saiu dos limites estabelecidos!");
                    break;
                case "O":
                    if (eixoX - 1 >= 0)
                        eixoX -= 1;
                    else
                        Console.WriteLine("Atenção! O robô saiu dos limites estabelecidos!");
                    break;
                default:
                    break;
            }

        }
        public void Movimento(string comandoRobo)
        {
            char[] entradaComandos = comandoRobo.ToCharArray();

            for (int i = 0; i < entradaComandos.Length; i++)
            {
                switch (entradaComandos[i])
                {
                    case 'E':
                        GirarParaEsquerda();
                        break;

                    case 'D':
                        GirarParaDireita();
                        break;
                    case 'M':
                        MoverParaFrente();
                        break;
                    default:
                        break;
                }

            }

        }
    }
}
