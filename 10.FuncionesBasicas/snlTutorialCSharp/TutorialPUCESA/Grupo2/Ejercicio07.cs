using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Descripción : Clase que desglosa el billete.
/// Requerimiento : No Aplica
/// Fecha creación: 19/05/2020
/// Creado por : Jose Luis Jauregui
/// </summary>
namespace TutorialPUCESA.Grupo2
{
    public class Ejercicio07
    {
        int Cantidad;
        int B100;
        int B50;
        int B20;
        int B10;
        int M5;

        public Ejercicio07()
        {
            Cantidad = 0;
            B100 = 0;
            B50 = 0;
            B20 = 0;
            B10 = 0;
            M5 = 0;
        }

        public bool IngresarDatos()
        {
            bool Result;
            Console.Write("Ingrese Cantidad :");
            Result = Int32.TryParse(Console.ReadLine(), out Cantidad);

            return Result;
        }

        public void Desglosar()
        {
            bool IsValid = IngresarDatos();

            if (IsValid && Cantidad >= 0)
            {
                if (Cantidad >= 100)
                {
                    B100 = Cantidad / 100;
                    Cantidad -= (B100 * 100);
                }

                if (Cantidad >= 50)
                {
                    B50 = Cantidad / 50;
                    Cantidad -= (B50 * 50);
                }

                if (Cantidad >= 20)
                {
                    B20 = Cantidad / 20;
                    Cantidad -= (B20 * 20);
                }

                if (Cantidad >= 10)
                {
                    B10 = Cantidad / 10;
                    Cantidad -= (B10 * 10);
                }

                if (Cantidad >= 5)
                {
                    M5 = Cantidad / 5;
                    Cantidad -= (M5 * 5);
                }

                Console.Write("Billete 100 :{0}\n", B100);
                Console.Write("Billete 50 :{0}\n", B50);
                Console.Write("Billete 20 :{0}\n", B20);
                Console.Write("Billete 10 :{0}\n", B10);
                Console.Write("Moneda 5 :{0}\n", M5);
                Console.Write("Moneda 1 :{0}\n", Cantidad);
                Console.Write("Press and key to continue...");
                Console.ReadLine();

            }
            else
            {
                Console.Write("ERROR. Falló la conversión '{0}'\n."
                    , Cantidad == 0 ? "<null>" : Cantidad.ToString());
                Console.Write("Press and key to continue...");
                Console.ReadLine();
            }
        }
    }
}
