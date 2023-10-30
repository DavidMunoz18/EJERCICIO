using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuYSeleccion()
        {
            int opcionIntroducida;
            Console.WriteLine("0. Se cierra la aplicacion");
            Console.WriteLine("1. Solicita un numero entero");
            opcionIntroducida = Console.ReadKey(true).KeyChar- '0';
            return opcionIntroducida;
        }
    }
}
