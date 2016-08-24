using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos
{
    class Program
    {
        
        public static void Main()
        {
            //Inicializando Clases

            PotencialFor potencialfunctionFor = new PotencialFor();
            PotencialWhile potencialfunctionWhile = new PotencialWhile();
            PotencialDoWhile potencialfunctiondowhile = new PotencialDoWhile();

            ContarHasta10For contarhast10For = new ContarHasta10For();
            ContarHasta10While contarhasta10While = new ContarHasta10While();
            ContarHasta10Do contarhasta10Do = new ContarHasta10Do();
            ContarHasta10ForEach contarhasta10ForEach = new ContarHasta10ForEach();
            PotencialFor potencialfunction = new PotencialFor();

            potencialfunctionFor.potencial();
            potencialfunctionWhile.potencial();
            potencialfunctiondowhile.potencial();

            contarhast10For.contar();
            contarhasta10While.contar();
            contarhasta10Do.contar();
            contarhasta10ForEach.contar();
            potencialfunction.potencial();


        }

    }
}
