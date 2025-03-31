namespace Robo_Tupiniquim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Comandos: 'M' para avançar, 'E' girar para a esquerda, 'D' girar para a Direita.");
            Console.WriteLine("-------------------------------------------");
            Console.Write("Digite as coordenadas iniciais do robô: ");
            string posicaoInicial = Console.ReadLine();

            FuncoesRobo robo = new FuncoesRobo(posicaoInicial);

            Console.Write("Digite a sequência de comandos para o robô: ");
            string comandos = Console.ReadLine();

            robo.Movimento(comandos);

            Console.WriteLine($"Posição final do robô: {robo.eixoX} {robo.eixoY} {robo.direcao}");
            Console.ReadLine();
        }
    }
}
