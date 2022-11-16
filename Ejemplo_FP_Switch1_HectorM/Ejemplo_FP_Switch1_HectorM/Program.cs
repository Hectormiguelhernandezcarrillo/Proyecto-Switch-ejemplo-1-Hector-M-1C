using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejemplo_FP_Switch1_HectorM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre, carrera, categoria;
            double pagoTotal = 90;
            byte horasTrabajadas;
            //----
            Console.WriteLine("Ingresa el nombre del profesor");
            nombre = Console.ReadLine();
            //----
            Console.WriteLine("Ingresa la carrera a la que perteneces \t\n ISIC \t IGE \t INLG \t IID");
            carrera = Console.ReadLine();
            //----
            Console.WriteLine("Selecciona la categoria del maestro");
            categoria = Console.ReadLine();
            //----
            Console.WriteLine("Ingresa las horas trabajadas del maestro");
            horasTrabajadas = Convert.ToByte(Console.ReadLine());

            //Switch

            switch (categoria)
            {
                case "A":
                    pagoTotal = (pagoTotal * horasTrabajadas) * 1.0048;
                    Console.WriteLine(pagoTotal);
                    break;
                case "B":
                    pagoTotal = (pagoTotal * horasTrabajadas) * 1.0063;
                    Console.WriteLine(pagoTotal);
                    break;
                case "C":
                    pagoTotal = (pagoTotal * horasTrabajadas) * 1.0098;
                    Console.WriteLine(pagoTotal);
                    break;
                default:
                    break;
            }

            Console.WriteLine("Saliendo del sistema.");
            Thread.Sleep(1000);
            Console.WriteLine("Saliendo del sistema..");
            Thread.Sleep(1000);
            Console.WriteLine("Saliendo del sistema...");
            Thread.Sleep(1000);
        }
    }
}
