using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContadorCaracteres
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Introduce una Palabra:");
            string texto = Console.ReadLine();
            int contador = ContarCaracteres(texto);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("La cadena " + texto + " tiene " + contador + " caracteres.");
            Console.ReadKey();  
        }

        static int ContarCaracteres(string cadena)
        {
            
            return cadena.Length;
        }
    }

   

  
}
