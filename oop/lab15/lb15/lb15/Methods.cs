using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb15
{
    public class Methods
    {
        public static void VECTORS()
        {
            int m = 5;
            int[] mas = new int[10000];
            Random rand = new Random();

            for (int i = 0; i < 1000; i++)
            {
                mas[i] = rand.Next(-100, +1000) * 5;
            }
            Console.WriteLine("Vector inicial");
          
        }
       public static void Square(int num)
        {
            int u;
            u = num * num;

            Console.WriteLine($"Квадрат числа {num} равен {u}");
        }
    }
}
