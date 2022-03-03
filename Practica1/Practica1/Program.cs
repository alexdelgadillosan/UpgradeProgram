using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace Practica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Parte 1");
            Console.WriteLine(RNumber() + "\n");
            Console.WriteLine("Parte 2");
            Console.WriteLine(NType() + "\n");
            Console.WriteLine("Parte 3");
            Anon("juan", 20);
            Dnm();
            Console.WriteLine("\n");
            Console.WriteLine("Parte 6");
            Console.WriteLine("Holas1234".Validate());

        }
        public static string RNumber()
        {
            Random r = new Random();
            int num = r.Next(0, 1000);
            var result = num > 500 ? "Greater than 500" : "Less than 500";
            return result;

        }

        public static string NType()
        {
            int? vacio = null;
            try
            {
                return vacio == null ? throw new CustomEx("Valor nulo") : "Valor Valido";

            }
            catch (Exception ex)
            {
                return ex.Message;

            }

        }

        public static void Anon(string Name, int Age)
        {
            var anon = new { Name = Name, Age = Age };
            Console.WriteLine(anon.Name + " " + anon.Age);

        }
        public static void Dnm()
        {
            dynamic variableExample = 1;
            Console.WriteLine(variableExample);
            variableExample = "Ahora soy un string";
            Console.WriteLine(variableExample);
            variableExample = new { Name = "juan", Age = "20", City = "Mexico" };
            Console.WriteLine(variableExample);



        }





    }

    public class CustomEx : NullReferenceException
    {
        public CustomEx(string message)
        {
            Console.WriteLine(message);

        }
    }

    public abstract class Abs
    {
        public string Key { get; set; }
        public dynamic Value { get; set; }
    }

    //Clase Generica donde el parametro T solo permite clases derivadas de 
    // clase abstracta anteriror
    public class Map<T> where T : Abs
    {
        Map<Abs> absGen = new Map<Abs>();

        //Propiedad
        public List<T> list { get; private set; }

       
      

        //Indexers

        public T this[int index]
        {
            get { return list[index]; }
            set => list[index] = value;

        }
        public T this[string val]
        {
            get
            {
                try
                {
                    return list.Find(x => x.Key == val);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            set => list.Find(x => x.Key == val);




        }





    }

    public static class RExtension
    {
        public static string Validate(this string phrase)
        {

            bool match = Regex.IsMatch(phrase, @"^[A-Z]{1}[a-z]{3}[0-9]{4}");
            return match.ToString();
        }
    }

    // Extension method para lista traer primer valor
    public static class RExtension2
    {

        public static string Validate<T>(this List<T> list, T item)
        {
            return list[0].ToString();

            
        }
    }



}













