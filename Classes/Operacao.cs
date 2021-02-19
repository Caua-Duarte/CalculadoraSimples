using System;

namespace Exercicio3
{
    public abstract class Operacao
    {
        public Operacao()
        {
            this.X = 0;
            this.Y = 0;
        }
        public Operacao(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        
        private int x;
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        
        private int y;
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        
        public abstract void EfetuarOperacao()
    }
}