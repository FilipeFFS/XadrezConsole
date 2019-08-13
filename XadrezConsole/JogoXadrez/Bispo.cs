using XadrezConsole.TabuleiroXadrez;

namespace XadrezConsole.JogoXadrez
{
    class Bispo : Peca
    {
        public Bispo(Tabuleiro tab, Cor cor):base(cor, tab)
        {
        }

        public override string ToString()
        {
            return "B";
        }
    }
}
