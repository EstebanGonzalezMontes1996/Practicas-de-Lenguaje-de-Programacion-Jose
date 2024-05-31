using System;
namespace RangoNumeros
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un valor para x: ");
            int x = Convert.ToInt32(Console.ReadLine()); //Almacena una entrada por consola


            Console.WriteLine("Ingrese un valor para y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            


            for (int i = x; i <= y; i++)
            {
                Console.Write("{0} ", i);

            }
             
            Console.ReadKey();
        }
    }
}
