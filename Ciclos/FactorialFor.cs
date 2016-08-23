using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos
{
    class FactorialFor
    {
        public void contar()
       
        {
            int numero, resultado = 1;
            Console.WriteLine("Usando ciclo For");
            Console.WriteLine("Factorial de un numero \n Inserta el numero:");

            numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                resultado = resultado * i;  
            }
            Console.WriteLine("El factorial de " + numero + " es: " + resultado);
            Console.ReadLine();
        }
    }
}
