using System;

namespace Decorador
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponente miAuto = new CAuto("2020", "4 puertas", 200000);

            Console.WriteLine(miAuto);

            ((CAuto)miAuto).Puertas(false);

            Console.WriteLine("------------------");


            miAuto = new CSistemaAudio(miAuto);

            Console.WriteLine(miAuto.Costo());
            Console.WriteLine(miAuto.Funciona());
            Console.WriteLine(miAuto);

            Console.WriteLine("------------------");

            miAuto = new CSuspension(miAuto);

            Console.WriteLine(miAuto.Costo());
            Console.WriteLine(miAuto.Funciona());
            Console.WriteLine(miAuto);

            Console.WriteLine("------------------");

            miAuto = new CNitrogeno(miAuto);

            Console.WriteLine(miAuto.Costo());
            Console.WriteLine(miAuto.Funciona());
            ((CNitrogeno) miAuto).usarNitrogeno();
            Console.WriteLine(miAuto);

            Console.WriteLine("------------------");
        }
    }
}
