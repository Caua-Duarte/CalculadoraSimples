using System;

namespace Exercicio3
{
    public class Multiplicacao:Operacao
    {
        private int mult;
        public int Mult
        {
            get { return mult; }
            set { mult = value; }
        }
        
        public override void EfetuarOperacao()
        {
            this.mult = X * Y;
            Console.WriteLine("O resultado da multiplicação é: " + mult);
        }
    }
}