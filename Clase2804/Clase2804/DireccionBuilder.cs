using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2804
{
    public class DireccionBuilder
    {
        private Direccion instance;

        public DireccionBuilder()
        {
            this.instance = new Direccion();
        }

        public DireccionBuilder ConCalle(string calle)
        {
            instance.Calle = calle;
            return this;
        }

        public DireccionBuilder ConCodigoPostal(string codigoPostal)
        {
            instance.CodigoPostal = codigoPostal;
            return this;
        }

        public DireccionBuilder ConNumeroDePuerta(string numeroDePuerta)
        {
            instance.NumeroDePuerta = numeroDePuerta;
            return this;
        }

        public Direccion Build()
        {
            return this.instance;
        }
    }
}
