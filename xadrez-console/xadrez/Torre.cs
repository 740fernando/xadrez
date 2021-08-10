
using tabuleiro;

namespace xadrez
{

    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }
        public override string ToString()
        {
            return "T";
        }
        private bool podeMover(Posicao pos)//Método auxiliar, foi utilizado o private, porque só vai ser utilizado na classe torre
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != this.cor;// A torre só podera se mover caso : espaço vazio ou quando for uma cor oposta;
        }
        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];
            Posicao pos = new Posicao(0, 0);

            //acima
            pos.definirValores(posicao.linha - 1, posicao.coluna);
            while (tab.posicaoValida(pos) && podeMover(pos))//tab.posicaoValida(pos) = Enquanto estiver dentro do tabuleiro 8x8 podeMover=Enquanto estiver casa livre ou peça adversária
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)// tab.peca(pos) for diferente de nulo, ou seja, tem alguma peça lá. tab.peca(pos).cor != cor-referencia a peca adv.
                {
                    break;//força a parada do while
                }
                pos.linha = pos.linha - 1;// Caso o a condição não for atendida, vai ser necessário subir uma linha
            }


            //abaixo
            pos.definirValores(posicao.linha + 1, posicao.coluna);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)// tab.peca(pos) for diferente de nulo, ou seja, tem alguma peça lá. tab.peca(pos).cor != cor-referencia a peca adv.
                {
                    break;//força a parada do while
                }
                pos.linha = pos.linha + 1;// Caso o a condição não for atendida, vai ser necessário subir uma linha
            }
            //direita
            pos.definirValores(posicao.linha, posicao.coluna + 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)// tab.peca(pos) for diferente de nulo, ou seja, tem alguma peça lá. tab.peca(pos).cor != cor-referencia a peca adv.
                {
                    break;//força a parada do while
                }
                pos.coluna = pos.coluna + 1;// Caso o a condição não for atendida, vai ser necessário subir uma coluna
            }
            //esquerda
            pos.definirValores(posicao.linha, posicao.coluna - 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)// tab.peca(pos) for diferente de nulo, ou seja, tem alguma peça lá. tab.peca(pos).cor != cor-referencia a peca adv.
                {
                    break;//força a parada do while
                }
                pos.coluna = pos.coluna - 1;// Caso o a condição não for atendida, vai ser necessário descer uma coluna
            }
            return mat;
        }
    }
}

