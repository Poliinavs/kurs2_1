using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ПО, Разработчик  Набор операций, Текстовый процессор, Word, Вирус, 
//CConficker, Игрушка, Сапер, .
//ПО:Набор операций, Текстовый процессор, Word
//kind ПО(Набор операций):, WORD(Текстовый процессор), soft_creator, Игрушка(Сапер),Вирус (CConficker), 
//Ассоциац-имеется(Композиц(класс не может существовать без родительского),Агрегация (может существов)). Наследование- является. 
namespace lb4
{
    
    public abstract class Soft
    {
       public abstract bool DoClone();
       
        private string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

      
        public virtual void Print()
        {
            Console.Write($"Тип: { Type}");
        }
        public override string ToString()
        {
            string rez = "Переопределение toSting: " + this.Type;
            return rez;
        }
    }


    



    /*public class Soft
    {
        private string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        Number_of_operation am; //ассоциация черз композицию: класс не может существовать без родительского
        public Soft()
        {
            this.am.Amount = 5;
        }

    }
    public class Number_of_operation
    {
        private int amount;
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }
    }
    public class soft_creator
    {
        private int name;
       public int Name
          {
           get { return name; }
           set { name = value; }
           }
        Soft system; //ассоциация черз композицию: класс не может существовать без родительского
        public soft_creator()
        {
            this.system.Type = "system";
        }
    }

    public class Text_processor : Soft
    {
        public string PO_name= "Text processor";
    }

    public class WORD : Soft
    {
        public string PO_name = "WORD";
    }
    public class Saper
    {
        private string game_name;
        public string Game_name
        {
            get { return game_name; }
            set { game_name = value; }
        }
    }
    public class Game : Soft
    {
        Saper game; //ассоциация черз композицию: класс не может существовать без родительского
        public Game()
        {
            this.game.Game_name = "Saper";
        }
    }
    public class CConficker
    {
        private string virus_name;
        public string Virus_name
        {
            get { return virus_name; }
            set { virus_name = value; }
        }
    }

    public class Virus : Soft
    {
        CConficker virus; //ассоциация черз композицию: класс не может существовать без родительского
        public Virus()
        {
            this.virus.Virus_name = "CConficker";
        }
    }
    */




}
