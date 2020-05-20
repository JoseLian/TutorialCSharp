using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Descripción : Clase realiza operaciones compra.
/// Requerimiento : No Aplica
/// Fecha creación: 16/05/2020
/// Creado por : Jose Luis Jauregui
/// </summary>
namespace TutorialPUCESA.Grupo1
{
    public class Ejercicio03
    {
        int Cantidad;
        decimal TotalPagar = 0.0M;
        const decimal PrecioHamburguesa = 3.20M;
        const decimal PrecioGaseosa = 1.75M;
        const decimal PrecioPapasFritas = 1.2M;

        public void OrdenCompra()
        {
            Console.WriteLine("Orden de Compra");
            Console.WriteLine("===============");

            Console.Write("* Hamburguesa \nCantidad: ");
            Cantidad = int.Parse(Console.ReadLine());
            TotalPagar = (Cantidad * PrecioHamburguesa) + TotalPagar;

            Console.Write("* Gaseosa \nCantidad: ");
            Cantidad = int.Parse(Console.ReadLine());
            TotalPagar = (Cantidad * PrecioGaseosa) + TotalPagar;

            Console.Write("* Papas fritas \nCantidad: ");
            Cantidad = int.Parse(Console.ReadLine());
            TotalPagar = (Cantidad * PrecioPapasFritas) + TotalPagar;

            Console.Write("\n");
            Console.Write("Total Pagar :{0}", Math.Round(TotalPagar, 2) + "\n");
            Console.Write("Press and key to continue...");
            Console.ReadLine();
        }
    }
}
