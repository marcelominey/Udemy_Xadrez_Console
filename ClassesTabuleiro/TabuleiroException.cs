using System;

namespace ClassesTabuleiro
{
    public class TabuleiroException : Exception
    {
        public TabuleiroException(string msg) : base(msg){
         //recebe uma mensagem e simplesmente repassa para a classe Exception do C#
         //Com isso, eu faço uma excessão personalizada.   
        }
    }
}