using System;

namespace Ciclos
{
    class ContarHasta10ForEach
    {
        public void contar()
        {
            int[] i = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.Write("Usando Foreach\n\n");
            Console.Write("Mostrar los números del 1 al 10:\n");
            Console.Write("---------------------------------------");
            Console.Write("\n\n");

            Console.WriteLine("Empezando conteo.:");

            foreach (int element in i)
            {
                Console.Write("{0} ", element);
            }
            Console.Write("\n\n");
            Console.ReadKey();
        }
    }

}
