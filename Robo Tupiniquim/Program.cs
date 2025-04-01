namespace Robo_Tupiniquim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limiteAreaExploravelX, limiteAreaExploravelY;
            FuncoesRobo.EntradaDados(out limiteAreaExploravelX, out limiteAreaExploravelY);
            
            FuncoesRobo roboAlpha = FuncoesRobo.RoboAlpha(limiteAreaExploravelX, limiteAreaExploravelY);
            
            FuncoesRobo roboBeta = FuncoesRobo.RoboBeta(limiteAreaExploravelX, limiteAreaExploravelY);

            FuncoesRobo.ExibirResultado(roboAlpha, roboBeta);
        }


        
    }
}
