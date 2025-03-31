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
            
            Console.WriteLine("-------------------------------------------");
            Console.Write("Digite as coordenadas iniciais do robô: ");
            string posicaoInicial = Console.ReadLine();
            Console.WriteLine("-------------------------------------------");


            FuncoesRobo robo = new FuncoesRobo(posicaoInicial, limiteAreaExploravelX, limiteAreaExploravelY);

            Console.Write("Digite a sequência de comandos para o robô: ");
            string comandos = Console.ReadLine();

            robo.Movimento(comandos);

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"Posição final do robô: {robo.eixoX} {robo.eixoY} {robo.direcao}");
            Console.ReadLine();
        }
    }
}
