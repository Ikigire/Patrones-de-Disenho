using System;
using System.Collections.Generic;
using System.Text;

namespace Decorador
{
    class CSistemaAudio : IComponente
    {
        private IComponente objeto_a_decorar;

        public CSistemaAudio(IComponente componente)
        {
            this.objeto_a_decorar = componente;
        }

        public override string ToString()
        {
            return "Radio 350XZ+\r\n" + this.objeto_a_decorar.ToString();
        }

        public double Costo()
        {
            return this.objeto_a_decorar.Costo() + 4000;
        }

        public string Funciona()
        {
            return this.objeto_a_decorar.Funciona() + ", Enciende el radio";
        }
    }
}
