﻿using System;
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
        public bool Terminada { get; private set; }
        public int Turno { get; private set; }
        public Cor JogadorAtual { get; private set; }

        public PartidaDeXadrez()
        {
            Tab = new Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Azul;
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
        public void RealizaJogada(Posicao origem, Posicao destino)
        {
            ExecutarMovimento(origem, destino);
            Turno++;
            MudarJogador();
        }
        public void ValidarPosicaoOrigem(Posicao posicao)
        {
            if(Tab.Peca(posicao) == null)
            {
                throw new TabuleiroException("Não existe peça na posição de origem escolhida");
            }
            if (JogadorAtual != Tab.Peca(posicao).CorPeca)
            {
                throw new TabuleiroException("Não é a sua vez");
            }
            if (!Tab.Peca(posicao).ExisteMovimentosPossiveis())
            {
                throw new TabuleiroException("Não há movimentos possíveis para a peça de origem escolhida");
            }
        }

        public void ValidarPosicaoDestino(Posicao origem, Posicao destino)
        {
            if (!Tab.Peca(origem).PodeMoverPara(destino))
            {
                throw new TabuleiroException("Posição de destino inválida");
            }
        }

        
        private void MudarJogador()
        {
            if(JogadorAtual == Cor.Azul)
            {
                JogadorAtual = Cor.Vermelha;
            }
            else
            {
                JogadorAtual = Cor.Azul;
            }
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
