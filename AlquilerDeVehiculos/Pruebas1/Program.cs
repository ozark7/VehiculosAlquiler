using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace Pruebas1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Date = DateTime.Now.ToString("dd-MM-yyyy");
            Console.WriteLine("The Current Date Without Time is {0}.", Date);
            Console.ReadKey();

            //bool continuar = true;
            //int opcion=0;
            //do
            //{
            //    Console.WriteLine("---------------------------------------------");
            //    Console.WriteLine("1. Ingreso Vehiculos");
            //    Console.WriteLine("2. Ingreso Personas");
            //    Console.WriteLine("3. ");
            //    Console.WriteLine("4. ");
            //    Console.WriteLine("9. Salir");
            //    Console.WriteLine("---------------------------------------------");
            //    opcion =int.Parse(Console.ReadLine());


            //switch (opcion)
            //{
            //    case 1:
            //        EjecutarIngresoVehiculos();
            //        break;
            //    case 2:
            //        break;
            //    case 3:
            //        break;
            //    case 9:
            //        break;
            //    default:
            //        Console.WriteLine("Opcion no valida");
            //        break;
            //}
            //} while (opcion != 9); 
            //void EjecutarIngresoVehiculos(){
            //    Console.Clear();
            //    Console.Write("\nDigite la placa del vehiculo: ");
            //    string placa = Console.ReadLine();
            //    Console.Write("\nDigite la placa del vehiculo: ");
            //    string placa = Console.ReadLine();
            //    Console.Write("\nDigite la placa del vehiculo: ");
            //    string placa = Console.ReadLine();
            //}
        }

    }
}
