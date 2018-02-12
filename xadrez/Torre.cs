namespace Udemy_Xadrez_Console.xadrez
{
    public class Torre : Peca
    {
    public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
            this.qteMovimentos = 7;
        }
        public override string ToString(){
            return "T";
        }
    }
}