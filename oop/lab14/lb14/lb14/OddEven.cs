using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb14
{
    public class OddEven
    {
        static string filePath = "C:\\instit\\kurs2\\oop\\lab14\\inf.txt";
        public static StreamWriter file = new StreamWriter(filePath, false);
        public static Mutex mutexObj = new();
        public static void Even()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    file.Write(i + " ");
                    Console.Write(i + " ");

                }
                Thread.Sleep(100);
            }
        }
        public static void Odd()
        {

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 != 0)
                {
                    file.Write(i + " ");
                    Console.Write(i + " ");
                }
                Thread.Sleep(100);
            }

        }



        public static void Org_Even()
        {

            Thread.Sleep(1000);
            Console.WriteLine("\nCначала нечетные, потом четные числа:");
            file.WriteLine("\nCначала нечетные, потом четные числа:");
            mutexObj.WaitOne();
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    file.Write(i + " ");
                    Console.Write(i + " ");

                }
                Thread.Sleep(100);
            }
            mutexObj.ReleaseMutex();
        }
        public static void Org_Odd()
        {
            Thread.Sleep(1000);
            mutexObj.WaitOne();
            for (int i = 0; i < 9; i++)
                {
                    if (i % 2 != 0)
                    {
                        file.Write(i + " ");
                        Console.Write(i + " ");
                    }
                    Thread.Sleep(100);
                }
                mutexObj.ReleaseMutex();
            }
    }
}
