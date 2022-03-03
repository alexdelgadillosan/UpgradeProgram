using System;

namespace Nullables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? enteroNulo = null;
            enteroNulo = 12;
            int enteroNormal = 15;

            //Se tiene que hacer comprobacion
            if(enteroNulo.HasValue)
            {
                enteroNormal = enteroNulo.Value;
            }
        }
    }
}
