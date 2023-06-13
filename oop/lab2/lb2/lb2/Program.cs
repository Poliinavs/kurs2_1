
//////Создать класс Вектор, который содержит массив int, число 
//////элементов и переменную состояния. Определить 
//////индексатор. В переменную состояния устанавливать код 
//////ошибки, при определенной ситуации. Определить методы:
//////сложения и умножения, которые производят эти операции 
//////с данными класса вектор и числом int
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace lab2
{
    // сделайте касс partial частично определен
     partial class Vector
    {
        private int State;
        public int state
        {
            get { return State; }
            set
            {
                if (value < 0 || value > 999)
                {
                    State = 0;
                }
                else
                {
                    State = value;
                }
            }
        }

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

        public Vector(int Size)
        {
            arr = new int[Size];
            length = Size;
        }
        public Vector()
        {
            this.state = 1;
            int[] arr33_mas = { 1, -3, 0, 1 };
            this.arr = arr33_mas;
            this.length = 4;
        }
        public Vector(int state, int[] arr, int length)
        {
            this.state = state;
            this.arr = arr;
            this.length = length;
        }
        public Vector(int[] arr, int state = 5)
        {
            this.length = arr.Length;//по умолчанию
        }

        //статический конструктор
        static Vector()
        {
            Console.WriteLine("Vectors:");
        }

        //закрытый конструктор  не может быть в main создан экземпляр  Vector aCounter = new Vector();
       // private Vector() { } 


        //        поле - только для чтения(например, для каждого экземпляра сделайте
        //поле только для чтения ID - равно некоторому уникальному номеру
        //(хэшу) вычисляемому автоматически на основе инициализаторов
        //объекта);

        readonly string ID = Guid.NewGuid().ToString();

        //поле- константу;                    Таким полям можно присвоить значение либо при непосредственно при их объявлении, либо в конструкторе. В других местах программы присваивать значение таким полям нельзя, можно только считывать их значение
        public const string country = "Belarus";

       // //создайте в классе статическое поле, хранящее количество созданных
       //объектов(инкрементируется в конструкторе) и статический
       //метод вывода информации о классе.*//*

        public static int count;
        public Vector(int x, int y)
        {
            count++;
            this.State = x;
            this.length = y;
            Vector.count++;
        }
        static int print()
        {
            Console.WriteLine($"Количество : {count}");
            return count;
        }
       //*//
       //* переопределяете методы класса Object: Equals, для сравнения объектов,
       // GetHashCode; для алгоритма вычисления хэша руководствуйтесь
       // стандартными рекомендациями, ToString – вывода строки –
       // информации об объекте.*//*
        public override int GetHashCode()
        {
            int Hash;
            Hash = state / length;
            Console.WriteLine($"Hashcode of length: {Hash}");
            return Hash;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Vector m = obj as Vector; // возвращает null если объект нельзя привести к типу Money
            if (m as Vector == null)
                return false;

            return m.length == this.length && m.state == this.state;
        }
        public override string ToString()
        {
            return $"Состояние:{state}\t Длина:{length}";
        }
        //4) Создайте и выведите анонимный тип (по образцу вашего класса)


        //Создать массив объектов.
        public static void Array()
        {
            var Vectors_mas = new Vector[3];
            int[] arr11_mas = { 0, 3, 5, 6 };
            int[] arr22_mas = { 1, -30, 5, 6 };
            int[] arr33_mas = { 1, -3, 0, 1 };
            Vectors_mas[0] = new Vector(800, arr11_mas, arr11_mas.Length);
            Vectors_mas[1] = new Vector(700, arr22_mas, arr22_mas.Length);
            Vectors_mas[2] = new Vector(600, arr33_mas, arr33_mas.Length);
            //Создать массив объектов. Вывести: a) список векторов, содержащих 0;
            int sum = 0;
            int Minsum = int.MaxValue;
            Vector Vectors_min = new Vector(800, arr11_mas, arr11_mas.Length);
            foreach (var item in Vectors_mas)
            {
                for (int i = 0; i < item.Arr.Length; i++)
                {
                    if (item.Arr[i] == 0)
                    {
                        Console.Write("Масиив содержащий 0:Состояние: {0} Длина: {1}", item.state, item.length);
                        Console.Write(" Элементы: ");
                        for (int b = 0; b < item.Arr.Length; b++)
                            Console.Write($"\t {item.Arr[b]}");
                        Console.WriteLine();
                    }
                    sum += Math.Abs(item.Arr[i]);
                }

                if (sum < Minsum)
                {
                    Minsum = sum;
                    Vectors_min = item;
                }
                sum = 0;
            }
            for (int i = 0; i < Vectors_min.Arr.Length; i++)
            {
                if (Vectors_min.Arr[i] == 0)
                {
                    Console.Write("Вектор с минимальным модулем:Состояние: {0} Длина: {1}", Vectors_min.state, Vectors_min.length);
                    Console.Write(" Элементы: ");
                    for (int b = 0; b < Vectors_min.Arr.Length; b++)
                        Console.Write($"\t {Vectors_min.Arr[b]}");
                    Console.WriteLine();
                }

            }

        }

        //список векторов с наименьшим модулем.

        //индексатор
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
    partial class Vector
    {
        //ref -и out-параметры
        public void sum(ref int i, out int sum)
        {
            sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            sum += i;
        }
        public void multiplication(int i)
        {
            int mult = 1;
            foreach (var item in arr)
            {
                mult *= item;
            }
            mult *= i;
            Console.WriteLine($"Произведение элементов: {mult}");
        }
    }

        class Program
    {
        static void Main(string[] args)
        {
            //использование конструкторов
            Vector arr1 = new Vector(5);
            // Инициализируем каждый индекс экземпляра класса arr1
            for (int i = 0; i < arr1.length; i++)
            {
                arr1[i] = i + 1;
                Console.Write("{0}\t", arr1[i]);
            }
            int k = 4;
            int summa;
            arr1.sum(ref k, out summa);
            Console.WriteLine();
            Console.WriteLine($"Сумма элементов: {summa}");
            arr1.multiplication(5);
            int[] arr2_mas = { 1, 3, 4 };
            int[] arr4_mas = { 1, 1, 4 };
            //вызов конструкторов
            Vector arr299 = new Vector();
            Vector arr3 = new Vector(arr2_mas); //по умолчанию
            Vector arr2 = new Vector(1000, arr2_mas, arr2_mas.Length); //err2 экземп

            Vector arr4 = new Vector(1000, arr4_mas, arr4_mas.Length);
            Vector arr5 = new Vector(800, arr4_mas, arr4_mas.Length);
            
            //переопределение 
            arr5.GetHashCode();
            Console.WriteLine($"Сравнение: {arr2.Equals(arr4)}");
            Console.WriteLine($"Вывод: {arr5.ToString()}");
            Vector.Array();
            //4) Создайте и выведите анонимный тип(по образцу вашего класса)
            var arr55 = new { State= 9, arr=arr4_mas,lengh=arr4_mas.Length };
            Console.WriteLine($"анонимный тип: {arr55.State}, длина: {arr55.lengh},первый элемент: {arr55.arr[0]}  ");

        }
    }
}



