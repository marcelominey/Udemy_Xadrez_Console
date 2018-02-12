using Udemy_Xadrez_Console;

namespace xadrez
{
    public class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
            this.qteMovimentos = 1;
        }
        public override string ToString(){
            return "R";
        }
    }
}