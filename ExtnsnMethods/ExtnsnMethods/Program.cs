using System;

namespace ExtnsnMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string PrimeraLetraMayuscula(string frase)
        {
            char primeraLetra = char.ToUpper(frase[0]);
            string restoFrase = frase.Substring(1);
            return primeraLetra + restoFrase;
        }
    }
}
