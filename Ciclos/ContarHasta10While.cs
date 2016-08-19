using System;

namespace Ciclos
{
    class ContarHasta10While
    {

        public void contar()
        {
            int i = 0;

            Console.Write("Usando While\n\n");
            Console.Write("Mostrar los números del 1 al 10:\n");
            Console.Write("---------------------------------------");
            Console.Write("\n\n");

            Console.WriteLine("Empezando conteo.:");

            while (i <= 10)
            {
                Console.Write("{0} ", i);
                i++;
            }
            Console.Write("\n\n");
            Console.ReadKey();

        }

    }
}
