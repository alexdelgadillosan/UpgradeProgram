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
            Console.WriteLine("4");
            Map<Dulces>val=new Map<Dulces>(3);
            val[0] = new Dulces("Ricolino", 20);
            val[1] = new Dulces("Galatea", 10);
            val[2] = new Dulces("Cheetos", 25);
            Dulces dulce = val[2]; //indexer
            dulce.Info();
            
            
            
           Console.WriteLine("\n");
            Console.WriteLine("5");
            val.GetFirst();
            Console.WriteLine("\n");
            Console.WriteLine("Parte 6");
            Console.WriteLine("Holas1234".Validate());

        }
        public class Dulces : Abs
        {
            public Dulces(string vKey, dynamic vValue)
            {
                this.Key = vKey;
                this.Value = vValue;
            }

            public void Info()
            {
                Console.WriteLine("Marca: {0}", Key);
                Console.WriteLine("Costo: {0}", Value);
                
            }

           
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
    public  static class DulceExtension 
    {
        public static void GetFirst<T>(this Map<T> map) where T : Abs
        {

            string Key = map[0].Key.ToString();
            dynamic Value = map[0].Value;
            Console.WriteLine($"El primer valor del arreglo es {Key} , {Value}");

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

   
    public class Map<T> where T : Abs
    {
        public T[] arr;
    public Map(int i)
        {
            arr = new T[i];
        }

       
      

        //Indexers

        public T this[int index]
        {
            get { return arr[index]; }
            set => arr[index] = value;

        }
        public int this[string val]
        {
            get
            {
                try
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                       if (arr[i].Key == val)
                        {
                            return i;
                        }

                    }
                    throw new ArgumentOutOfRangeException(val + "  no esta en la lista");
                }
                catch (Exception)
                {

                    throw;
                }
            }
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













