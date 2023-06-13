using System;
namespace lb8
{
    //сделать одно событие, которое вызывает 1 делегат или 2 делегата 
    //с помощь делегатов можно создавать группы методов(туда добавл методы и они все вызов), с помощью event группы делегатов
    class Class1
    {
        public static event Action<string> strEvent;
        public static event Predicate<string> strEvent1;
        static void Main(string[] args)
        {
            User pr1 = new User(123, 2000);
            User pr2 = new User(124, 3000);
            User pr3 = new User(125, 4000);

            methods sm = new methods();

            pr1.move += sm.DOmove;
            pr1.compress+=sm.DOcompress;
            pr1.add(14, 10, "Worker");


          //событие  move будет указывать на 2 делегата
            pr2.move += sm.DOmove;
            pr2.move += sm.DOcomp;
            pr2.compress += sm.DOcompress;
            pr2.compress += sm.DOcompress; //будет вызываться 2 раза 
            pr2.add(15, 19, "programmer");
            //пользоват обработка 
            
            string str = "Hellow, how are you.";
            Console.WriteLine("Обработка строки: " + str);
            StrCor string_correct = new();
            strEvent += string_correct.Del_punc;
            strEvent += string_correct.UpperCase;
            strEvent += string_correct.DelSpace;
            strEvent(str);

            strEvent1 += string_correct.FindSymb;
            Console.WriteLine("В строке есть ! "+ strEvent1(str));


            
            // Predicate<string> isPositive += FindSymb;

        }
    }
}