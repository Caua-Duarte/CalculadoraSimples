using System;

namespace Exercicio3
{
    public class Soma:Operacao
    {
        private int mult;
        public int Mult
        {
            get { return mult; }
            set { mult = value; }
        }
        
        public override void EfetuarOperacao()
        {
            this.mult = x * y;
            Console.WriteLine("O resultado da multiplicação é" + mult);
        }
    }
}