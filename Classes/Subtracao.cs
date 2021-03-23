using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercicio3
{
    public class Subtracao:Operacao
    {
        public Subtracao():base()
        {
            this.Sub = 0;
        }
        public Subtracao(int num1, int num2, int sub):base(num1, num2)
        {
            this.Sub = sub;
        }
        private int sub;
        public int Sub

        {
            get { return this.sub; }
            set { this.sub = value; }
        }

        public override void EfetuarOperacao()
        {
            Console.Clear();

            Console.WriteLine ( "\n******************************* " );
            Console.WriteLine ( "*********  Subtração  ********* " );
            Console.WriteLine ( "******************************* \n" );

            Console.WriteLine("\nQual o primeiro número?");
            int Num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual o segundo número?");
            int Num2 = Convert.ToInt32(Console.ReadLine());

            this.Sub = Num1 - Num2;
            Console.WriteLine("\nO resultado de " + Num1 + " - " + Num2 + " é " + Sub);
            
            Console.ReadKey();
            Console.Clear();
            
        }
        

    }
}