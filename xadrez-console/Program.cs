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
                PartidaDeXadrez partida = new PartidaDeXadrez();
                while (!partida.terminada)
                {
                    try
                    {
                        Console.Clear();
                        Tela.imprimirPartida(partida);

                        Console.WriteLine();
                        Console.Write("Origem : ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();// Ler a posição e transforma ela para posição de matriz
                        partida.validarPosicaoDeOrigem(origem);

                        bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();


                        Console.Clear();//LIMPA A TELA
                        Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);
                        Console.WriteLine();
                        Console.Write("Destino : ");
                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeDestino(origem, destino);
                        partida.realizaJogada(origem, destino);// método
                    }
                    catch(TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }

                }
                Console.Clear();
                Tela.imprimirPartida(partida);

                /* PosicaoXadrez pos = new PosicaoXadrez('c', 7);
                 Console.WriteLine(pos);
                 Console.WriteLine(pos.toPosicao());*/


            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();

        }
    }
}
