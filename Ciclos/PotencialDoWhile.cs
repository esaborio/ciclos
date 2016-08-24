using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos
{
    class PotencialDoWhile
    {
        public void potencial()
        {
            int Valor1;
            int Valor2;
            int result = 1;
            

            Console.Write("Usando Do While\n\n");
            Console.Write("Digite el primer Valor:\n");
            Valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el segundo valor:\n");
            Valor2 = int.Parse(Console.ReadLine());

            int i = Valor2;

            do
            {
                result = result * Valor1;
                i--;
            
            } while (i > 0);

            Console.WriteLine("El Resultado es:" + result);
            Console.ReadKey();

        }

    }
}
