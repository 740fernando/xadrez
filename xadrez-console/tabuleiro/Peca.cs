


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
        public abstract bool[,] movimentosPossiveis();// método genérico, sem ser específica, dessa maneira, utiliza se o abstract- é um metodo que não tem implentação nessa classe.
      
        public void incrementarQteMovimentos()
        {
            qteMovimentos++;
        }
    }
}
