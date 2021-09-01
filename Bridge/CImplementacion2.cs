using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class CImplementacion2: IBridge
    {

        public void mostrarTotales(Dictionary<string, double> productos)
        {
            double total = 0;
            double totalC = 0;
            double totalM = 0;
            double totalD = 0;
            int cantidad = 0;

            foreach (KeyValuePair<string, double> producto in productos)
            {
                total += producto.Value;

                if (producto.Key[0] == 'C')
                {
                    totalC += producto.Value;
                }
                if (producto.Key[0] == 'M')
                {
                    totalM += producto.Value;
                }
                if (producto.Key[0] == 'D')
                {
                    totalD += producto.Value;
                }

                cantidad++;
            }

            Console.WriteLine("El total gastado en Comida es: ${0}", totalC);
            Console.WriteLine("El total gastado en Medicamentos es: ${0}", totalM);
            Console.WriteLine("El total gastado en articulos Deportivos es: ${0}", totalD);

            Console.WriteLine("El total de {0} productos es: ${1}", cantidad, total);
        }

        public void listarProductos(Dictionary<string, double> productos)
        {
            foreach (KeyValuePair<string, double> producto in productos)
            {
                if (producto.Key[0] == 'C')
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                if (producto.Key[0] == 'M')
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                if (producto.Key[0] == 'D')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                Console.WriteLine(producto.Key);
            }

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
