using System;
using System.Collections.Generic;
using System.Text;

namespace Decorador
{
    class CAuto : IComponente
    {

        private string modelo;
        private string caracteristicas;
        private double costo;

        public CAuto(string modelo, string caracteristicas, double precio)
        {
            this.modelo = modelo;
            this.caracteristicas = caracteristicas;
            this.costo = costo;
        }

        public void Puertas(bool estado)
        {
            if (estado)
                Console.WriteLine("Puertas abiertas");
            else
                Console.WriteLine("Puertas cerradas");
        }

        public override string ToString()
        {
            return string.Format("Modelo {0}, {1} \r\n", modelo, caracteristicas);
        }

        public double Costo()
        {
            return this.costo;
        }

        public string Funciona()
        {
            return "Encendí el motor";
        }
    }
}
