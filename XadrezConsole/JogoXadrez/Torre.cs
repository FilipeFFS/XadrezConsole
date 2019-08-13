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
    }
}
