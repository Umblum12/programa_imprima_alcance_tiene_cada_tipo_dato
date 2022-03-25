using System;

namespace programa_imprima_alcance_tiene_cada_tipo_dato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tipos de dato

            //Enteros estos son valores sin punto flotante o decimal
            //ejemplo 6.7 3.1416

            byte bt = 255;
            short sh = 32767; // scope [el alcance de las variables]
            int entero = 2131124123;
            long l = 12312371123;

            // con punto flotante

            float f1 = 3.1416F; // importante F
            double d1 = 45.124231;

            Console.WriteLine("byte: " + byte.MinValue + " " + byte.MaxValue);
            bt = byte.Parse(Console.ReadLine());
            Console.WriteLine("El valor capturado de consola para byte es: " + bt);
            Console.WriteLine("Short: " + short.MinValue + " " + short.MaxValue);
            sh = short.Parse(Console.ReadLine());
            Console.WriteLine("El valor capturado de consola para short es: " + sh);
            Console.WriteLine("Int: " + int.MinValue + " " + int.MaxValue);
            entero = int.Parse(Console.ReadLine());
            Console.WriteLine("El valor capturado de consola para int es: " + entero);
            Console.WriteLine("Long: " + long.MinValue + " " + long.MaxValue);
            l = long.Parse(Console.ReadLine());
            Console.WriteLine("El valor capturado de consola para long es: " + l);
            Console.WriteLine("Float: " + float.MinValue + " " + float.MaxValue);
            f1 = float.Parse(Console.ReadLine());
            Console.WriteLine("El valor capturado de consola para float es: " + f1);
            Console.WriteLine("Double: " + double.MinValue + " " + double.MaxValue);
            d1 = double.Parse(Console.ReadLine());
            Console.WriteLine("El valor capturado de consola para byte es: " + d1);
            Console.ReadKey(true);
        }
    }
}
