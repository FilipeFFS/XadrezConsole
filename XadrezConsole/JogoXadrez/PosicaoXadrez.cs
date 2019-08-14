using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XadrezConsole.TabuleiroXadrez;

namespace XadrezConsole.JogoXadrez
{
    class PosicaoXadrez
    {
        public int Linha { get; set; }
        public char Coluna { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            this.Linha = linha;
            this.Coluna = coluna;
        }
        public Posicao ToPosicao()
        {
            return new Posicao(8 - Linha, Coluna - 'a');
        }
        public override string ToString()
        {
            return "" + Coluna + Linha;
        }
    }
}
