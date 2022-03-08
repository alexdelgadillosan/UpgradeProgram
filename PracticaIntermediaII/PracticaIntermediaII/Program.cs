using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace PracticaIntermediaII
{
    internal class Program
    {
           
        static void Main(string[] args)
        {
            Stopwatch s1 = new Stopwatch();
            Stopwatch s2 = new Stopwatch();

            var l1 = new List<Tuple<int, int>>
            {
            Tuple.Create(1,2),
             Tuple.Create(2,3),
             Tuple.Create(3,5),
             Tuple.Create(5,1)
            };
            var tupleList = new List<(string Name, string Kind, int Replicas, bool Run)>
            {
                ("Cow", "Animal", 1, false),
                ("Rabbit", "Animal", 2, false),
                ("Alex", "Human", 0, true),
            };
            foreach (var item in l1 )
            {
                Console.WriteLine(item);
            };
            foreach (var item in tupleList)
            {
                Console.WriteLine(item);
            };

            //Implicit Operator
            // Se puede emplear al reves 
            Console.WriteLine( "\n");
            Person person = new Person();
            person.Name = "Alex";
            Worker worker = person;
            Console.WriteLine(worker.Name + "\n");
            s1.Start();
            PointThreeC pc = new PointThreeC();
            Console.WriteLine("Tiempo tardado en crear clase " + s1.Elapsed + "\n");
            s1.Stop();
            s2.Start();
            PointThreeS ps  = new PointThreeS();
            Console.WriteLine("Tiempo tardado en crear clase " + s2.Elapsed + "\n");
            s2.Stop();
            s1.Start();
            Rev( new int[] {1,123,3,5,7 } );
            s1.Stop();
            var one =s1.Elapsed;
            Console.WriteLine();
            s1.Start();
            RevL(new List<int> { 1, 3, 5, 6, 7, 8, 9, 11, 16, 71 });
            s1.Stop();
            var two = s1.Elapsed;
            Console.WriteLine();
            s1.Start();
            RevD(new Dictionary<int, int>
            {
                {1,2 },
                {2,3},  
                {3,4}
            });
            s1.Stop();
            var three = s1.Elapsed;

            
            Console.WriteLine(one+ "\n" + two + "\n" + three ) ;
            Pila("bob");







        }
        public static void Rev(int[] arr)
        {
            Array.Sort(arr);
            Array.Reverse(arr);
            foreach (int item in arr)
            {
                Console.Write("{0} ", item);
            }
            var first1 = arr[0];

        }

        public static void RevL(List<int> list)
        {
            var converted = list.ToArray(); 
            Array.Sort(converted);
            Array.Reverse(converted);
            foreach (int item in converted)
            {
                Console.Write("{0} ", item);
            }


        }

        public static void RevD(Dictionary<int, int> dict)
            
        {
            var rev = dict.Reverse().ToDictionary(x => x.Value, x => x.Key);
            foreach (KeyValuePair<int, int> pair in rev)
            {
                Console.WriteLine(pair.Key + " " + pair.Value);

            }


        }

        public static void Pila(string word)
        {
            var r = word.ToArray();
            Array.Reverse(r);
            Stack pil = new Stack();
            string st = new string(r);
            bool res = st.Equals(word);
            Console.WriteLine(res);
            



        }

        public class Person
        {
            public string Name { get; set; }


            public static implicit operator Worker(Person p)
            {
                Worker w = new Worker();
                w.Name = p.Name;
                return w;
            }
        }

        public class Worker
        {
            public string Name { get; set; }
            public static implicit operator Person(Worker w)
            {
                Person p = new Person();    
                p.Name = w.Name;
                return p;
            }
        }

        public class PointThreeC
        {
            
            public string Name { get; set; }
            public string Pass { get; set; }

        }

        struct PointThreeS
        {
            public string Name { get; set; }
            public string Pass { get; set; }

        }

      
    }
}
