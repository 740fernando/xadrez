﻿using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.colunas; j++)
                {

                    if (tab.peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        imprimirPeca(tab.peca(i, j));
                        Console.Write(" ");

                    }

                }

                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }
        public static PosicaoXadrez lerPosicaoXadrez()
        {
            string s = Console.ReadLine(); // ler o que o usuario digitar, uma LETRA e um NUMERO da posição de xadrez
            char coluna = s[0];// recebe o s na posição 0, ou seja, a LETRA
            int linha = int.Parse(s[1] + "");// recebe o s na posição 1, ou seja, o NUMERO obs: foi concatenado com o "" para forçar ser uma string)
            return new PosicaoXadrez(coluna, linha);
        }

        public static void imprimirPeca(Peca peca)
        {
            if (peca.cor == Cor.Branca)
            {
                Console.Write(peca);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;//Foreground =Salva a atual cor da letra(branca) na variavel aux
                Console.ForegroundColor = ConsoleColor.Yellow;//A Cor do atual do sistema recebe a cor amarela
                Console.Write(peca);// imprime a peca na cor amarela
                Console.ForegroundColor = aux; // volta para cor de antes;
            }
        }
    }
}
