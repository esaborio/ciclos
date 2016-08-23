using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos
{
    class FactorialWhile
    {
            public void contar()

        {
            Console.WriteLine("Usando ciclo While");
            Console.WriteLine("Introduce un numero para calcular su factorial: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            int fact = numero;
            int x = fact - 1;

            while (x != 1)
            {
                fact = fact * x;
                x = x - 1;
            }
            Console.WriteLine("Factorial de " + numero + " = " + fact);
            Console.ReadKey();


        }

    }

    
}
