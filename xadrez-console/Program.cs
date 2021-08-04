using System;
using tabuleiro;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {

            // O sistema será dividio em 3 camadas:
            // Camada Tabuleiro( representação de um tabuleiro e as operações basicas),
            // Camada Jogo de Xadrez(Implementada a inteligencia do jogo de xadrez)
            // Camada de Aplicação(É uma aplicativo no modo console que vai consumir as outras duas camadas, interagir com o usuário e executar o jogo.
            Posicao P;
            P = new Posicao(3, 4);
            Console.WriteLine("Posição : "+P);
            Console.ReadLine();
        }
    }
}
