namespace XadrezConsole.TabuleiroXadrez
{
    class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }

        private Peca[,] _pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.Linhas = linhas;
            this.Colunas = colunas;
            _pecas = new Peca[linhas, colunas];
        }
        public Peca Peca(int linha, int coluna)
        {
            return _pecas[linha, coluna];
        }
        public Peca Peca(Posicao posicao)
        {
            return _pecas[posicao.Linha, posicao.Coluna];
        }
        public void InserirPeca(Peca p, Posicao posicao)
        {
            if (ExistePeca(posicao))
                throw new TabuleiroException("Já existe uma peça nessa posição");

            _pecas[posicao.Linha, posicao.Coluna] = p;
            p.Posicao = posicao;
        }
        public Peca RetirarPeca(Posicao p)
        {
            if(Peca(p) == null)
                return null;

            Peca aux = Peca(p);
            aux.Posicao = null;
            _pecas[p.Linha, p.Coluna] = null;
            return aux;
        }
        public bool PosicaoValida(Posicao posicao)
        {
            if (posicao.Linha < 0 || posicao.Linha >= Linhas || posicao.Coluna < 0 || posicao.Coluna >= Colunas)
                return false;

            return true;
        }
        public void ValidarPosicao(Posicao posicao)
        {
            if (!PosicaoValida(posicao))
                throw new TabuleiroException("Posição inválida!");
        }
        public bool ExistePeca(Posicao posicao)
        {
            ValidarPosicao(posicao);
            return Peca(posicao) != null;
        }

    }
}
