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

            try
            {

                /*Tabuleiro tab = new Tabuleiro(8, 8);


                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 9));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));

                Tela.imprimirTabuleiro(tab);*/

                PosicaoXadrez pos = new PosicaoXadrez('c', 7);
                Console.WriteLine(pos);
                Console.WriteLine(pos.toPosicao());

               
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
