using System;
using System.Threading;
namespace HilosApp
{
    class Program
    {
         public static void Main(string[] args)
        {
            Console.WriteLine("    Bienvenido a mi juego de carreras     ");
            Console.WriteLine("     Mi nombre es Paola Acosta       ");

            Thread Jugador1 = new Thread(Carrera.Corredor);
            Thread Jugador2 = new Thread(Carrera.Corredor);
            Thread Jugador3 = new Thread(Carrera.Corredor);
            Thread jugador4 = new Thread(Carrera.Corredor);

            Jugador1.Start();
            Jugador2.Start();
            Jugador3.Start();
            jugador4.Start();

            Jugador1.Join();
            Jugador2.Join();
            Jugador3.Join();
            jugador4.Join();

        }
        static void MetodoPorEjecturar()
        {
            var hiloActual = Thread.CurrentThread;
            hiloActual.CurrentCulture = new System.Globalization.CultureInfo("en-US"); 
            Console.WriteLine("Hilo actual {0}: ", hiloActual.ManagedThreadId);
            Console.WriteLine("Mi Cultura es {0} :", hiloActual.CurrentCulture);
            var random = new Random();
            for (int i =0; i <= 10; i++)
            {
                Console.WriteLine("Hilo {0} indice {1}", hiloActual.ManagedThreadId, i);
                Thread.Sleep(random.Next(50,75));
            }
        }
    }
}
