using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robo_Tupiniquim
{
    class FuncoesRobo
    {
        //variáveis do plano cartesiano (x,y) onde nosso robo vai andar
        public int eixoX;
        public int eixoY;
        //Direcao Cardinal de movimento do robo
        public string direcao;

        //Entrada dos valores
        public FuncoesRobo(string localizacao)
        {
            Int32.TryParse(localizacao.Split(' ')[0], out eixoX);
            Int32.TryParse(localizacao.Split(' ')[1], out eixoY);
            direcao = localizacao.Split(' ')[2];
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
                    eixoY += 1;
                    break;
                case "L":
                    eixoX += 1;
                    break;
                case "S":
                    eixoY -= 1;
                    break;
                case "O":
                    eixoX -= 1;
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
