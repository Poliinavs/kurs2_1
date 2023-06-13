using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb9
{
    public static class Extensions
    {
        public static bool find<T>(this List<T> list, T target)
        {
            return list.Contains(target);
        }
    }
    public class CollectionType<T, Y> : IList<T, Y>
    {
        public Dictionary<T, Y> collection;
        public Dictionary<T, Y> Collection
        {
            get { return collection; }
            set { collection = value; }
        }

        public void Add(T key, Y value)
        {
            collection.Add(key,value);
        }

        public void Remove(T key)
        {
            collection.Remove(key);
        }

        public void Show()
        {
           var keys = collection.Keys;
            foreach (var j in keys)
               
                Console.WriteLine("Year -> {0}  Mark -> {1}", j, collection[j].ToString());
        }
        public bool HasPerson( T key)
        {
            Console.Write("Есть ли элемент: ");
            if (collection.ContainsKey(key))
            {
              
                Console.Write(collection.TryGetValue(key, out var V ));
                Console.WriteLine(" "+V);
                return true;
            }
            else
                return false;
        }

        public void Remove_posl(int amount)
        {
            Console.WriteLine("После удаления последовательности: ");
            if (amount <= collection.Count)
            {
                
                var keys = collection.Keys;
                foreach (var j in keys)
                {
                    if (amount != 0)
                    {
                        collection.Remove(j);
                        amount--;
                    }
                }
                Show();
            }
            else
                Console.WriteLine("Введено слишком большое число");
        }

        public bool Find_key(int key)
        {
            var keys = collection.Keys;
            /*foreach (var j in keys)
            {
                if(j== Find_key)
                    return true;
            }*/
            return false;

        }

    }
}
