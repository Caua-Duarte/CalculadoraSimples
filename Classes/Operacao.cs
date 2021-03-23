using System;

namespace Exercicio3
{
    public abstract class Operacao
    {
        public Operacao()
        {
            this.Num1 = 0;
            this.Num2 = 0;
        }
        public Operacao(int num1, int num2)
        {
            this.Num1 = num1;
            this.Num2 = num2;
        }
        private int num1;
        public int Num1
        {
            get { return this.num1; }
            set { this.num1 = value; }
        }
        
        private int num2;
        public int Num2
        {
            get { return this.num2; }
            set { this.num2 = value; }
        }
        
        public abstract void EfetuarOperacao();

    }
}