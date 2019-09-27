namespace XadrezConsole.TabuleiroXadrez
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor CorPeca { get; protected set; }
        public int QuantidadeMovimentos { get; protected set; }
        public Tabuleiro Tabuleiro { get; protected set; }

        public Peca(Cor cor, Tabuleiro tabuleiro)
        {
            this.Posicao = null;
            this.CorPeca = cor;
            this.Tabuleiro = tabuleiro;
            this.QuantidadeMovimentos = 0;
        }

        public void IncrementarMovimentos()
        {
            QuantidadeMovimentos++;
        }
        public bool ExisteMovimentosPossiveis()
        {
            bool[,] mat = MovimentosPossiveis();
            for(int i = 0; i < Tabuleiro.Linhas; i++)
            {
                for (int j = 0; i < Tabuleiro.Colunas; i++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool PodeMoverPara(Posicao posicao)
        {
            return MovimentosPossiveis()[posicao.Linha, posicao.Coluna];
        }

        public abstract bool[,] MovimentosPossiveis();
    }
}
