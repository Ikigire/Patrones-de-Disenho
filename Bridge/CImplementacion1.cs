using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class CImplementacion1: IBridge
    {
        public void mostrarTotales(Dictionary<string, double> productos)
        {
            double total = 0;
            int cantidad = 0;

            foreach (KeyValuePair<string, double> producto in productos)
            {
                total += producto.Value;
                cantidad++;
            }

            Console.WriteLine("El total de {0} productos es: ${1}", cantidad, total);
        }

        public void listarProductos(Dictionary<string, double> productos)
        {
            foreach (KeyValuePair<string, double> producto in productos)
            {
                Console.WriteLine(producto.Key);
            }
        }
    }
}
