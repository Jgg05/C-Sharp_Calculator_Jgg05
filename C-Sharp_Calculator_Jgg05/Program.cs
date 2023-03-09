using System;

namespace Kalkulator
{

    class Program
    {
        static void Main(string[] args)
        {

            double num1 = 0;
            double num2 = 0;
            double result = 0;

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Kalkulator Program");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.WriteLine("Skriv inn nummer 1 ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Skriv inn nummer 2 ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("skriv hva du vil med tallene");
            Console.WriteLine("\t+ : Addisjon");
            Console.WriteLine("\t- : Subtraksjon");
            Console.WriteLine("\t* : Multiplikasjon");
            Console.WriteLine("\t/ : Divisjon");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            switch (Console.ReadLine())
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"Svaret ditt er: {num1} + {num2} = " + result);
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"Svaret ditt er: {num1} - {num2} = " + result);
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine($"Svaret ditt er: {num1} * {num2} = " + result);
                    break;
                case "/":
                    result = num1 / num2;
                    Console.WriteLine($"Svaret ditt er: {num1} / {num2} = " + result);
                    break;
                default:
                    Console.WriteLine("Det var ikke et gyldig valg");
                    break;
            }

            Console.ReadKey();
        }
    }
}