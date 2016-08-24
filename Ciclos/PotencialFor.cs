using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos
{
    class PotencialFor
    {
        public void potencial()
        {
            int Valor1;
            int Valor2;
            int result = 1;

            Console.Write("Usando For\n\n");
            Console.Write("Digite el primer Valor:\n");
            Valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el segundo valor:\n");
            Valor2 = int.Parse(Console.ReadLine());

            for (int i = Valor2; i > 0 ; i--)
            {
                result = result * Valor1;

            }

            Console.WriteLine("La Potencial es:" + result);
            Console.ReadKey();


        }
    
    }
}
