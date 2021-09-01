using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class CAbstraccion
    {
        IBridge implementacion;
        Dictionary<string, double> productos;

        public CAbstraccion(IBridge implementacion, Dictionary<string, double> productos)
        {
            this.implementacion = implementacion;
            this.productos = productos;
        }

        public CAbstraccion(int tipo, Dictionary<string, double> productos)
        {
            this.productos = productos;

            if (tipo == 1)
            {
                this.implementacion = new CImplementacion1();
            }
            if (tipo == 2)
            {
                this.implementacion = new CImplementacion2();
            }
        }

        public void mostrarTotales()
        {
            this.implementacion.mostrarTotales(this.productos);
        }

        public void listarProductos()
        {
            this.implementacion.listarProductos(this.productos);
        }
    }
}
