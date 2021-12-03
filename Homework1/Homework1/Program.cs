using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MyList<int> myIntList = new MyList<int>();
            myIntList.Add(3);
            myIntList.Add(7);
            myIntList.AddRange(new [] { 1, 4, 5, 3 });
            myIntList.RemoveAt(3);
            myIntList.Sort();
            Console.WriteLine("Int List");
            foreach (var item in myIntList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count of Int List");
            Console.WriteLine(myIntList.Count);

            Console.WriteLine("\nString List");
            MyList<string> myStringList = new MyList<string>();
            myStringList.AddRange(new[] { "Cat", "Dog", "Chicken", "Parrot", "Rabbit" });
            myStringList.Sort();
            foreach (var item in myStringList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nCar List");
            MyList<Car> myCarList = new MyList<Car>();
            myCarList.Add(new Car ("Tesla",200));
            myCarList.Add(new Car("Mercedes", 180));
            myCarList.Add(new Car("Chevrolet", 210));
            myCarList.Add(new Car("Gaselle", 170));
            myCarList.Add(new Car("Tesla", 250));
            myCarList.Sort();
            foreach (var item in myCarList)
            {
                Console.WriteLine($"{item.Name}, {item.Speed}");
            }
            
        }
    }
}
