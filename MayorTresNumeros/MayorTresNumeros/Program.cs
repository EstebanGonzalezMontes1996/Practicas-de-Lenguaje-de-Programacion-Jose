using System;

namespace MayorTresNumeros
{
    public class Program
    {
        static void Main(string[] args)
        {
  
            Console.WriteLine("Ingrese un valor para x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Ingrese un valor para y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Ingrese un valor para z: ");
            int z = Convert.ToInt32(Console.ReadLine());


            if(x>y && x>z){
                Console.Clear();
                Console.WriteLine("El numero mayor es: " + x);
            }
            else if (y>x && y>z){
                Console.Clear();
                Console.WriteLine("El numero mayor es: " + y);
            }
            else if (z>x && z>y)
            {
                Console.Clear();
                Console.WriteLine("El numero mayor es: " + z);   
            }        
            else
            {
                Console.Clear();
                Console.WriteLine("El resultado es: " + x);
            }
            Console.ReadKey();
            
        }
    }
}
