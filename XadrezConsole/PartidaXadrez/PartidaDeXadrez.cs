using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XadrezConsole.JogoXadrez;
using XadrezConsole.TabuleiroXadrez;

namespace XadrezConsole.PartidaXadrez
{
    class PartidaDeXadrez
    {
        public Tabuleiro Tab { get; private set; }
        public bool Terminada { get; set; }

        private int _turno;
        private Cor _jogadorAtual;

        public PartidaDeXadrez()
        {
            Tab = new Tabuleiro(8, 8);
            _turno = 1;
            _jogadorAtual = Cor.Azul;
            Terminada = false;
            ColocarPecas();
        }

        public void ExecutarMovimento(Posicao origem, Posicao destino)
        {
            Peca p = Tab.RetirarPeca(origem);
            p.IncrementarMovimentos();
            Peca pecaCapturada = Tab.RetirarPeca(destino);
            Tab.InserirPeca(p, destino);
        }

        private void ColocarPecas()
        {
            Tab.InserirPeca(new Torre(Tab, Cor.Azul), new PosicaoXadrez('c',1).ToPosicao());
            Tab.InserirPeca(new Rei(Tab, Cor.Azul), new PosicaoXadrez('d',1).ToPosicao());
            Tab.InserirPeca(new Torre(Tab, Cor.Azul), new PosicaoXadrez('e',1).ToPosicao());
            
            Tab.InserirPeca(new Torre(Tab, Cor.Azul), new PosicaoXadrez('c', 2).ToPosicao());
            Tab.InserirPeca(new Torre(Tab, Cor.Azul), new PosicaoXadrez('d', 2).ToPosicao());
            Tab.InserirPeca(new Torre(Tab, Cor.Azul), new PosicaoXadrez('e', 2).ToPosicao());

            
            Tab.InserirPeca(new Torre(Tab, Cor.Vermelha), new PosicaoXadrez('c', 8).ToPosicao());
            Tab.InserirPeca(new Rei(Tab, Cor.Vermelha), new PosicaoXadrez('d', 8).ToPosicao());
            Tab.InserirPeca(new Torre(Tab, Cor.Vermelha), new PosicaoXadrez('e', 8).ToPosicao());
            
            Tab.InserirPeca(new Torre(Tab, Cor.Vermelha), new PosicaoXadrez('c', 7).ToPosicao());
            Tab.InserirPeca(new Torre(Tab, Cor.Vermelha), new PosicaoXadrez('d', 7).ToPosicao());
            Tab.InserirPeca(new Torre(Tab, Cor.Vermelha), new PosicaoXadrez('e', 7).ToPosicao());

        }
    }
}
