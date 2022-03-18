using System;
using System.Collections.Generic;
using System.Linq;


namespace Practica1Avanzdo
{
   
    internal class Program
    {   
        //Declaracion del delegado
        public delegate void EvenNumbers(List<int> list) ;
        public delegate void OddNumbers(List<int> list);
        public delegate void OrderNumbersAsc(List<int> list); 
        public delegate void OrderNumbersDes(List<int> list);
        public delegate void DThree(int i);
        public delegate void DPrint(string i);
        public delegate void MaxVal(List<int> list);
        public delegate void MinVal(List<int> list);
        public delegate void AvgVal(List<int> list);
        public delegate void RMS(List<int> list);


        //Delegado Func 
        public delegate TResult Func<in T, out TResult>(T arg);
        static int Sum(int x, int y)
        { return x + y;
      
            
        }
        

        static void Main(string[] args)
        {
            //Instancia de Clase
            Functions f = new Functions(); 
            List<int> listExample = new List<int> { 1,2,3,4,5,6,0,7,8,9,20};
            //Instancia del delegado
            //Delegado nombre             delegado   (clase instanciada. metodo)
            EvenNumbers evenNumbers = new EvenNumbers(f.Even);
            OddNumbers oddNumbers = new OddNumbers(f.Odd);
            OrderNumbersAsc orderNumbersAsc = new OrderNumbersAsc(f.OrderAsc);
            OrderNumbersDes orderNumbersDes = new OrderNumbersDes(f.OrderDes);
            DThree dThree = new DThree(f.Div3);
            DPrint dPrint = new DPrint(f.P);
            MaxVal maxVal = new MaxVal(f.Max);
            MinVal minVal = new MinVal(f.Min); 
            AvgVal avgVal = new AvgVal(f.Avg);
            RMS rms = new RMS(f.RMS);  

           Func<int, int, int> add = Sum;
            //Delegado Action
            Action<int> printActionDel = i => Console.WriteLine(i);
            //Delegado Predicate
            Predicate<string> isUpper = s => s.Equals(s.ToUpper());

            //Se manda a lanzar el delegado
            evenNumbers(listExample);
            Console.WriteLine();
            oddNumbers(listExample);
            Console.WriteLine();
            orderNumbersAsc(listExample);
            Console.WriteLine();
            orderNumbersDes(listExample);
            Console.WriteLine();
            dThree(99);
            Console.WriteLine();
            dPrint("hola");
            maxVal(listExample);
            minVal(listExample);
            avgVal(listExample);
            rms(listExample);
            int result = add(121, 10);
            Console.WriteLine(result);
            printActionDel(2020);
            bool resultt = isUpper("hello world!!");
            Console.WriteLine(resultt);





        }

    }

 
    public class Functions
    {
        public void Odd(List<int> list)
        {
            foreach (var item in list)
            {
                if (item % 2 != 0) { Console.Write(item.ToString() + ", "); }
            }
        }
        public void Even(List<int> list)
        {
            foreach (var item in list)
            {
                if (item % 2 == 0) { Console.Write(item.ToString() + ", "); }
            }
        }
        public void OrderAsc(List<int> list)
        {

            list.Sort();
            foreach (var item in list)
            {
                Console.Write(item.ToString() + ", ");
            }

        }
        public void OrderDes(List<int> list)
        {

            list.Reverse();
            foreach (var item in list)
            {
                Console.Write(item.ToString() + ", ");
            }

        }
        public void Div3(int i)
        {



            if (i % 3 == 0) { Console.Write(i + " Es mulitplo de 3"); }
            else
            {
                Console.Write(i + " No es divisible entre 3");
            }


        }
        public void P(string s)
        {
            Console.WriteLine(s);   


        }
        public void Max(List<int> list)
        {
            list.Sort();
            var last = list.Last();
            Console.WriteLine(last.ToString());



        }
        public void Min(List<int> list)
        {
            list.Sort();
            var last = list.First();
            Console.WriteLine(last.ToString());



        }
        public void Avg(List<int> list)
        {
            list.Sort();
            var last = list.Average();
            Console.WriteLine(last.ToString());



        }
        public void RMS(List<int> list)
        {
            var n = 0;
            foreach (var item in list)
            {
                n += item ^ 2;

            }

            var res = Math.Sqrt(n / list.Count);
            Console.WriteLine(res);
            
        }
    }

   

   







}
