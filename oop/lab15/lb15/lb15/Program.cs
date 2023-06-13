using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;



namespace lb15
{
    class Class1
    {

        static void Main(string[] args)
        {
            ////1
            Stopwatch stopwatch = new Stopwatch();
            Task task1 = new Task(Methods.VECTORS);
           
            task1.Start();
            Console.WriteLine("Id: " + task1.Id);
            Console.WriteLine("Is completed?: " + task1.IsCompleted);
            Console.WriteLine("Status: " + task1.Status);
            stopwatch.Stop();
            task1.Wait();
            

            TimeSpan ts = stopwatch.Elapsed;
            Console.WriteLine("RunTime: " + stopwatch.Elapsed);
            Console.WriteLine();
            ////2

            CancellationTokenSource CancelToken = new CancellationTokenSource();
            CancellationToken token = CancelToken.Token;
            Task task2 = new Task(Methods.VECTORS, token);
            task2.Start();
            CancelToken.Cancel();
            if (token.IsCancellationRequested)
            {
                Console.WriteLine("Is canceled");
            }
            Console.WriteLine();

            ////3
            Task<int> sumTask = Task<int>.Factory.StartNew((object a) =>
            {

                Console.WriteLine("Thread id: " + Thread.CurrentThread.ManagedThreadId);

                int num = (int)a;
                int sum = 0;
                for (int i = 0; i <= num; ++i)
                    sum += i;
                return sum;
            }
            , 10);
            Task<int> delTask = Task<int>.Factory.StartNew((object a) =>
            {

                Console.WriteLine("Thread id: " + Thread.CurrentThread.ManagedThreadId);

                int num = (int)a;
                int del = 1;
                for (int i = 1; i <= num; ++i)
                    del *= i;
                return del;
            }
        , 10);
            Task<string> word = Task<string>.Factory.StartNew((object a) =>
            {

                Console.WriteLine("Thread id: " + Thread.CurrentThread.ManagedThreadId);

                string str = (string)a;
                string str2 = "";

                for (int i = 0; i < str.Length; ++i)
                {
                    if (str[i] != ' ')
                        str2 += str[i];
                }
                return str2;
            }
      , "hellow how are you");


            var t1 = sumTask.ContinueWith(task => PrintResult(task.Result));

            void PrintResult(int sum) => Console.WriteLine($"Sum: {sum}");
            sumTask.Wait();

            var t3 = word.ContinueWith(task => PrintResultS(task.Result));
            void PrintResultS(string sum) => Console.WriteLine($"String without probel: {sum}");
            word.Wait();

            var t2 = delTask.ContinueWith((i, k) => { return i.Result / (int)k; }, 2000).GetAwaiter().GetResult();
            Console.WriteLine($"Result1 delTask(10) {delTask.Result}");
            Console.WriteLine($"Result2 delTak( ) {t2}");
            delTask.Wait();

            ////5 инициализац
            int[] arr1 = new int[1000000];
            int[] arr2 = new int[1000000];
            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();
            Parallel.For(0, arr1.Length, t => arr1[t] = t); //с какого индекса начианаем по какой и действие 
            stopwatch2.Stop();
            Console.WriteLine($"Parallel.For: {stopwatch2.Elapsed}");

            Stopwatch stopwatch3 = new Stopwatch();
            stopwatch3.Start();
            for (int i = 0; i < arr2.Length; i++)
                arr2[i] = i;
            stopwatch3.Stop();
            Console.WriteLine("foreach: " + stopwatch3.Elapsed);
            //////
            Stopwatch stopwatch4 = new Stopwatch();
            stopwatch4.Start();
            Parallel.ForEach<int>(new List<int>() { 1, 2, 3, 4 }, Methods.Square);
            stopwatch4.Stop();
            Console.WriteLine("Parallel.Foreach: " + stopwatch4.Elapsed);

            Stopwatch stopwatch5 = new Stopwatch();
            stopwatch5.Start();
            foreach (var m in new List<int>() { 1, 2, 3, 4 })
            {
                Methods.Square(m);
            }
            stopwatch5.Stop();
            Console.WriteLine("foreach: " + stopwatch5.Elapsed);
            Console.WriteLine();
            ////6
            Parallel.Invoke(
               Methods.VECTORS,
                () =>
                {
                    Console.WriteLine($"Выполняется задача {Task.CurrentId}");
                    Thread.Sleep(1000);
                },
                () => Methods.Square(5)
            );
            ////7
            Postavk.bc = new BlockingCollection<string>(4);

            // Создадим задачи поставщика и потребителя
            Task Pr = new Task(Postavk.producer);
            Task Cn = new Task(Postavk.consumer);


            Pr.Start();
            Cn.Start();
            Cn.Wait();
            Pr.Wait();
            //8
            Assinx.Assin();
            Console.ReadLine();




        }
    }
}