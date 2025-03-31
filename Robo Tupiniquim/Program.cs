namespace Robo_Tupiniquim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Comandos: 'M' para avançar, 'E' girar para a esquerda, 'D' girar para a Direita.");
            Console.WriteLine("-------------------------------------------");
            Console.Write("Digite o tamanho da área de exploração desejada: ");
            string[] limites = Console.ReadLine().Split(' ');
            int limiteAreaExploravelX = int.Parse(limites[0]);
            int limiteAreaExploravelY = int.Parse(limites[1]);
            
            //Primeiro Robo
            Console.WriteLine("-------------------------------------------");
            Console.Write("Digite as coordenadas iniciais do primeiro robô: ");
            string posicaoInicialRoboAlpha = Console.ReadLine();
            Console.WriteLine("-------------------------------------------");

            FuncoesRobo roboAlpha = new FuncoesRobo(posicaoInicialRoboAlpha, limiteAreaExploravelX, limiteAreaExploravelY);

            Console.Write("Digite a sequência de comandos para o primeiro robô: ");
            string comandosRoboAlpha = Console.ReadLine();

            roboAlpha.Movimento(comandosRoboAlpha);

            //Segundo Robo

            Console.WriteLine("-------------------------------------------");
            Console.Write("Digite as coordenadas iniciais do segundo robô: ");
            string posicaoInicialRoboBeta = Console.ReadLine();
            Console.WriteLine("-------------------------------------------");

            FuncoesRobo roboBeta = new FuncoesRobo(posicaoInicialRoboBeta, limiteAreaExploravelX, limiteAreaExploravelY);

            Console.Write("Digite a sequência de comandos para o segundo robô: ");
            string comandosRoboBeta = Console.ReadLine();
            roboBeta.Movimento(comandosRoboBeta);           


            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"Posição final do robô: {roboAlpha.eixoX} {roboAlpha.eixoY} {roboAlpha.direcao}");
            Console.WriteLine($"Posição final do robô: {roboBeta.eixoX} {roboBeta.eixoY} {roboBeta.direcao}");
            Console.ReadLine();
        }
    }
}
