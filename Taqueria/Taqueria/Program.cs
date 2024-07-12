using System;

namespace PruebasSwitch
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Captura de las opciones del menu, se guarda en la variable op
            Console.WriteLine("Elije una opcion del Menu 1-6: \n" + "1.- Hamburguesa $3 \n" + "2.- Papa Asada $4 \n" + "3.- Tacos de Trompo $8 \n" + "4.- Campechana $6 \n" + "5.- Gringa $5 \n" + "6.- Tacos de Bisteck $7");
            int op = Convert.ToInt32(Console.ReadLine());

            //Limpia la consola
            Console.Clear();

            //Si se escoge una opcion que no esta en el menu se ejecuta el while pidiendo que se escoja con una opcion del menu
            //Si se escoge la opcion correcta se salta el While, no lo ejecuta
            while (op < 0 || op > 6)
            {
                Console.WriteLine("Elije una opcion del Menu (Digitando el numero de Opcion): \n" + "1.- Hamburguesa $3 \n" + "2.- Papa Asada $4 \n" + "3.- Tacos de Trompo $8 \n" + "4.- Campechana $6 \n" + "5.- Gringa $5 \n" + "6.- Tacos de Bisteck $7");
                op = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
            }

            //Cuando se escoge una opcion del menu pide cuantos se quiere y se guarda en la variable cantidad
            Console.WriteLine("Elije una cantidad:");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            //Pide si se desea algo mas del menu ya sea TRUE o FALSE y se guarda en la variable masPedido que es booleana
            Console.WriteLine("Desea llevar algo mas? TRUE OR FALSE");
            bool masPedido = Convert.ToBoolean(Console.ReadLine());

            Console.Clear();

            //Si se escribe FALSE se ejecuta esta linea de codigo el cual ya da la cuenta total
            int cuenta = Opcion(op, cantidad);

            //Si se escribe TRUE se ejecuta el While el cual nos pide escoger nuevamente una opcion del menu
            //Tiene While anidado el cual se ejecuta si se escoge una opcion erronea
            while (masPedido)
            {
                Console.WriteLine("Elije una opcion del Menu 1-6: \n" + "1.- Hamburguesa $3 \n" + "2.- Papa Asada $4 \n" + "3.- Tacos de Trompo $8 \n" + "4.- Campechana $6 \n" + "5.- Gringa $5 \n" + "6.- Tacos de Bisteck $7");
                op = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                while (op < 0 || op > 6)
                {
                    Console.WriteLine("Elije una opcion del Menu (Digitando el numero de Opcion): \n" + "1.- Hamburguesa $3 \n" + "2.- Papa Asada $4 \n" + "3.- Tacos de Trompo $8 \n" + "4.- Campechana $6 \n" + "5.- Gringa $5 \n" + "6.- Tacos de Bisteck $7");
                    op = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();
                }

                Console.WriteLine("Elije una cantidad:");
                cantidad = Convert.ToInt32(Console.ReadLine());

                cuenta += Opcion (op, cantidad);

                Console.WriteLine("Desea llevar algo mas? TRUE OR FALSE");
                masPedido = Convert.ToBoolean(Console.ReadLine());

                Console.Clear();
            }
            Console.WriteLine("El total de su cuenta seria de $" + cuenta.ToString());

            Console.ReadKey();
        }


        //En el switch se tiene las opciones del menu y cuando se selecciona una opcion del menu retorna su precio para realizar las operaciones de la cuenta
        public static int Opcion(int op, int cantidad)
        {
            switch (op)
            {
                case 1:
                    if (cantidad >= 3)
                    {
                        int promo = (cantidad / 3) * 2 + (cantidad % 3);
                        return promo * 3;
                     }
                    else
                    {
                        return cantidad * 3; 
                    }


                case 2: return 4;
                case 3: return 8;
                case 4: return 6;
                case 5: return 5;
                case 6: return 7;
                case 0: return 0;
                default: return 0;
            }
        }
    }
}