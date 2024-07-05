using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace OperacionesAritmeticas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese un valor para x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Ingrese un valor para y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Que operacion quiere Realizar: Suma, Resta, Multiplicacion, Division");
            string operacion = Console.ReadLine();
            
            Console.WriteLine();

            if (operacion == "Suma")
            {
                int suma = x + y;
                Console.WriteLine("La suma es: " + suma);
            }
            else if (operacion == "Resta")
            {
                int resta = x - y;
                Console.WriteLine("La resta es: " + resta);
            }
            else if (operacion == "Division")
            {
                int division = x / y;
                Console.WriteLine("La division es: " + division);
            }
            else if (operacion == "Multiplicacion")
            {
                int multiplicacion = x * y;
                Console.WriteLine("La multiplicacion es: " + multiplicacion);
            }
            else
            {
                Console.WriteLine("Error");
            }
            Console.ReadKey();
        }
    }
}
