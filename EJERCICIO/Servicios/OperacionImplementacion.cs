using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO.Servicios
{
    internal class OperacionImplementacion : OperacionInterfaz
    {
        public int solicitar(int numero)
        {
            int numeroInt = Convert.ToInt32(Console.ReadLine());
            {
                if (numeroInt%2 == 0)
                {
                    Console.WriteLine("es par");
                }
                else;
                {
                    Console.WriteLine("es impar");
                }
            }

        }
    }
}
