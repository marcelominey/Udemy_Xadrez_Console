using System;

namespace Udemy_Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao P;

            P = new Posicao(3, 4);
            Console.WriteLine("Posição " + P);
            Console.ReadLine();

            Tabuleiro tab = new Tabuleiro(4, 5);

            Tela.imprimirTabuleiro(tab);

            

            Console.WriteLine();
        }
    }
}
