using System;

namespace Exercicio3
{
    public class Soma:Operacao
    {
        private int soma;
        public int Soma
        {
            get { return soma; }
            set { soma = value; }
        }
        
        public override void EfetuarOperacao()
        {
            this.soma = x + y;
            Console.WriteLine("O resultado da soma é" + soma);
        }
    }
}