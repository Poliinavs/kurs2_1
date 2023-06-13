using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb10
{

    class Vector
    {
        public int State = 1;
        public int sum;
        /*   private int State;
           public int state
           {
               get { return State; }
               set
               {
                       State = value;
               }
           }*/

        private int[] Arr;
        public int[] arr
        {
            get { return Arr; }
            set { Arr = value; }
        }

        private int Length;
        public int length
        {
            get { return Length; }
            set { Length = value; }
        }

        //конструкторы
        public Vector(int[] array)
        {
            Arr = array;
            length = array.Length;
            int sum = 0;
            for (int i = 0; i < length; i++)
            {

                sum += array[i];
            }
            this.sum = sum;

        }
        Random rnd = new Random();

        //Получить очередное (в данном случае - первое) случайное число

        public Vector()
        {
            this.State = rnd.Next(0, 100);
            this.length = rnd.Next(1, 8);
            // int[] arr33_mas = { rnd.Next(-10, 10), rnd.Next(-10, 10), rnd.Next(-10, 10), rnd.Next(-10, 10) };
            int[] arr33_mas = new int[this.length];
            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                arr33_mas[i] = rnd.Next(-4, 10);
                sum += arr33_mas[i];
            }
            this.sum = sum;
            this.arr = arr33_mas;

        }
 


        public override string ToString()
        {
            Console.Write("Массив: ");
            foreach (int a in arr)
            {
                Console.Write(a + " ");
            }
            return "\tДлина: " + length + "\n";
            //return $"\t\tСостояние:{State}\t Длина:{length} \t Первый элемент:{arr[0]}\n";
        }


        public int this[int index]
        {
            set
            {
                arr[index] = value;
            }

            get
            {
                return arr[index];
            }
        }
       

    }

    
}
