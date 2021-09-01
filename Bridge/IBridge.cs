using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    interface IBridge
    {
        void mostrarTotales(Dictionary<string, double> productos);
        void listarProductos(Dictionary<string, double> productos);
    }
}
