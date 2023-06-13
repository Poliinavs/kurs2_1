using System;

namespace lb4
{

    class Class1
    {
        static void Main(string[] args)
        {
       

            //Переопределение
            Game game = new Game("Applied", "Snake");
            game.Print();
            Console.WriteLine();
            soft_creator SF1 = new soft_creator("Applied", "Brody");
            SF1.Print();
            Text_processor WR1 = new Text_processor("Applied", "Word", "text processor");
            WR1.Print();
            //переопределение методов от OBJECT
            Saper saper = new Saper("Applied", "Game", "SAPER");
            Saper saper1 = new Saper("Appl", "Game", "SAPER");
            Console.WriteLine($"GetHashCode: {saper.GetHashCode()}");
            Console.WriteLine($"{saper.ToString()}");
            Console.WriteLine($"Сравнение: {saper.Equals(saper1)}");



            //IS и AS

            if (saper is Game) //выдает  True False
            {
                Console.WriteLine("This is Game");
            }
            if (saper is Soft)
            {
                Console.WriteLine("This is Soft");
            }

            if(saper as Game==null) //Преобразует к типу
            {
                Console.WriteLine("Невозможно привести saper к типу Game");
            } else
            {
                Console.WriteLine("Можно привести");
            }
            if (game as Saper == null)
            {
                Console.WriteLine("Невозможно привести game к типу Saper");
            }
            else
            {
                Console.WriteLine("Можно привести");
            }

            List<Soft> list = new List<Soft> { new soft_creator("Applied", "Brody"), new Saper("Applied", "Game", "SAPER"), new Text_processor("Applied", "Word", "text processor") };
            Printer printer = new Printer();
   
             foreach (Soft v in list)
              {

                Console.WriteLine(printer.IAmPrinting(v));
              }
        }
    }
}