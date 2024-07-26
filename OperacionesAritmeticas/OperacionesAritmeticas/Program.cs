using System;

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

            Console.WriteLine("1.Suma \n2.Resta \n3.Multiplicacion \n4.Division");
            Console.WriteLine();
            Console.WriteLine("Que operacion quiere Realizar:");
            int operacion = Convert.ToInt32(Console.ReadLine());

            int resultado = Opcion(operacion, x, y);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("El resultado es: " + resultado);


            Console.ReadKey();
        }

        public static int Opcion(int operacion, int x, int y)
        {
            switch (operacion)
            {
                case 1: return x + y;
                case 2: return x - y;
                case 3: return x * y;
                case 4: return x / y;
                default: return 0;
            }
        }
    }
}
