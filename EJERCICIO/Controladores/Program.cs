using EJERCICIO.Servicios;

namespace EJERCICIO.Controladores
{
    class program
    {
        static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();
            OperacionInterfaz oi = new OperacionImplementacion();
            {
                bool cerrarMenu = false;
                int opcionIntroducida;
                while (!cerrarMenu)
                {
                    opcionIntroducida = mi.mostrarMenuYSeleccion();
                    switch (opcionIntroducida)
                    {
                        case 0:
                            cerrarMenu |= true;
                            break;
                            case 1:
                            int solicita = oi.solicitar();
                            break;

                    }
                }
            }
        }
    }
}