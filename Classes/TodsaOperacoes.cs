using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercicio3
{
    public class TodasOperacoes:Operacao
    {
        public TodasOperacoes():base()
        {
            this.Todas = 0;
        }
        public TodasOperacoes(int num1, int num2, int todas):base(num1, num2)
        {
            this.Todas = todas;
        }
        private int todas;
        public int Todas

        {
            get { return this.todas; }
            set { this.todas = value; }
        }

        public override void EfetuarOperacao()
        {
            Console.Clear();

            Console.WriteLine ( "\n******************************* " );
            Console.WriteLine ( "********Todas Operações******** " );
            Console.WriteLine ( "******************************* \n" );

            Console.WriteLine("\nQual o primeiro número?");
            int Num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual o segundo número?");
            int Num2 = Convert.ToInt32(Console.ReadLine());

            this.Todas = Num1 + Num2;
            Console.WriteLine("\nO resultado de " + Num1 + " + " + Num2 + " é " + Todas);

            this.Todas = Num1 - Num2;
            Console.WriteLine("O resultado de " + Num1 + " - " + Num2 + " é " + Todas);

            this.Todas = Num1 / Num2;
            Console.WriteLine("O resultado de " + Num1 + " / " + Num2 + " é " + Todas);

            this.Todas = Num1 * Num2;
            Console.WriteLine("O resultado de " + Num1 + " x " + Num2 + " é " + Todas);
            
            Console.ReadKey();
            Console.Clear();

        }
    }
}