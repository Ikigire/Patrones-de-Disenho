using System;
using System.Collections.Generic;
using System.Text;

namespace Decorador
{
    class CNitrogeno: IComponente
    {
        private IComponente objeto_a_decorar;

        public CNitrogeno(IComponente componente)
        {
            this.objeto_a_decorar = componente;
        }

        public override string ToString()
        {
            return "Sistema de Nitrogeno\r\n" + this.objeto_a_decorar.ToString();
        }

        public double Costo()
        {
            return this.objeto_a_decorar.Costo() + 45000;
        }

        public string Funciona()
        {
            return this.objeto_a_decorar.Funciona() + ", Nitrogeno listo";
        }

        public void  usarNitrogeno()
        {
            Console.WriteLine("Nitrógeno en uso");
        }
    }
}
