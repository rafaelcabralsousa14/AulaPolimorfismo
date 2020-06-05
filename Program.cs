using System;

namespace Aula11Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculo player = new Calculo();

            System.Console.WriteLine( player.Calcular() );
            System.Console.WriteLine( player.Calcular(100) );
            System.Console.WriteLine( player.Calcular(10 , 10) );
            System.Console.WriteLine( player.Calcular(100, 30, 20) );
            System.Console.WriteLine( player.Calcular("Perfurante", "Espada") );
        }
    }
}
