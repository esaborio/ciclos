using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos
{
    class PotenciaDowhile
    {
        public void contar()
        {
            int x = 0;
            int resultado = 1;
            int n = 0;
            int i = 1;
            Console.WriteLine("Potencia usando DoWhile");
            Console.WriteLine("Digite digite X \n Inserta el numero:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite digite N \n Inserta el numero:");
            n = int.Parse(Console.ReadLine());

            do
            {
                resultado = resultado * x;
                i++;
            } while (i <= n);
            Console.WriteLine("La potencia es " + resultado);
            Console.ReadKey();
        }


    }
}
