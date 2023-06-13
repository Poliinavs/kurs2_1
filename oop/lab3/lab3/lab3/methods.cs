using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
   static public class ST{

       static public void find_number(this ARR m, int x)
        {
            foreach (int i in m.Arr)
            {
                if (i == x)
                {
                    Console.WriteLine($"Число найдено в массиве");
                    return;
                }
            }
            Console.WriteLine($"Число не найдено в массиве");
        }

        static public void negative_elements(this ARR m)
        {
            int k = 0;
            foreach (int i in m.Arr)
            {
                if (i >= 0)
                    k++;
            }
            int[] Arr1 = new int[k];
            k = 0;
            foreach (int i in m.Arr)
            {
                if (i >= 0)
                {
                    Arr1[k] = i;
                    k++;
                }
            }
            Console.WriteLine();
            Console.Write("Массив состоящий из положительных чисел:");
            foreach (int t in Arr1)
                Console.Write("{0}\t", t);
        }
    }
}
