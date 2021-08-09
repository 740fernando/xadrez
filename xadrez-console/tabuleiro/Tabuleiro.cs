

namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;//private- não pode ser acessada de fora, só o tabuleiro mexe nelas

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }
        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }
        public Peca peca(Posicao pos)
        {
            return pecas[pos.linha,pos.coluna];
        }
        public bool existePeca(Posicao pos)
        {
            validarPosicao(pos);
            return peca(pos) != null;
        }
        public void colocarPeca(Peca p, Posicao pos)
        {
            if (existePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição");
            }
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }
        public Peca retirarPeca( Posicao pos)
        {
            if (peca(pos)==null)// Se a peça na posição pos for igual a nulo
            {
                return null;
            }
            Peca aux = peca(pos);// cria uma variavel auxiliar para receber o valor(posição) informado;
            aux.posicao = null;//aqui eu digo que a posição dessa peca vai ser null;
            pecas[pos.linha, pos.coluna] = null;// atribou valor de nulo para [pos.linha,pos.coluna](retira a peça)
            return aux;//retorno da peça que foi retirada;
        }
        public bool posicaoValida(Posicao pos)
        {
            if(pos.linha<0 || pos.linha>=linhas || pos.coluna<0 || pos.coluna >= colunas)
            {
                return false;
            }
            return true;
        }
        public void validarPosicao(Posicao pos)
        {
            if (!posicaoValida(pos))
            {
                throw new TabuleiroException("Posição Inválida! "+pos.linha + "-" + pos.coluna );
            }
        }
    }
}
