using System;
namespace lb4
{
    class Class1
    {
        static void Main(string[] args)
        {
            //enum and struct
            Video_game video_Game = new Video_game { name = "Pacman", year= (int)Game_name.Pacman};
            Video_game video_Game3 = new Video_game { name = "GTA", year = (int)Game_name.GTA };
            Video_game video_Game2 = new Video_game { name = "Counter_strike", year = (int)Game_name.Counter_strike };
            video_Game.Print();
            video_Game2.Print();
            video_Game3.Print();

            //Контейнер
            Console.WriteLine("КОНТЕЙНЕР");
            Game game = new Game("Applied", "ASnake");
            Game game1 = new Game("Soft", "Calculator");
            Game game2 = new Game("Applied", "Pacman");
            Text_processor WR1 = new Text_processor("12.05", "Word", "Applied");
            Text_processor WR2 = new Text_processor("12.03", "Libre", "Applied");
            Text_processor WR3 = new Text_processor("12.03", "Goofle_notes", "Applied");

            List<object> Soft_part = new List<object> { game,  game1, WR1, game2, WR3, WR2 };
            Container container = new Container();
            container.mainList = Soft_part;
            container.PrintElems();

             Console.WriteLine("Методы: "); 
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
        }
    }
}