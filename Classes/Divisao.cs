using System;

namespace Exercicio3
{
    public class Divisao:Operacao
    {
        private int div;
        public int Div
        {
            get { return div; }
            set { div = value; }
        }
        
        public override void EfetuarOperacao()
        {
            this.div = x / y;
            Console.WriteLine("O resultado da divisão é" + div);
        }
    }
}