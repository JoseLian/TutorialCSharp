using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Descripción : Clase que calcula el discriminante de una ecuación cuadratica.
/// Requerimiento : No Aplica
/// Fecha creación: 16/05/2020
/// Creado por : Jose Luis Jauregui
/// </summary>
namespace TutorialPUCESA.Grupo2
{
    public class Ejercicio06
    {
        int A;  //cuadrativa
        int B;  //lineal
        int C;  //independiente

        public void IngresarDatos()
        {
            Console.WriteLine("Ecuacion Cuadrática");
            Console.WriteLine("===================");
            Console.Write("Ingrese valor cuadrativo (a): ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Ingrese valor lineal (b): ");
            B = int.Parse(Console.ReadLine());
            Console.Write("Ingrese valor independiente (c): ");
            C = int.Parse(Console.ReadLine());
        }

        public bool IsValid()
        {
            bool Result = false;

            if (A != 0 && B != 0 && C != 0)
            {
                Result = true;
            }

            return Result;
        }

        public void CalcularDiscriminante()
        {
            double Discriminante;

            try
            {
                IngresarDatos();

                if (IsValid())
                {
                    Discriminante = Math.Sqrt(Math.Pow(B, 2) - (4 * A * C));
                    Console.Write($"\nEcuación :{A}x\xB2 {(B > 0 ? "+" : "")}{B}x {(C > 0 ? "+" : "")}{C}\n");
                    Console.Write("Discriminante :{0}", String.Format("{0:F}\n", Discriminante));
                    Console.Write("Press and key to continue...");
                    Console.ReadLine();
                }
                else
                {
                    Console.Write("DATOS INCORRECTOS!. Press and key to continue...");
                    Console.ReadLine();
                }
            }
            catch (Exception)
            {
                Console.Write("ERROR NO CONTROLADO!. Press and key to continue...");
                Console.ReadLine();
            }
            
        }
    }
}
