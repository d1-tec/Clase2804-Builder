using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2804
{
    class Program
    {
        static void Main(string[] args)
        {
            DireccionBuilder direccionBuilder = new DireccionBuilder();
            Direccion direccion = direccionBuilder
                .ConCalle("Soriano")
                .ConCodigoPostal("11200")
                .ConNumeroDePuerta("1472")
                .Build();
        }
    }
}
