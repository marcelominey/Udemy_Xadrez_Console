
namespace Udemy_Xadrez_Console
{
    public class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        //no caso de xadrex, é sempre 8x8
        private Peca[,] pecas;
        //tenho uma matriz de peças também.

        public Tabuleiro(int linhas, int colunas){
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas,colunas];
        }
        public Peca peca(int linha, int coluna){
            return pecas[linha,coluna];
            //estou dando acesso a uma única peça específica
        }

    }
}