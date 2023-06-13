using System;
using System.Diagnostics;
using System.Diagnostics;

namespace lb4
{
    class Class1
    {

        static void Main(string[] args)
        {
         
            /* Debugger.Break(); //точка останова
             * Debugger.Launch();///присоед отладчик 
            */

            /*  int n = 11;
              Debug.Assert(n <= 10, "Недопустимое значение");

              int[] aa = null;
              Debug.Assert(aa != null, "Values array cannot be null");*/


            Debug.Indent();                                                           //задает уровень отступа
            Debug.WriteLine("Entering Main");
            Console.WriteLine("Hello World.");                                        //Записывает значение метода ToString() объекта в прослушиватели трассировки в коллекции Listeners.
            Debug.WriteLine("Exiting Main");
            Debug.Unindent();                                                            //уменьшает уровень отступа -1

           
            try
            {
                Game game = new Game("Applied", "ASnake", 60, 40); //проверяет хватает ли памяти 60-прилржен, 40-на устройстве
            }
            catch (MemberException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
                Console.WriteLine("Вам еще нужно:"  + (ex.Value) +"гб");
                Console.WriteLine("Имя объекта или сборки, которое вызвало исключение:" + (ex.Source));
                Console.WriteLine("Метод, в котором было вызвано исключение:" + ex.TargetSite);
            }
            finally
            {
                Console.WriteLine("-----------------------------------------------------------");
            }

            try
            {
                Game game = new Game("Applied", "ASssssssssssssssssssssssssssssssssssssssssssssnake", 60, 100); //проверяет хватает ли памяти 60-прилржен, 40-на устройстве
                Game game1 = new Game("Applied", "ASnake", 60, 40);
            }
            catch (LenghtException ex)
            {
                StackTrace stack = new StackTrace(ex);
                foreach (StackFrame frame in stack.GetFrames())
                {
                    Console.WriteLine(frame.GetMethod());

                }
                Console.WriteLine("Ошибка: " + ex.Message);
                Console.WriteLine("Некорректные данные:" + (ex.Value) );
            }
            finally
            {

                Console.WriteLine("-----------------------------------------------------------");
            }


            try
            {
                Game game1 = new Game();
                Saper sp = (Saper)game1;
                Console.WriteLine("Можно привести");
            }
            catch (InvalidCastException)
            {

                Console.WriteLine("Невозможно привести game к типу Saper");
            }
            finally
            {
                Console.WriteLine("-----------------------------------------------------------");
            }


            try
            {
                 string[] kinds = { "Applied", "Soft", "Program" };
                Text_processor WR1 = new Text_processor("Application", "Word", "text processor");

            }
            catch (NameException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);

            }
            finally
            {
                Console.WriteLine("-----------------------------------------------------------");
            }


            try
            {
                Text_processor WR3 = new Text_processor("13", "Goofle_notes", "Applied");
                Text_processor WR1 = new Text_processor("12", "Word", "Applied");
                WR1.Version(WR3);
                WR1.Version(WR1);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("{0}: {1}", e.GetType().Name, e.Message); ///////////////////////////
            }
            finally
            {
                Console.WriteLine("-----------------------------------------------------------");
            }



            /* //enum and struct
             Video_game video_Game = new Video_game { name = "Pacman", year= (int)Game_name.Pacman};
             Video_game video_Game3 = new Video_game { name = "GTA", year = (int)Game_name.GTA };
             Video_game video_Game2 = new Video_game { name = "Counter_strike", year = (int)Game_name.Counter_strike };
           *//*  video_Game.Print();
             video_Game2.Print();
             video_Game3.Print();*//*///////////////////////////////////////////
             //Контейнер
             Console.WriteLine("КОНТЕЙНЕР");
             Game game = new Game("Applied", "ASnake");
             Game game1 = new Game("Soft", "Balculator");
             Game game2 = new Game("Applied", "Pacman");
             Text_processor WR1 = new Text_processor("12.05", "Word", "Applied");
             Text_processor WR2 = new Text_processor("12.03", "Libre", "Applied");
             Text_processor WR3 = new Text_processor("12.03", "Goofle_notes", "Applied");

             List<object> Soft_part = new List<object> { game,  game1, WR1, game2, WR3, WR2 };
             Container container = new Container();
             container.mainList = Soft_part;

             container.PrintElems();
              Console.WriteLine("Методы: "); //////////////////////////////////////////////////////////////////////////////////
              Saper saper = new Saper("Applied", "Game", "SAPER");
              container.Add(saper);
              container.Remove(2);

             container.PrintElems();

             Console.WriteLine("Контроллер");
             Controller cntrl = new Controller();
             container.PrintElems();

             cntrl.Search_Game(container, "Applied");
             cntrl.Search_text(container, "12.03");
             Console.WriteLine("Сортировка по алфавиту: ");
             cntrl.Alpha(container);




             List<Text_processor> GM1 = new List<Text_processor> { WR2, WR1, WR3, };
             List<Game> GM = new List<Game> { game, game1, game2, };

             GM = GM.OrderBy(x => x.PO_name).ToList<Game>();
             Console.WriteLine(GM);
             foreach (Game item in GM)
             {
                 Console.WriteLine(item.ToString());
             }


             //GM.Sort();
             *//* GM.Sort(delegate (Game x, Game y)
              {
                  return x.PO_name.CompareTo(y.PO_name);
              });*//*
             Console.WriteLine("Сортировка по алфавиту: ");

           *//*  GM1.Sort(delegate (Text_processor x, Text_processor y)
             {
                 return x.PO_name.CompareTo(y.PO_name);
             });*/






            /* Rose rose1 = new Rose(45, 3, "red");
             Gladiolus glad1 = new Gladiolus(35, 2, "yellow");
             Gladiolus glad2 = new Gladiolus(325, 2, "yellow");
             List<object> bouquet1 = new List<object> { glad2, rose1, glad1 };
             Container container = new Container();
             container.mainList = bouquet1;

             container.PrintElems();
    */

            //Переопределение
            /*   Game game = new Game("Applied", "Snake");
               game.Print();
               Console.WriteLine();
               soft_creator SF1 = new soft_creator("Applied", "Brody");
               SF1.Print();
               Text_processor WR1 = new Text_processor("Applied", "Word", "text processor");
               WR1.Print();*/
            //переопределение методов от OBJECT
            /*    Saper saper = new Saper("Applied", "Game", "SAPER");
                Saper saper1 = new Saper("Appl", "Game", "SAPER");
                Console.WriteLine($"GetHashCode: {saper.GetHashCode()}");
                Console.WriteLine($"{saper.ToString()}");
                Console.WriteLine($"Сравнение: {saper.Equals(saper1)}");*/



            //IS и AS
            /*      
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
                    }*/
        }
    }
}