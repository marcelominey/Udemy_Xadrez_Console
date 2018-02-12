using System;
using ClassesTabuleiro;
using xadrez;

namespace Udemy_Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Posicao P;

                P = new Posicao(3, 4);
                Console.WriteLine("Posição " + P);
                Console.ReadLine();

                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Peao(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Peao(tab, Cor.Preta), new Posicao(1, 3));
                tab.colocarPeca(new Peao(tab, Cor.Preta), new Posicao(0, 2));

                Tela.imprimirTabuleiro(tab);

                Console.WriteLine();
            }
            catch(TabuleiroException e){
                Console.WriteLine(e.Message);
            }
        }
    }
}
