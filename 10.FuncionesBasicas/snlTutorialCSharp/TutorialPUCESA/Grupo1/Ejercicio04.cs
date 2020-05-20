using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Descripción : Clase que muestra las funciones de Math.
/// Requerimiento : No Aplica
/// Fecha creación: 16/05/2020
/// Creado por : Jose Luis Jauregui
/// </summary>
namespace TutorialPUCESA.Grupo1
{
    public class Ejercicio04
    {
        double Numero;

        public void Funciones()
        {
            Console.Write("Ingrese número :");
            Numero = Double.Parse(Console.ReadLine());

            if (Numero != 0)
            {
                Console.WriteLine("FUNCIONES MATH");
                Console.WriteLine("================");
                Console.Write("Valor Absoluto :{0}", Math.Abs(Numero)+"\n");
                Console.Write("Potencia 2:{0}", Math.Pow(Numero, 2)+"\n");
                Console.Write("Raiz Cuadrada :{0}", Math.Sqrt(Numero) + "\n");
                Console.Write("Seno :{0}", Math.Sin(Numero * Math.PI / 180) + "\n");
                Console.Write("Coseno :{0}", Math.Cos(Numero * Math.PI / 180) + "\n");
                Console.Write("Número Máx. :{0}", Math.Max(Numero, 100) + "\n");
                Console.Write("Número Min. :{0}", Math.Min(Numero, 100) + "\n");
                Console.Write("Parte Entera :{0}", Math.Truncate(Numero) + "\n");
                Console.Write("Redondeo (2 decimales) :{0}", Math.Round(Numero, 2) + "\n");
                Console.Write("Logaritmo Base10 :{0}", Math.Log10(Numero) + "\n");
            }
            else
            {
                Console.Write("ERROR. Intente nuevamente.");
            }

            Console.Write("Press and key to continue...");
            Console.ReadLine();
        }
    }
}
