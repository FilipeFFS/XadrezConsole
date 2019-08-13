using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XadrezConsole.TabuleiroXadrez;

namespace XadrezConsole
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            for (var i = 0; i < tab.Linhas; i++)
            {
                for (var j = 0; j < tab.Colunas; j++)
                {
                    if(tab.Peca(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                    Console.Write(tab.Peca(i,j) + " ");
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
