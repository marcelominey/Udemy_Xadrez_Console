using Udemy_Xadrez_Console;

namespace xadrez
{
    public class Peao : Peca
    {
        public Peao(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
            this.qteMovimentos = 2;
        }
        public override string ToString(){
            return "P";
        }
    }
}