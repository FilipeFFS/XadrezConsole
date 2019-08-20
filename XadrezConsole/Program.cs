using System;
using XadrezConsole.JogoXadrez;
using XadrezConsole.PartidaXadrez;
using XadrezConsole.TabuleiroXadrez;

namespace XadrezConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PartidaDeXadrez partida = new PartidaDeXadrez();

            while (!partida.Terminada)
            {
                Console.Clear();
                Tela.ImprimirTabuleiro(partida.Tab);

                Console.Write("Origem: ");
                Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();

                Console.Write("Destino: ");
                Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();

                partida.ExecutarMovimento(origem, destino);
            }

            Console.ReadLine();
        }
    }
}
