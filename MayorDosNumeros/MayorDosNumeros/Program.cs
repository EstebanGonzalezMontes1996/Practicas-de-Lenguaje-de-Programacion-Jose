using System;


namespace MayorDosNumeros
{
    public class Program
    {
        static void Main(string[] args){

            
            Console.WriteLine("Ingrese un valor para x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Ingrese un valor para y:");
            int y = Convert.ToInt32(Console.ReadLine());        

            Console.WriteLine();

            if(x > y){

                Console.WriteLine("El numero mayor es: " + x);
            }
            else if(y>x){
                Console.WriteLine("El numero mayor es:" + y);
            }
            else
            {
                Console.WriteLine("Los numeros " + x + " y " + y + " son iguales");
            }

            Console.ReadKey();  

        }
    }
}
