using System;

namespace Ciclos
{
    class ContarHasta10Do
    {
        public void contar()
        {
            int i = 1;
            double result = 1;
            int Dato1;

            Console.Write("Usando Do While\n\n");
            Console.Write("Digite el numero por Factoriar:\n");
            Dato1 = int.Parse(Console.ReadLine());
            

         
            do
            {
                result *= i;
                i++;

            } while (i <= Dato1);


            Console.Write("El Valor Factoriado es:" + result);
            Console.ReadKey();

            Console.Clear();
        }
    }

}
