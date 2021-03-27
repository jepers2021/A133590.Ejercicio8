using System;

namespace A133590.Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Como no podemos usar split todavía, se busca el substring "fin".
            Console.WriteLine("Ejercicio 8");
            Console.WriteLine("Dada una frase, el programa indica si la palabra \"fin\" se encuentra presente");
            Console.Write("Por favor, ingrese una frase: ");
            string frase = Console.ReadLine();
            if(frase.IndexOf("fin") != -1)
            {
                Console.WriteLine("La palabra \"fin\" se encuentra presente en esta frase.");
            }
        }
    }
}
