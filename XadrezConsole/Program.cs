using System;
using XadrezConsole.JogoXadrez;
using XadrezConsole.TabuleiroXadrez;

namespace XadrezConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.InserirPeca(new Torre(tab, Cor.Azul), new Posicao(0, 0));
            tab.InserirPeca(new Torre(tab, Cor.Azul), new Posicao(1, 3));
            tab.InserirPeca(new Rei(tab, Cor.Azul), new Posicao(2, 4));

            tab.InserirPeca(new Torre(tab, Cor.Vermelha), new Posicao(3, 5));

            Tela.ImprimirTabuleiro(tab);
            Console.ReadLine();
        }
    }
}
