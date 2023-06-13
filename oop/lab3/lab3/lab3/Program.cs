using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace lab3
{
    public partial class ARR
    {
        public int[] Arr;
        public int length;
        public ARR(int Size)
        {
            Arr = new int[Size];
            length = Size;
        }
        public int this[int index]
            {
                set
                {
                    Arr[index] = value;
                }

                get
                {
                    return Arr[index];
                }
            }
        public void wwod_out()
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
        }
    }



        class Class1
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите размер массива:");
            int amount_elem = int.Parse(Console.ReadLine());
            ARR arr1 = new ARR(amount_elem);
            Console.Write("Массив 1:");
            arr1.inicial();
            ARR arr2 = new ARR(amount_elem);
            Console.WriteLine();
            Console.Write("Массив 2:");
            arr2.inicial();
            ARR rez_umn = new ARR(amount_elem);
            Console.WriteLine();
            Console.Write("Результат умножения двух массивов:");
            rez_umn =arr2*arr1;
            rez_umn.wwod_out();
            
            int[] arr11_mas = { 1, 3, 4 };
            int[] arr33_mas = { -1, 1, 4 };
            ARR arr11 = new ARR(3);
            ARR arr22 = new ARR(3);
            ARR arr33 = new ARR(3);
            arr11.Arr = arr11_mas;
            arr22.Arr = arr11_mas;
            arr33.Arr = arr33_mas;
            
            Console.WriteLine();
            Console.Write("Массив11: ");
            arr11.wwod_out();
            Console.Write("Массив22: ");
            arr22.wwod_out();
            Console.Write("Массив33: ");
            arr33.wwod_out();
            Console.WriteLine($"Массив 11 равен массиву 22: {arr11.Arr == arr22.Arr}");
            Console.WriteLine($"Массив 11 равен массиву 33: {arr11.Arr == arr33.Arr}");
            Console.WriteLine($"Массив 11 < массива 22: {arr11 < arr33}");
            Console.WriteLine($"Массив 11 > массива 22: {arr11 > arr33}");
            if (arr11)
            {
                Console.WriteLine("Все элементы массива 11 положительные");
            }
            else
            {
                Console.WriteLine("Есть отрицательные элементы в массиве 11");
            }
            if (arr33)
            {
                Console.WriteLine("Все элементы массива 33 положительные");
            }
            else
            {
                Console.WriteLine("Есть отрицательные элементы в массиве 33");
            }
            Console.WriteLine($"Размер массива 11: {(int)arr11}");

            Console.WriteLine();
        

            ARR.Developer Ann = new ARR.Developer(15, "Ann");
            ARR.Developer Max = new ARR.Developer(7, "Max");
            ARR.Production OTS = new ARR.Production(1, "OTS");
            ARR.Production SPP = new ARR.Production(17, "SPP");
            //            Создайте статический класс StatisticOperation, содержащий 3 метода для
            //работы с вашим классом(по варианту п.1): сумма, разница между
            //максимальным и минимальным, подсчет количества элементов
            Console.WriteLine($"Разница между максимальным и минимальным: {StatisticOperation.differen(arr1)}");
            Console.WriteLine($"Подсчет суммы: {StatisticOperation.sum(arr1)}");
            Console.WriteLine($"Количество элементов: {StatisticOperation.amount(arr1)}");
            //расширение 
            string ab = "hellow how are you";
            Console.WriteLine($"{ab}\tКоличество слов: {ab.CountOfWords()}");

            Console.WriteLine("Введите число для проверки в массиве 1:");
            int find = int.Parse(Console.ReadLine());
            arr1.find_number(find);
            arr1.negative_elements();
            arr2.negative_elements();

        }
    }
}