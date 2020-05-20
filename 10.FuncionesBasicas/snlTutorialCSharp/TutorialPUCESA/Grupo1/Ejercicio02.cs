using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Descripción : Clase realiza operaciones matemáticas.
/// Requerimiento : No Aplica
/// Fecha creación: 16/05/2020
/// Creado por : Jose Luis Jauregui
/// </summary>
namespace TutorialPUCESA.Grupo1
{
    public class Ejercicio02
    {
        double Numero1;
        double Numero2;

        public void IngresarDatos()
        {
            String Input = String.Empty;

            Console.Write("Ingresar Número 1: ");
            Input = Console.ReadLine();
            Numero1 = Double.Parse(Input);

            Console.Write("Ingresar Número 2: ");
            Input = Console.ReadLine();
            Numero2 = Double.Parse(Input);
        }

        public void OperacionesBasicas()
        {
            double Suma;
            double Multiplicacion;
            double Division;
            double Residuo;

            IngresarDatos();

            if (IsValid())
            {
                Suma = Numero1 + Numero2;
                Multiplicacion = Numero1 * Numero2;
                Division = Numero1 / Numero2;
                Residuo = Numero1 % Numero2;

                Console.WriteLine("");
                Console.WriteLine("OPERACIONES BÁSICAS");
                Console.WriteLine("====================");
                Console.Write("Suma :{0}\n", Math.Round(Suma, 2));
                Console.Write("Multiplicación :{0}\n", Math.Round(Multiplicacion, 2));
                Console.Write("División :{0}\n", Math.Round(Division, 2));
                Console.Write("Residuo :{0}\n", Math.Round(Residuo, 2));

                Console.Write("Press and key to continue...");
                Console.ReadLine();
            }
            else
            {
                Console.Write("ERROR. Press and key to continue...");
                Console.ReadLine();
            }
        }

        public bool IsValid()
        {
            if (Numero1 > 0 & Numero2 > 0)
            {
                return true;
            }

            return false;
        }
    }
}
