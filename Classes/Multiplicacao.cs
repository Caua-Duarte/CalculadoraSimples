using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercicio3
{
    public class Multiplicacao:Operacao
    {
        public Multiplicacao():base()
        {
            this.Mult = 0;
        }
        public Multiplicacao(int num1, int num2, int mult):base(num1, num2)
        {
            this.Mult = mult;
        }
        private int mult;
        public int Mult

        {
            get { return this.mult; }
            set { this.mult = value; }
        }

        public override void EfetuarOperacao()
        {
            Console.Clear();

            Console.WriteLine ( "\n******************************* " );
            Console.WriteLine ( "******** Multiplicação ******** " );
            Console.WriteLine ( "******************************* \n" );

            Console.WriteLine("\nQual o primeiro número?");
            int Num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual o segundo número?");
            int Num2 = Convert.ToInt32(Console.ReadLine());

            this.Mult = Num1 * Num2;
            Console.WriteLine("\nO resultado de " + Num1 + " x " + Num2 + " é " + Mult);

            Console.ReadKey();
            Console.Clear();
            
        }
    }
}