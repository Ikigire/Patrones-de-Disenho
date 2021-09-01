using System;

using Subsistemas;

namespace Fachada
{
    class Program
    {
        static void Main(string[] args)
        {
            CFachada fachada = new CFachada();


            fachada.RealizarCompra();

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("----------");
            /*
            fachada.RealizarCompra();

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("----------");

            fachada.RealizarCompra();

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("----------");

            fachada.RealizarCompra();

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("----------");
            */
        }
    }
}
