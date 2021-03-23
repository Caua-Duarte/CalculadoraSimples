using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Exercicio3
{
    public class Soma:Operacao
    {
        public Soma():base()
        {
            this.Somar = 0;
        }
        public Soma(int num1, int num2, int somar):base(num1, num2)
        {
            this.Somar = somar;
        }
        private int somar;
        public int Somar

        {
            get { return this.somar; }
            set { this.somar = value; }
        }

        public override void EfetuarOperacao()
        {
            Console.Clear();

            Console.WriteLine ( "\n****************************** " );
            Console.WriteLine ( "***********  SOMA  *********** " );
            Console.WriteLine ( "****************************** \n" );

            Console.WriteLine("\nQual o primeiro número?");
            int Num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual o segundo número?");
            int Num2 = Convert.ToInt32(Console.ReadLine());

            this.Somar = Num1 + Num2;
            Console.WriteLine("\nO resultado de " + Num1 + " + " + Num2 + " é " + Somar);

            Console.ReadKey();
            Console.Clear();
            
        }
    }
}