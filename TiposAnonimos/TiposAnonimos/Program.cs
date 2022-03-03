using System;

namespace TiposAnonimos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var equipo = new {Nombre = "Azul", Trofeos = 1000 };
            var nombreEquipo = equipo.Nombre;
            Test(equipo);
        }
        public static void Test(dynamic equipo)
        {
            Console.WriteLine(equipo.Nombre);
        }
    }
}
