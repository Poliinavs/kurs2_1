using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace lab3
{
  



        class Class1
    {
        static void Main(string[] args)
        {
            try
            {

                //пользоват класс в качестве параметра 
                CollectionType<Developer> cl1 = new CollectionType<Developer>();
                Developer Ann = new Developer(15, "Ann");
                Developer Max = new Developer(7, "Max");
                Developer Alex = new Developer(21, "Alex");
                Developer Ivan = new Developer(88, "Ivan");


                List<Developer> ls1 = new List<Developer>() { Ann, Max, Alex };
                Console.WriteLine("Developer collection: ");
                cl1.Collection = ls1;
                cl1.Show();
                cl1.Add(Ivan);
                cl1.Delete(Max);
                Console.WriteLine("After methods: ");
                cl1.Show();

                cl1.HasPerson(cl1, Ann);
                /////////////////////////////////////////////////
                int[] AI = { 2, 8, 3, 4, 11, 17, 5 };
                ArrayItems<int> A1 = new ArrayItems<int>(AI);
                int Num = 130;
                A1.Add(Num);
                A1.Print();

                int delNum = 1;
                A1.Delete(delNum);
                A1.Print();

                ///////////////////////////////////////////////
                Dictionary<string, int>person = new Dictionary<string, int>();
               person.Add("Ann", 10);
               person.Add("Max", 40);
               person.Add("Alex", 28);
               person.Add("Nikita", 34);

                Console.WriteLine("------------file-------------");

                Save<Developer>.WriteToFile(cl1.Collection);
                Save<Developer>.ReadFromFile();

               /* List<int> a = new List<int> { 1, 2, 3 };
                Save<int>.WriteToFile(a);
                Save<int>.ReadFromFile();*/



                 cl1.Collection = null;


            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("END");
            }












            //Developer Ann = new Developer(15, "Ann");
            //Developer Max = new Developer(7, "Max");
            //Production OTS = new Production(1, "OTS");
            //Production SPP = new Production(17, "SPP");
            //Console.WriteLine("Введите размер массива:");
            //int amount_elem = int.Parse(Console.ReadLine());
            //ARR arr1 = new ARR(amount_elem);
            //Console.Write("Массив 1:");
            //arr1.inicial();
            //ARR arr2 = new ARR(amount_elem);
            //Console.WriteLine();
            //Console.Write("Массив 2:");
            //arr2.inicial();
            //ARR rez_umn = new ARR(amount_elem);
            //Console.WriteLine();
            //Console.Write("Результат умножения двух массивов:");
            //rez_umn =arr2*arr1;
            //rez_umn.wwod_out();

            //int[] arr11_mas = { 1, 3, 4 };
            //int[] arr33_mas = { -1, 1, 4 };
            //ARR arr11 = new ARR(3);
            //ARR arr22 = new ARR(3);
            //ARR arr33 = new ARR(3);
            //arr11.Arr = arr11_mas;
            //arr22.Arr = arr11_mas;
            //arr33.Arr = arr33_mas;

            //Console.WriteLine();
            //Console.Write("Массив11: ");
            //arr11.wwod_out();
            //Console.Write("Массив22: ");
            //arr22.wwod_out();
            //Console.Write("Массив33: ");
            //arr33.wwod_out();
            //Console.WriteLine($"Массив 11 равен массиву 22: {arr11.Arr == arr22.Arr}");
            //Console.WriteLine($"Массив 11 равен массиву 33: {arr11.Arr == arr33.Arr}");
            //Console.WriteLine($"Массив 11 < массива 22: {arr11 < arr33}");
            //Console.WriteLine($"Массив 11 > массива 22: {arr11 > arr33}");
            //if (arr11)
            //{
            //    Console.WriteLine("Все элементы массива 11 положительные");
            //}
            //else
            //{
            //    Console.WriteLine("Есть отрицательные элементы в массиве 11");
            //}
            //if (arr33)
            //{
            //    Console.WriteLine("Все элементы массива 33 положительные");
            //}
            //else
            //{
            //    Console.WriteLine("Есть отрицательные элементы в массиве 33");
            //}
            //Console.WriteLine($"Размер массива 11: {(int)arr11}");

            //Console.WriteLine();


            //ARR.Developer Ann = new ARR.Developer(15, "Ann");
            //ARR.Developer Max = new ARR.Developer(7, "Max");
            //ARR.Production OTS = new ARR.Production(1, "OTS");
            //ARR.Production SPP = new ARR.Production(17, "SPP");
            ////            Создайте статический класс StatisticOperation, содержащий 3 метода для
            ////работы с вашим классом(по варианту п.1): сумма, разница между
            ////максимальным и минимальным, подсчет количества элементов
            //Console.WriteLine($"Разница между максимальным и минимальным: {StatisticOperation.differen(arr1)}");
            //Console.WriteLine($"Подсчет суммы: {StatisticOperation.sum(arr1)}");
            //Console.WriteLine($"Количество элементов: {StatisticOperation.amount(arr1)}");
            ////расширение 
            //string ab = "hellow how are you";
            //Console.WriteLine($"{ab}\tКоличество слов: {ab.CountOfWords()}");

            //Console.WriteLine("Введите число для проверки в массиве 1:");
            //int find = int.Parse(Console.ReadLine());
            //arr1.find_number(find);
            //arr1.negative_elements();
            //arr2.negative_elements();

        }
    }
}