namespace XadrezConsole.TabuleiroXadrez
{
    class Peca
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
    }
}
