using System;


namespace ConvertirFtoC
{
    class Program
    {

        static double Celcius(double f)
        {
            double c = (f - 32) / 1.8;

            return c;
        }
        static void Main(string[] args)
        {
            string text = "Ingresar temperatura en Farenheit\n";
            double c = Celcius(GetTemperatura(text));
            Console.WriteLine("La temperatura Celcius es {0}", c);

            Console.ReadKey(true);


        }

        static double GetTemperatura(string text)
        {
            Console.WriteLine(text);
            bool IsItTemp = false;
            double x = 0;

            do
            {
                IsItTemp = double.TryParse(Console.ReadLine(), out x);
            } while (!IsItTemp);

            return x;

        }
    }
}
