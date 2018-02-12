using Udemy_Xadrez_Console;

namespace Udemy_Xadrez_Console
{
    public class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; set; }
        public int qteMovimentos { get; protected set; } 
        //pode ser acessada por outras classes, mas só pode ser alterada por ela mesma e subclasses
        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor){
        //esse construtor vai receber só um tabuleiro, uma posição e uma cor.
            this.posicao = null;
            this.cor = cor;
            this.tab = tab;
            this.qteMovimentos = 0;
        }
        //public static void Torre()
    }
}