using System;
using tabuleiro;
using xadrez;

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

            Tabuleiro tab = new Tabuleiro(8, 8);
           
            
            tab.colocarPeca(new Torre(tab,Cor.Preta), new Posicao(0, 0));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

            Tela.imprimirTabuleiro(tab);


            Posicao P;
            P = new Posicao(3, 4);
            Console.WriteLine("Posição : "+P);
            Console.ReadLine();
        }
    }
}
