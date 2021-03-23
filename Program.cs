using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            TodasOperacoes to = new TodasOperacoes();
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
                    to.EfetuarOperacao();
                }
                if( resp == 2)
                {
                    so.EfetuarOperacao();
                }
                if (resp == 3)
                {
                    su.EfetuarOperacao();
                }
                if(resp == 4)
                {
                    d.EfetuarOperacao();
                }
                if (resp == 5)
                {
                    m.EfetuarOperacao();
                }
        }

        static int Menu()
        {
            Console.WriteLine ( "\n******************************* " );
            Console.WriteLine ( "********Calculadora3000******** " );
            Console.WriteLine ( "******************************* \n" );

            Console.WriteLine ( "O que deseja fazer? \n" );

            Console.WriteLine ( "0 - Sair do programa " );
            Console.WriteLine ( "1 - Executar todas as contas " );
            Console.WriteLine ( "2 - Executar a soma " );
            Console.WriteLine ( "3 - Executar a subtração " );
            Console.WriteLine ( "4 - Executar a divisão " );
            Console.WriteLine ( "5 - Executar a multiplicação \n" );

            Console.Write ( "Faça sua escolha: " );

            int  resp  =  Convert.ToInt32( Console.ReadLine ());
            return  resp ;
        }
    }
}
}
