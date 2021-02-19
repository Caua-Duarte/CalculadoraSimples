using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Soma so = new Soma();
            Subtracao su = new Subtracao();
            Divisao d = new Divisao();
            Multiplicacao m = new Multiplicacao();

            int  resp  =  100 ;
            while ( resp != 0 )
            {
                resp  =  Menu ();   
                if ( resp  ==  1 )
                {
                    Console.WriteLine("Qual o primeiro número?");
                    int X = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Qual o segundo número?");
                    int Y = Convert.ToInt32(Console.ReadLine());

                    so.EfetuarOperacao();
                    su.EfetuarOperacao();
                    d.EfetuarOperacao();
                    m.EfetuarOperacao();
                }
                if( resp == 2)
                {
                    Console.WriteLine("Qual o primeiro número?");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Qual o segundo número?");
                    int y = Convert.ToInt32(Console.ReadLine());

                    so.EfetuarOperacao();
                }
                if (resp == 3)
                {
                    Console.WriteLine("Qual o primeiro número?");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Qual o segundo número?");
                    int y = Convert.ToInt32(Console.ReadLine());

                    su.EfetuarOperacao();
                }
                if(resp == 4)
                {
                    Console.WriteLine("Qual o primeiro número?");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Qual o segundo número?");
                    int y = Convert.ToInt32(Console.ReadLine());

                    d.EfetuarOperacao();
                }
                if (resp == 5)
                {
                    Console.WriteLine("Qual o primeiro número?");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Qual o segundo número?");
                    int y = Convert.ToInt32(Console.ReadLine());

                    m.EfetuarOperacao();
                }
        }

        static int Menu()
        {
            Console.WriteLine ( " ******************************* " );
            Console.WriteLine ( " ********Calculadora3000******** " );
            Console.WriteLine ( " ******************************* " );
            Console.WriteLine ( "  " );
            Console.WriteLine ( " O que deseja fazer? " );
            Console.WriteLine ( "  " );
            Console.WriteLine ( " 0 - Sair do programa " );
            Console.WriteLine ( " 1 - Executar todas as contas " );
            Console.WriteLine ( " 2 - Executar a soma " );
            Console.WriteLine ( " 3 - Executar a subtração " );
            Console.WriteLine ( " 4 - Executar a divisão " );
            Console.WriteLine ( " 5 - Executar a multiplicação " );
            Console.WriteLine ( "  " );
            Console.WriteLine ( " Faça sua escolha: " );
            Console.Write ( "  " );

            int  resp  =  Convert.ToInt32( Console.ReadLine ());
            return  resp ;
        }
    }
}
}
