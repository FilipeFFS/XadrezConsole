using System;
using XadrezConsole.JogoXadrez;
using XadrezConsole.TabuleiroXadrez;

namespace XadrezConsole
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            for (var i = 0; i < tab.Linhas; i++)
            {
                Console.Write(8 - i + "  ");
                for (var j = 0; j < tab.Colunas; j++)
                {
                    if(tab.Peca(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        ImprimirPeca(tab.Peca(i, j));
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine("{0}   a b c d e f g h", Environment.NewLine);
        }

        public static void ImprimirPeca(Peca peca)
        {
            if(peca.CorPeca == Cor.Vermelha)
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }

        public static PosicaoXadrez LerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna= s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }
    }
}
