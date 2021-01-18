using System;
using System.Threading;
namespace HilosApp
{
    class Carrera
    {
        public  static void Corredor(object obj)
        {
            var nombre = (string)obj;
            var hiloActual = Thread.CurrentThread;
            var pasos = 0;
            var random = new Random();
            for (int i = 0; i <= 100; i++)
            {
                pasos += random.Next(0, 11);

                Console.WriteLine("Jugador {0} dio {1} pasos", hiloActual.ManagedThreadId,pasos);
                Thread.Sleep(10);
            }
            Console.WriteLine("El Jugador {0} llego  a la meta ", hiloActual.ManagedThreadId);
        }
    }
}
