using System;

namespace Ciclos
{
    class ContarHasta10For
    {
        public void contar()
        {
            int i;
            Console.Write("Usando For\n\n");
            Console.Write("Mostrar los números del 1 al 10:\n");
            Console.Write("---------------------------------------");
            Console.Write("\n\n");

            Console.WriteLine("Empezando conteo.:");

            for (i = 1; i <= 10; i++)
            {
                Console.Write("{0} ", i);
            }
            Console.Write("\n\n");
            Console.ReadKey();
        }
    }

}
