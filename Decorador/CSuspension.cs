using System;
using System.Collections.Generic;
using System.Text;

namespace Decorador
{
    class CSuspension : IComponente
    {
        private IComponente objeto_a_decorar;

        public CSuspension(IComponente componente)
        {
            this.objeto_a_decorar = componente;
        }

        public override string ToString()
        {
            return "Suspensión de alto desempeño\r\n" + this.objeto_a_decorar.ToString();
        }

        public double Costo()
        {
            return this.objeto_a_decorar.Costo() + 40000;
        }

        public string Funciona()
        {
            return this.objeto_a_decorar.Funciona() + ", Elevando la suspensión";
        }
    }
}