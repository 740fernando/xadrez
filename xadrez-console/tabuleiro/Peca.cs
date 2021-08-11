


namespace tabuleiro
{
    abstract class Peca // Quando tem um método abstrato, a classe se torna abstrata
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }// protected -Só pode ser acessada por ela mesmo e por suas subclasses
        public int qteMovimentos { get;protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca( Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.qteMovimentos = 0;
        }
      
        public void incrementarQteMovimentos()
        {
            qteMovimentos++;
        }
        public bool existeMovimentosPossiveis() // método para testar se a peça não está bloqueada de movimentos
        {
            bool[,] mat = movimentosPossiveis();
            for(int i=0; i < tab.linhas; i++)//percorre  a linha
            {
                for(int j = 0; j < tab.colunas; j++)//percorre a coluna
                {
                    if (mat[i, j])//se a posição estiver verdadeira, existe um movimento possível para essa peça
                    {
                        return true;//retorna verdaeiro
                    }
                }
            }
            return false;
        }
        public bool podeMoverPara(Posicao pos)
        {
            return movimentosPossiveis()[pos.linha, pos.coluna];
        }
        public abstract bool[,] movimentosPossiveis();// método genérico, sem ser específica, dessa maneira, utiliza se o abstract- é um metodo que não tem implentação nessa classe.

    }

}
