using tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }
        public override string ToString()
        {
            return "R";
        }
        private bool podeMover(Posicao pos)//Método auxiliar, foi utilizado o private, porque só vai ser utilizado na classe rei
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != this.cor;// O rei só podera se mover caso : espaço vazio ou quando for uma cor oposta;
        }
        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];
            Posicao pos = new Posicao(0, 0);
            //acima
            pos.definirValores(posicao.linha - 1, posicao.coluna);
            if (tab.posicaoValida(pos) && podeMover(pos))// posicaoValida= Teste se informação contida está dentro dos limites do tab
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //nordeste
            pos.definirValores(posicao.linha - 1, posicao.coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos))// posicaoValida= Teste se informação contida está dentro dos limites do tab
            {
                mat[pos.linha, pos.coluna] = true;
            }


            //direta
            pos.definirValores(posicao.linha, posicao.coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos))// posicaoValida= Teste se informação contida está dentro dos limites do tab
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //sudeste
            pos.definirValores(posicao.linha+1, posicao.coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos))// posicaoValida= Teste se informação contida está dentro dos limites do tab
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //abaixo
            pos.definirValores(posicao.linha+1, posicao.coluna);
            if (tab.posicaoValida(pos) && podeMover(pos))// posicaoValida= Teste se informação contida está dentro dos limites do tab
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //sudoeste
            pos.definirValores(posicao.linha+1, posicao.coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos))// posicaoValida= Teste se informação contida está dentro dos limites do tab
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //esquerda
            pos.definirValores(posicao.linha, posicao.coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos))// posicaoValida= Teste se informação contida está dentro dos limites do tab
            {
                mat[pos.linha, pos.coluna] = true;
            }
            //noroeste
            pos.definirValores(posicao.linha-1, posicao.coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos))// posicaoValida= Teste se informação contida está dentro dos limites do tab
            {
                mat[pos.linha, pos.coluna] = true;
            }
            return mat;
        }
    }
}
