using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    interface IItems<T>
    {

        void Print();

       
        void Add(T value);

      
        void Delete(int index);
    }

    class ArrayItems<T> : IItems<T>
    {
            T[] items;

            public ArrayItems()
            {
                // Установить значение по умолчанию
                items = default(T[]);
            }

            public ArrayItems(T[] _items)
            {
                items = _items;
            }

            // Добавить элемент в конец массива
            public void Add(T value)
            {
                T[] items2 = items;

                items = new T[items.Length + 1];

                for (int i = 0; i < items.Length - 1; i++)
                    items[i] = items2[i];

                items[items.Length - 1] = value;
            }

            // Удалить элемент, находящийся в позиции index
            public void Delete(int index)
            {
                if ((index < 0) || (index >= items.Length))
                    return;

                T[] items2 = new T[items.Length - 1];

                for (int i = 0; i < index; i++)
                    items2[i] = items[i];
                for (int i = index + 1; i < items.Length; i++)
                    items2[i - 1] = items[i];

                items = items2;
            }

            // Вывод массива на экран
            public void Print()
            {


                for (int i = 0; i < items.Length; i++)
                {
                    Console.Write("{0} ", items[i]);
                }
                Console.WriteLine();
            }
        }


        /* public void wwod_out()
         {
             for (int i = 0; i < Arr.Length; i++)
             {
                 Console.Write("{0}\t", Arr[i]);
             }
             Console.WriteLine();
         }

         public void inicial()
         {
             Random rnd = new Random();
             for (int i = 0; i < Arr.Length; i++)
             {
                 Arr[i] = rnd.Next(-10, 10);
                 Console.Write("{0}\t", Arr[i]);
             }
         }*/
    
}
