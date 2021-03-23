using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercicio3
{
    public class Divisao:Operacao
    {
        public Divisao():base()
        {
            this.Div = 0;
        }
        public Divisao(int num1, int num2, int div):base(num1, num2)
        {
            this.Div = div;
        }
        private int div;
        public int Div

        {
            get { return this.div; }
            set { this.div = value; }
        }

        public override void EfetuarOperacao()
        {
            Console.Clear();

            Console.WriteLine ( "\n******************************* " );
            Console.WriteLine ( "**********  Divisão  ********** " );
            Console.WriteLine ( "******************************* \n" );

            Console.WriteLine("\nQual o primeiro número?");
            int Num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual o segundo número?");
            int Num2 = Convert.ToInt32(Console.ReadLine());

            this.Div = Num1 / Num2;
            Console.WriteLine("\nO resultado de " + Num1 + " / " + Num2 + " é " + Div);

            Console.ReadKey();
            Console.Clear();
            
        }
    }
}