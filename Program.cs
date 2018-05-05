using System;

namespace codicioso
{
    class Program
    {
        static void Main(string[] args)
        {

            float cambioQueseDebe;

            do
            {
                System.Console.Write("Cuánto cambio se te debe: ");
                float.TryParse(Console.ReadLine(), out cambioQueseDebe);
            } while( cambioQueseDebe <= 0 );
            
System.Console.WriteLine($"Número de monedas a devolver: {numDeMonedas.numeroDeMonedas(cambioQueseDebe)}");
System.Console.WriteLine($"Se compone de: ");
System.Console.WriteLine($"{numDeMonedas.numeroDeMonedas(cambioQueseDebe).m5} moneda(s) de $5");
System.Console.WriteLine($"{numDeMonedas.numeroDeMonedas(cambioQueseDebe).m1} moneda(s) de $1");
System.Console.WriteLine($"{numDeMonedas.numeroDeMonedas(cambioQueseDebe).m50C} moneda(s) de ¢50");
System.Console.WriteLine($"{numDeMonedas.numeroDeMonedas(cambioQueseDebe).m10C} moneda(s) de ¢10");
System.Console.WriteLine($"{numDeMonedas.numeroDeMonedas(cambioQueseDebe).m1C} moneda(s) de ¢1");

        }

    }
}
