using System;

namespace Ciclos
{
    class ContarHasta10Do
    {
        public void contar()
        {
            int i=0;
            Console.Write("Usando Do While\n\n");
            Console.Write("Mostrar los números del 1 al 10:\n");
            Console.Write("---------------------------------------");
            Console.Write("\n\n");

            Console.WriteLine("Empezando conteo.:");

            do
            {
                Console.Write("{0} ", i);
                i++;
            } while (i <= 10);
            Console.Write("\n\n");
            Console.ReadKey();
        }
    }

}
