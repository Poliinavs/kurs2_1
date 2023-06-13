using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lb15
{
    public class Assinx
    {
        public static async Task Assin()
        {
            await PrintAsync();   // вызов асинхронного метода
            Console.WriteLine("Некоторые действия в методе Main");

             void Print()
            {
                Thread.Sleep(100);     // имитация продолжительной работы
                Console.WriteLine("Метод Print");
            }

            // определение асинхронного метода
            async Task PrintAsync()
            {
                Console.WriteLine("Начало метода PrintAsync"); // выполняется синхронно
                await Task.Run(() => Print());                // выполняется асинхронно
                Console.WriteLine("Конец метода PrintAsync");
           
            }
        }
      
    }
}
