using System;
using System.Collections.Generic;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> productos = new Dictionary<string, double>();

            productos.Add("M101", 54.32);
            productos.Add("M451", 60.12);
            productos.Add("C745", 100);
            productos.Add("D789", 10);
            productos.Add("D711", 25.6);
            productos.Add("C555", 102);
            productos.Add("D451", 2.25);
            productos.Add("M312", 65.72);
            productos.Add("C999", 450.89);
            productos.Add("M093", 5.72);
            productos.Add("C001", 0.89);

            CAbstraccion bridge = new CAbstraccion(new CImplementacion2(), productos);

            bridge.listarProductos();

            bridge.mostrarTotales();
        }
    }
}
