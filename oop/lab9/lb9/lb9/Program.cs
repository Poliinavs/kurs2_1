using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace lb9
{
    class Mn
    {
        private static void CollectionChange(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Console.WriteLine("Добавлен новый элемент");
                    break;
                case NotifyCollectionChangedAction.Remove:
                    Console.WriteLine("Удален элемент");
                    break;
            }
        }

        static void Main(string[] args)
        {
            
            //коллекция на основе класса
            CollectionType<int, Car> cl2 = new CollectionType<int, Car>();
            Dictionary<int, Car> CAR = new Dictionary<int, Car>();
            cl2.Collection = CAR;
            Car BMW = new Car("USA", "BMW");
            Car Volkswagen = new Car("Australia", "Volkswagen");
            Car Mercedes = new Car("England", "Mercedes");
            Console.WriteLine("Car class collection: ");
            CAR.Add(1999, BMW);
            CAR.Add(2022, Volkswagen);
            CAR.Add(2021, Mercedes);
            cl2.Show();
            Console.WriteLine("After methods: ");
            CAR.Remove(2022);
            cl2.HasPerson(2021);
            cl2.Show();

            ///////2 универсальная коллекция с данными встроенного типа
            CollectionType<int, string> cl1 = new CollectionType<int, string>();
            Console.WriteLine("Car collection: ");
            Dictionary<int, string> car = new Dictionary<int, string>();
            cl1.Collection = car;

            car.Add(1999, "BMW");
            car.Add(2000, "Volkswagen");
            car.Add(2002, "Mazda");
            car.TryAdd(2005, "Audi"); //возвращает true при успешном добавлении
            cl1.Show();
            Console.WriteLine("After methods: ");
            car.Remove(2000);
            cl1.Show();

            cl1.Remove_posl(2); //удалит 2 первых элемента 
            //Добвавить в list Dictionary
           
            Console.Write("List : ");
            List<int> keys = CAR.Keys.ToList();

            Console.WriteLine(String.Join(", ", keys)); 
            Console.WriteLine("Ключ есть: " + keys.find(2021));
            //наблюдаемой коллекции
            try{
                ObservableCollection<Car> Employees = new();
                Employees.CollectionChanged += CollectionChange;
                Employees.Add(BMW);
                Employees.Add(Mercedes);
                Employees.Remove(BMW);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
        }

        
    }

   
}