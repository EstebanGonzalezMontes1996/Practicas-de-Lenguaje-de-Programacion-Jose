using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangoNumeros
{
   public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese el primer número:");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Ingrese el segundo número:");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            int rango = Math.Abs(numero1 - numero2);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("El rango entre " + numero1 + " y " + numero2 + " es: " + rango);

            Console.ReadKey();  
        }
    }
}
