using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesAritmeticasSwitch
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

            Console.WriteLine("Operaciones a realizar:");
            Console.WriteLine("1.- Suma");
            Console.WriteLine("2.- Resta");
            Console.WriteLine("3.- Multiplicacion");
            Console.WriteLine("4.- Division");
            Console.WriteLine();
            Console.WriteLine("¿Que operacion desea realizar?: ");
            int operacion = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();



            switch (operacion)
            {
                case 1:
                    int suma = x + y;
                    Console.WriteLine("La suma es: " + suma);
                    break;

                case 2:
                    int resta = x - y;
                    Console.WriteLine("La resta es: " + resta);
                    break;
                case 3:
                    int multiplicacion = x * y;
                    Console.WriteLine("La multiplicacion es: " + multiplicacion);
                    break;
                case 4:
                    int division = x / y;
                    Console.WriteLine("La division es: " + division);
                    break;


                default:
                    Console.WriteLine("Error");
                    break;

            }

            Console.ReadKey();  



        }

    }
}
   

