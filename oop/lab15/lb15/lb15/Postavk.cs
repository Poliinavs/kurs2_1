using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace lb15
{
    public class Postavk
    {
        public static BlockingCollection<string> bc;

        public static void producer()
        {
            List<string> Appliances = new List<string> { "Fridge", "Microwave", "Plate", "Washing machine", "Toaster" };
            int choose = 0;
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                choose = rnd.Next(0, Appliances.Count - 1);
                Console.WriteLine($"Add {Appliances[choose]}");
                bc.Add(Appliances[choose]);
                Appliances.RemoveAt(choose);
                Thread.Sleep(2);
            }
            bc.CompleteAdding();
        }

       public static void consumer()
        {
            string i="";
            int m = 0;
            while (!bc.IsCompleted) //определить, что коллекция опустела, а новые элементы добавляться не будут.
            {
                m++;
                if (bc.TryTake(out i))
                    Console.WriteLine("Покупатель купил: " + i);
                else
                    if(m%3==0)
                    Console.WriteLine($"Покупатель ничего не купил и ушел");
            }
        }
    }
}
