using System;

namespace InterfazEjemplo
{
    public class ClassUsoInterfaz : ClassHerencia, IEjemplo
    {

        public static int Valor()
        {
            int x = 6;
            int y = 3;

            return x * y;
    
        }

    }
}
