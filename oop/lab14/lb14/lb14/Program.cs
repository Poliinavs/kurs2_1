using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace lb14
{
    class Class1
    {
        

        public static void Numbers(object? length)
        {
            Console.WriteLine("Number: ");
            using (StreamWriter sr = new("Ex3.txt", false))
            {
                for (int i = 0; i < (int)length; i++)
                {
                    if (i == 4)
                    {
                        Console.WriteLine("Name: " + Thread.CurrentThread.Name);
                        Console.WriteLine("Id: " + Thread.CurrentThread.ManagedThreadId);
                        Console.WriteLine("Priority: " + Thread.CurrentThread.Priority);
                        Console.WriteLine("Status: " + Thread.CurrentThread.ThreadState);
                        Console.WriteLine("Number ind: " + Thread.CurrentThread.ManagedThreadId);
                    }

                    sr.Write(i + " ");


                    Thread.Sleep(300);
                    Console.WriteLine(i);
                }
            }
        }

        public static void Count(object obj)
        {
            int x = (int)obj;
            for (int i = 1; i < 9; i++, x++)
            {
                Console.WriteLine($"{x * i}");
            }
            OddEven.file.Close();
        }


        static void Main(string[] args)
        {
            Console.WriteLine("---------------------- EX 1 ----------------------\n");
           GetProcess.GetAllProcess();
            Console.WriteLine("---------------------- EX 2 ----------------------\n");
            GetDomain.GetInfoDomain();

            Console.WriteLine("");
            GetDomain.CreateDomain();
            Console.WriteLine("---------------------- EX 3 ----------------------\n");
            /*  Создайте в отдельном потоке следующую задачу расчета(можно сделать sleep для
  задержки) и записи в файл и на консоль простых чисел от 1 до n(задает пользователь). 
  Вызовите методы управления потоком(запуск, приостановка, возобновление и т.д.) Во
  время выполнения выведите информацию о статусе потока, имени, приоритете, числовой
  идентификатор и т.д.*/
            Console.WriteLine("Введите n:");
            int n = Convert.ToInt32(Console.ReadLine());
            Thread myThread1 = new Thread(new ParameterizedThreadStart(Numbers)); //поток с параметрами
            myThread1.Start(n);
            myThread1.Join();
            Console.WriteLine("---------------------- EX 4 ----------------------\n");


            Console.WriteLine("Четные и нечетные числа:");
            OddEven.file.WriteLine("Четные и нечетные числа:");
            Thread thread1 = new Thread(OddEven.Even);
            Thread thread2 = new Thread(OddEven.Odd);

            thread1.Priority = ThreadPriority.Highest;
            thread1.Start();
            thread2.Priority = ThreadPriority.Highest;
            thread2.Start();

            Console.WriteLine("\nCначала нечетные, потом четные числа:");

            Thread th1 = new Thread(OddEven.Org_Even);
            Thread th2 = new Thread(OddEven.Org_Odd);

            th2.Priority = ThreadPriority.Lowest;
            th1.Start();
            th2.Start();


            ///////Придумайте и реализуйте повторяющуюся задачу на основе класса Timer
            Console.WriteLine("До конца программы осталось:");

            int num = 0;
            // устанавливаем метод обратного вызова
            TimerCallback tm = new TimerCallback(Count);

            Timer timer = new Timer(tm, 10, 5000, 600);                                                 //метод, объект для передачи в метод, мс через кот таймер запускается, интервал между вызовами метода
            Thread.Sleep(6000);
            Console.WriteLine("Time is over...");
            timer.Dispose();
            Console.ReadLine();
           




            ////////2
            ///Исследуйте текущий домен вашего приложения: имя, детали конфигурации, все сборки,
            ////  загруженные в домен.Создайте новый домен.Загрузите туда сборку.Выгрузите домен.
            /* AppDomain domain = AppDomain.CurrentDomain;
             Console.WriteLine($"Name: {domain.FriendlyName}");
             Console.WriteLine($"Base Directory: {domain.BaseDirectory}");
             Console.WriteLine("Conficuration file name: " + domain.SetupInformation.ToString());
             Console.WriteLine("Assemblies:");
             foreach (var l in domain.GetAssemblies())
             {
                 Console.WriteLine(l);
             }
             Console.WriteLine("Creating new AppDomain.");*/
            /* AppDomain newD = AppDomain.CreateDomain("ProfessorWebAppDomain");

             Console.WriteLine("Host domain: " + AppDomain.CurrentDomain.FriendlyName);
             Console.WriteLine("child domain: " + newD.FriendlyName);*/
            //AppDomain MyDomain = AppDomain.CreateDomain("BVDDomain");
            //MyDomain.Load("OOP_Lab15");
            //AppDomain.Unload(MyDomain);

            //Console.WriteLine();

            //Thread thread = new Thread(Numbers)
            //{
            //    Name = "Numbers thread"
            //};
            //thread.Start();
            //thread.Join();

            //Console.WriteLine();


        }
    }
}