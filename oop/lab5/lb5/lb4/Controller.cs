using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Найти Игрушки определенного типа и текстовый редактор
заданной версии, вывести все ПО в алфавитном порядке.*/

namespace lb4
{
    class Controller
    {
        public void Search_Game(Container ct, string type) //Найти Игрушки определенного типа
        {
            Game gm=new Game();
            Console.WriteLine("Game Aplication");
                foreach (Soft item in ct.list)
            {
                if (item.GetType().Name == "Game")
                    if (item.Type == type)
                        Console.WriteLine(item.ToString());
            }
        }
        public void Search_text(Container ct, string type) //Найти Игрушки определенного типа
        {
            Console.WriteLine("Text-processor 12.03");
            foreach (Soft item in ct.list)
            {
                if (item.GetType().Name == "Text_processor")
                    if (item.Type == type)
                        Console.WriteLine(item.ToString());
            }
        }
        public void Alpha(Container ct) //Найти Игрушки определенного типа
        {
            Console.WriteLine("Alpha");
                    int x = 5;
            int k = 0;
            int c = 0;
            while (c !=4 )
            {
                foreach (Soft item in ct.list)
                {
                    foreach (Soft item1 in ct.list)
                    {
                        if (item.PO_name.CompareTo(item1.PO_name) < 0)
                            k += 1;
                    }
                    
                    if (x == k)
                    {
                        Console.WriteLine(item.ToString());
                        item.PO_name = "zzzzzz";
                        c++;
                    }
                    k = 0;
                }
            }
        }

        /*  public void AL ()
              {

              IEnumerable<string> query = from word in words
                                          orderby word.Length
                                          select word;
              *//* Console.WriteLine(GM);
               foreach (Game item in GM)
               {
                   Console.WriteLine(item.ToString());
               }*//*
          }*/


    }
}