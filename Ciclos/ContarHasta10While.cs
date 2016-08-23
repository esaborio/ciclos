using System;

namespace Ciclos
{
    class ContarHasta10While
    {

        public void contar()
        {
            int i = 1;
            double result = 1;
            int Dato1;

            Console.Write("Usando While\n\n");
            Console.Write("Digite el Valor por Factoriar:\n");
            Dato1 = int.Parse(Console.ReadLine());
            

            while (i <= Dato1)
            {
                result *= i;
                i++;
            }

            Console.Write("El valor Factorail es:" + result);
            Console.ReadKey();

            Console.Clear();

        }

    }
}
