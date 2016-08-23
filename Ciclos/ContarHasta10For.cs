using System;

namespace Ciclos
{
    class ContarHasta10For
    {
        public void contar()
        {
            int i = 1;
            int Dato1;
            double result = 1;

            Console.Write("Usando For\n\n");
            Console.Write("Digite en numero por Factoriar:\n");
            Dato1 = int.Parse(Console.ReadLine());
           

            for (i = 1; i <= Dato1; i++)
            {
                result *= i;
            }

            Console.WriteLine("El valor Factorial es:" + result);
            Console.ReadKey();

            Console.Clear();
        }
    }

}
