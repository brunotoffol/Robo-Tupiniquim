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
        public static void EntradaDados(out int limiteAreaExploravelX, out int limiteAreaExploravelY)
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Comandos: 'M' para avançar, 'E' girar para a esquerda, 'D' girar para a Direita.");
            Console.WriteLine("-------------------------------------------");
            Console.Write("Digite o tamanho da área de exploração desejada: ");
            string[] limites = Console.ReadLine().Split(' ');
            limiteAreaExploravelX = int.Parse(limites[0]);
            limiteAreaExploravelY = int.Parse(limites[1]);
        }
        public static void ExibirResultado(FuncoesRobo roboAlpha, FuncoesRobo roboBeta)
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"Posição final do robô: {roboAlpha.eixoX} {roboAlpha.eixoY} {roboAlpha.direcao}");
            Console.WriteLine($"Posição final do robô: {roboBeta.eixoX} {roboBeta.eixoY} {roboBeta.direcao}");
            Console.ReadLine();
        }
        public static FuncoesRobo RoboAlpha(int limiteAreaExploravelX, int limiteAreaExploravelY)
        {
            Console.WriteLine("-------------------------------------------");
            Console.Write("Digite as coordenadas iniciais do primeiro robô: ");
            string posicaoInicialRoboAlpha = Console.ReadLine();
            Console.WriteLine("-------------------------------------------");

            FuncoesRobo roboAlpha = new FuncoesRobo(posicaoInicialRoboAlpha, limiteAreaExploravelX, limiteAreaExploravelY);

            Console.Write("Digite a sequência de comandos para o primeiro robô: ");
            string comandosRoboAlpha = Console.ReadLine();

            roboAlpha.Movimento(comandosRoboAlpha);
            return roboAlpha;
        }
        public static FuncoesRobo RoboBeta(int limiteAreaExploravelX, int limiteAreaExploravelY)
        {
            Console.WriteLine("-------------------------------------------");
            Console.Write("Digite as coordenadas iniciais do segundo robô: ");
            string posicaoInicialRoboBeta = Console.ReadLine();
            Console.WriteLine("-------------------------------------------");

            FuncoesRobo roboBeta = new FuncoesRobo(posicaoInicialRoboBeta, limiteAreaExploravelX, limiteAreaExploravelY);

            Console.Write("Digite a sequência de comandos para o segundo robô: ");
            string comandosRoboBeta = Console.ReadLine();
            roboBeta.Movimento(comandosRoboBeta);
            return roboBeta;
        }
    }
}
