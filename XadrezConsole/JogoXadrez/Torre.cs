using XadrezConsole.TabuleiroXadrez;

namespace XadrezConsole.JogoXadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor):base(cor, tab)
        {
        }

        public override string ToString()
        {
            return "T";
        }

        private bool _podeMover(Posicao p)//verificar boas praticas de nomes de metodos privados
        {
            Peca peca = Tabuleiro.Peca(p);
            return peca == null || peca.CorPeca != CorPeca;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];
            Posicao pos = new Posicao(0, 0);

            //Norte
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
            while(Tabuleiro.PosicaoValida(pos) && _podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tabuleiro.Peca(pos) != null && Tabuleiro.Peca(pos).CorPeca != CorPeca)
                    break;

                pos.Linha = pos.Linha - 1;
            }

            //Sul
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
            while (Tabuleiro.PosicaoValida(pos) && _podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tabuleiro.Peca(pos) != null && Tabuleiro.Peca(pos).CorPeca != CorPeca)
                    break;

                pos.Linha = pos.Linha + 1;
            }


            //Leste
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);
            while (Tabuleiro.PosicaoValida(pos) && _podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tabuleiro.Peca(pos) != null && Tabuleiro.Peca(pos).CorPeca != CorPeca)
                    break;

                pos.Coluna = pos.Coluna + 1;
            }


            //oeste
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);
            while (Tabuleiro.PosicaoValida(pos) && _podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tabuleiro.Peca(pos) != null && Tabuleiro.Peca(pos).CorPeca != CorPeca)
                    break;

                pos.Coluna = pos.Coluna - 1;
            }

            return mat;
        }
    }
}
