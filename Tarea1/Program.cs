using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Definimos variables
                double Datos, Tiempo, Banda;
                //Ingresamos los datos
                Console.WriteLine("Ingrese la cantidad de datos a tranferir (en MB)");
                Datos = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el tiempo disponible para la transferencia(en segundos)");
                Tiempo = double.Parse(Console.ReadLine());
                //Proceso
                Banda = Math.Round((Datos * 8) / Tiempo, 2);
                //Salida mostrando el resultado
                Console.WriteLine("El ancho de banda necesario es: " + Banda + "Mbps");
                Console.ReadKey();
        }
    }
}
