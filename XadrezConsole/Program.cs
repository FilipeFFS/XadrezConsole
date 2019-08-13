using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XadrezConsole.Tabuleiro;

namespace XadrezConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao p = new Posicao(3,4);

            Console.WriteLine("Posicao " + p);
            Console.ReadLine();
        }
    }
}
