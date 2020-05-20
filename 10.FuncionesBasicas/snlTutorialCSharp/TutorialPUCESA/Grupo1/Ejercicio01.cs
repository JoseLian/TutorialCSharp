using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Descripción : Clase invierte el orden de un número de dos cifras.
/// Requerimiento : No Aplica
/// Fecha creación: 16/05/2020
/// Creado por : Jose Luis Jauregui
/// </summary>
namespace TutorialPUCESA.Grupo1
{
    public class Ejercicio01
    {
        int Numero;
        int Decena;
        int Unidad;
        int Auxiliar;

        public void IngresarNumero()
        {
            String Input = String.Empty;

            Console.Write("Ingresar Número: ");
            Input = Console.ReadLine();

            try
            {
                Numero = Int16.Parse(Input);
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR CONTROLADO. Consulte con el administrador.");
            }
        }

        protected bool IsValid()
        {
            if (Numero.ToString().Length == 2)
            {
                return true;
            }

            return false;
        }

        public void InvertirOrden()
        {
            IngresarNumero();

            if (IsValid())
            {
                Decena = Numero / 10;
                Unidad = Numero % 10;
                Auxiliar = (Unidad * 10) + Decena;

                Console.WriteLine("Número Invertido: " + Auxiliar);
                Console.Write("Press and key to continue...");
                Console.ReadLine();
            }
            else
            {
                Console.Write("Press and key to continue...");
                Console.ReadLine();
            }
            
        }
    }
}
