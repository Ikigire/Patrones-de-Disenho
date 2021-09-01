using System;
using System.Collections.Generic;
using System.Text;

namespace Subsistemas
{
    class CFachada
    {
        private CSistemaAlmacen sistema_almacen;
        private CSistemaCompra sistema_compra;
        private CSistemaEnvio sistema_envio;

        public CFachada()
        {
            this.sistema_almacen = new CSistemaAlmacen();
            this.sistema_compra = new CSistemaCompra();
            this.sistema_envio = new CSistemaEnvio();
        }

        public void RealizarCompra()
        {
            if (sistema_compra.Comprar())
            {
                if (sistema_almacen.SacarAlmacen())
                {
                    sistema_envio.EnviarPedido();
                }
            }
        }
    }
}
