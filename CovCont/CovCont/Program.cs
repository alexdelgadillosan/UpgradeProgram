using System;

namespace CovCont
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMyInterface<Animal> myAnimals = new GenericAnimal<Cat>();
            
        }
    }
}

//Covarianza OUT
public interface IMyInterface<out T>
{
    T Get();
}
public class Animal { }
public class Cat : Animal { }
public class Dog : Animal { }
public class GenericAnimal<T> : IMyInterface<T>
{
    public T Get()
    {
        //Acá podría devolver una instancia de T.
        return default(T);
        
    }
}



//Contravarianza IN
//public class Program
//{
//    public static void Main()
//    {
//        GenericAnimal<Animal> zoo = new GenericAnimal<Animal>();
//        zoo.Add(new Cat());
//        zoo.Add(new Dog());

//        //Aunque sean listas de gatos...
//        //... Les puedo guardar listas de animales.
//        IMyInterface<Cat> myCats = zoo;
//        IMyInterface<Dog> myDogs = zoo;
//    }
//}
//public interface IMyInterface<in T>
//{
//    void Add(T another);
//}
//public class Animal { }
//public class Cat : Animal { }
//public class Dog : Animal
//{
//    public void Bark()
//    {
//        Console.WriteLine("WOW!");
//    }
//}
//public class GenericAnimal<T> : IMyInterface<T>
//{
//    public void Add(T another)
//    {

//    }
//}