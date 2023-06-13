using System;
using System.Text.RegularExpressions;
using System.Text;
using System.Runtime.ConstrainedExecution;
using System.Linq;
using System.Numerics;

namespace lb10
{
    class Class1
    {
        static void Main(string[] args)
        {
            /*          Задайте массив типа string, содержащий 12 месяцев(June, July, May,
          December, January ….).Используя LINQ to Object напишите запрос выбирающий
          последовательность месяцев с длиной строки равной n, запрос возвращающий
          только летние и зимние месяцы, запрос вывода месяцев в алфавитном порядке,
          запрос считающий месяцы содержащие букву «u» и длиной имени не менее 4 - х..int n = 6;*/
            int n = 5;
            string[] month = {"January", "February", "March", "April", "May", "June", "July",
                "August", "September", "October","November", "December"};

            var SizeN = month.Where(p => p.Length == n);
            Console.Write($"последовательность месяцев с длиной строки равной {n}: ");
            foreach (string mn in SizeN)
                Console.Write(mn + " ");
            Console.WriteLine();

            var WinterSummer = from t in month
                               where Equals(t, "December") || Equals(t, "January") || Equals(t, "February")
                                     || Equals(t, "June") || Equals(t, "July") || Equals(t, "August")
                               select t;
            Console.Write("только летние и зимние месяцы: ");
            foreach (string mn in WinterSummer)
                Console.Write(mn + " ");
            Console.WriteLine();

            var Alpha = month.OrderBy(p => p);
            Console.Write($"вывод месяцев в алфавитном порядке: ");
            foreach (string mn in Alpha)
                Console.Write(mn + " ");
            Console.WriteLine();

            var Amount = month.Count(p => p.Length >= 4 && p.Contains("u"));
            Console.Write($"количество месяцев содержащих букву «u» и длиной имени не менее 4 - х: ");
            Console.Write(Amount);

            /*     Console.WriteLine();
                 2.Создайте коллекцию List<T> и параметризируйте ее типом (классом)
     из лабораторной №2(при необходимости реализуйте нужные интерфейсы).
     Заполните ее минимум 10 элементами.*/
            Console.WriteLine();
            Console.WriteLine();
            int[] arr22 = { -10, 2 };

            Vector arr1 = new Vector(arr22);
            Vector arr2 = new Vector();
            Vector arr3 = new Vector();
            Vector arr4 = new Vector();
            Vector arr5 = new Vector();
            Vector arr6 = new Vector();
            Vector arr7 = new Vector();
            Vector arr8 = new Vector();
            Vector arr9 = new Vector();
            Vector arr10 = new Vector();

            List<Vector> clA = new List<Vector>();
            clA.Add(arr1);
            clA.Add(arr2);
            clA.Add(arr3);
            clA.Add(arr4);
            clA.Add(arr5);
            clA.Add(arr6);
            clA.Add(arr7);
            clA.Add(arr8);
            clA.Add(arr9);
            clA.Add(arr10);

            foreach (var item in clA)
            {
                Console.Write(item.ToString());
            }
            //3
            Console.WriteLine();

            var Amount1 = clA.Count(p => p.arr.Contains(0));
            Console.WriteLine("количество векторов, содержащих 0: " + Amount1);

            var min = clA
                .OrderBy(n => n.sum)
                   .First();
            Console.Write($"Вектор с наименьшим модулем: ");
            Console.WriteLine(min.ToString());

            var Len = clA.Where(p => p.length == 3 || p.length == 5 || p.length == 7);
            Console.WriteLine($"массив векторов(один) длины(количество элементов) 3,5,7: ");
            foreach (var i in Len)
            {
                Console.Write(i.ToString());
            }

            var max = clA
               .OrderBy(n => n.sum)
                  .Last();
            Console.Write($"Максимальный вектор: ");
            Console.WriteLine(max.ToString());

            var otr = clA
           .Where(n => n.sum < 0)
              .First();
            Console.Write($"первый вектор с отрицательной суммой: ");
            Console.WriteLine(otr.ToString());

            var MinMax = clA
               .OrderBy(n => n.length);
            Console.Write($"упорядоченный список векторов по размеру:\n ");
            foreach (var i in MinMax)
            {
                Console.Write(i.ToString());
            }
            //4

            Console.Write($"5 операторов из разных категорий:\n ");
            var My = clA
               .Select(m => new { m.sum, m.length }) //коллекция состоит только из суммы и длинны ПРОЕКЦИЯ
                .Where(n => n.sum > 0)
               .OrderBy(n => n.sum)
                .GroupBy(n => n.length)
               .Take(5);
            foreach (var i in My)
            {
                Console.WriteLine(i.Key);

                //Console.Write(i.ToString());
            }
            //зд5
            Car[] car =
            {
            new Car(1999, "Mazda"),
            new Car(1999, "Ford"),
             new Car(1999, "Mustang"),
            };
            detals[] Detals =
            {
            new detals("motor", "Mazda"),
             new detals("engine", "Ford"),
             new detals("engine", "BMW")
            };
            var CARS = from p in car
                       join c in Detals on p.Name equals c.Mark
                            select new { Company = p.Name, Year = p.year, detals = c.kind };
            foreach (var emp in CARS)
                Console.WriteLine($"{emp.Company} - {emp.detals} ({emp.Year})");





            /*  int[] key = { 1, 5, 6, 8 };
              var SelectedAirline = clA
              .Join(
              key,
              n => n.arr.Length,
              t => t,
              (n, t) => new
              {
                  PlaneType = n.arr,
                  key = string.Format($"{t}")
              });

              foreach (var item in SelectedAirline)
              {
                  Console.WriteLine(item);
              }*/

        }

    }
}