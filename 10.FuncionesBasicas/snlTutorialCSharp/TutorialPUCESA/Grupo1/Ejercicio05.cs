using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Descripción : Clase muestra los formatos de salida (String).
/// Requerimiento : No Aplica
/// Fecha creación: 17/05/2020
/// Creado por : Jose Luis Jauregui
/// </summary>
namespace TutorialPUCESA.Grupo1
{
    public class Ejercicio05
    {
        double Numero1;
        double Numero2;

        public void FormatoString()
        {
            Numero1 = 45.347;
            Numero2 = 78.235;
            double Area = (Numero1 * Numero2) / 2;

            Console.WriteLine("Formato Número");
            Console.WriteLine("==============");
            Console.Write("Triandulo: Base={0}, Altura={1}, Area={2}\n"
                , Numero1, Numero2, String.Format("{0:####.00}", Area));
            Console.Write("Area con formato {{0:C}} :{0}\n", String.Format("{0:C}", Area));
            Console.Write("Area con formato {{0:F}} :{0}\n", String.Format("{0:F}", Area));
            Console.Write("Area con formato {{0:G}} :{0}\n\n", String.Format("{0:G}", Area));

            Console.WriteLine("Formato Fecha");
            Console.WriteLine("=============");
            Console.Write("Hoy es {0}\n", String.Format("{0:F}", DateTime.Now));
            Console.Write("Hoy es {0}\n", String.Format("{0:dddd}, {0:dd/MM/yyy}", DateTime.Now));
            Console.Write("Ahora es {0} {1}\n", String.Format("{0:d}", DateTime.Now), String.Format("{0:t}", DateTime.Now));
            Console.Write("Alineación (D) {0}\n", String.Format("{0,30}", 126347.89m));
            Console.Write("Alineación (I) {0}\n\n", String.Format("{0,-10}", 126347.89m));

            Console.WriteLine("Interpolación");
            Console.WriteLine("=============");
            Console.Write($"Triangulo: Base={Numero1}, Altura={Numero2}, Area={Area:F}\n");

            Console.Write("Press and key to continue...");
            Console.ReadLine();
        }
    }
}
