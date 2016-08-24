using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos
{
    class PotencialWhile
    {
        public void potencial()
        {

            int Valor1;
            int Valor2;
            int result = 1;
            int i;

            Console.Write("Usando While\n\n");
            Console.Write("Digite el primer Valor:\n");
            Valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el segundo valor:\n");
            Valor2 = int.Parse(Console.ReadLine());

            i = Valor2;

            while  ( i > 0)
            {

                result = result * Valor1;
                i--;
            }

            Console.WriteLine("El Resultado es:" + result);
            Console.ReadKey();

        }

    }
}
