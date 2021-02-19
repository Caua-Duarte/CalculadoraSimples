using System;

namespace Exercicio3
{
    public class Soma:Operacao
    {
        private int som;
        public int Som
        {
            get { return som; }
            set { som = value; }
        }
        
        public override void EfetuarOperacao()
        {
            this.som = X + Y;
            Console.WriteLine("O resultado da soma é: " + som);
        }
    }
}