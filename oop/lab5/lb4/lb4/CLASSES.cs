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
    
    public abstract partial class Soft
    {
       public abstract bool DoClone();
        private string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        /*internal static void DoOperation(lb4.Saper saper, Operation op)
        {
            if(op== Operation.toSting)
            {
                Console.WriteLine(saper.ToString);
            }
         
            // Operation.HashCode => saper.GetHashCode,
            // Operation.equals => saper.GetType,


            //Console.WriteLine(result);
        }*/

        public Soft()
        { }
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

    public sealed class soft_creator : Soft, IClonable
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public soft_creator(string _type, string _name)
        {
            name = _name;
            Type = _type;
        }
        public soft_creator()
        { }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($" Создатель: {Name}");
        }
        public override string ToString()
        {
            string rez = "Переопределение toSting: "+ this.Type + " " + this.name;
            return rez;
        }
        public override bool DoClone()
        {
            return false;
        }
        bool IClonable.DoClone()
        {
            return false;
        }
    }
   public sealed class Number_of_operation : Soft
    {
        private int amount;
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public Number_of_operation(string _type, int _amount)
        {
            amount = _amount;
            Type = _type;
        }
        public Number_of_operation()
        { }
        public override string ToString()
        {
            string rez = "Переопределение toSting: " + this.Type + " " + this.amount;
            return rez;
        }
        public override bool DoClone()
        {
            return false;
        }

    }
    public class WORD : Soft
    {
        private string po_name;
        public string PO_name
        {
            get { return po_name; }
            set { po_name = value; }
        }
        public WORD(string _type, string _po_name)
        {
            po_name = _po_name;
            Type = _type;
        }
        public WORD()
        { }
        public override string ToString()
        {
            string rez = "Переопределение toSting: " + this.Type + " " + this.PO_name;
            return rez;
        }
        public override bool DoClone()
        {
            return false;
        }

    }
    public sealed class Text_processor : WORD
    {
        private string kind;
        public string Kind
        {
            get { return kind; }
            set { kind = value; }
        }
        public Text_processor(string _type, string _po_name, string _kind)
        {
            kind = _kind;
            Type = _type;
            PO_name = _po_name;

        }
        public Text_processor()
        { }
        public override void Print()
        {
            Console.WriteLine($"Тип: {Type},Название: {PO_name},Вид: {Kind}");
        }
        public override string ToString()
        {
            string rez = "Переопределение toSting: " +this.Type + " " + this.PO_name+ " "+ this.Kind;
            return rez; 
        }

    }
    public partial class Game : Soft
    {
        private string po_name;
        public string PO_name
        {
            get { return po_name; }
            set { po_name = value; }
        }
        public Game(string _type, string _po_name)
        {
            po_name = _po_name;
            Type = _type;
        }
        public Game()
        { }
        public override string ToString()
        {
            string rez = "Переопределение toSting: " + this.Type + " " + this.PO_name;
            return rez;
        }
        public override bool DoClone()
        {
            return false;
        }
    }


    public sealed partial class Saper: Game
    {
        private string kind;
        public string Kind
        {
            get { return kind; }
            set { kind = value; }
        }
        public Saper(string _type, string _po_name, string _kind)
        {
            this.kind = _kind;
            Type = _type;
            PO_name = _po_name;
        }
        public Saper()
        { }
        

    }

    public class Virus : Soft
    {
        private string po_name;
        public string PO_name
        {
            get { return po_name; }
            set { po_name = value; }
        }
        public Virus(string _type, string _po_name)
        {
            po_name = _po_name;
            Type = _type;
        }
        public Virus()
        { }
        public override string ToString()
        {
            string rez = "Переопределение toSting: " + this.Type + " " + this.PO_name;
            return rez;
        }
        public override bool DoClone()
        {
            return false;
        }
    }

    public sealed class CConficker : Virus
    {
        private string kind;
        public string Kind
        {
            get { return kind; }
            set { kind = value; }
        }
        public CConficker(string _type, string _po_name, string _kind)
        {
            kind = _kind;
            Type = _type;
            PO_name = _po_name;
        }
        public CConficker()
        { }
        public override string ToString()
        {
            string rez = "Переопределение toSting: " + this.Type + " " + this.PO_name + " " + this.Kind;
            return rez;
        }
    }

    public class Printer
    {
        public string IAmPrinting(Text_processor someobj)
        {
            return someobj.ToString();
        }
        public string IAmPrinting(WORD someobj)
        {
            return someobj.ToString();
        }
        public string IAmPrinting(Number_of_operation someobj)
        {
            return someobj.ToString();
        }
        public string IAmPrinting(CConficker someobj)
        {
            return someobj.ToString();
        }
        public string IAmPrinting(soft_creator someobj)
        {
            return someobj.ToString();
        }
        public string IAmPrinting(Soft someobj)
        {
            return someobj.ToString();
        }
        public string IAmPrinting(Virus someobj)
        {
            return someobj.ToString();
        }
        public string IAmPrinting(Saper someobj)
        {
            return someobj.ToString();
        }
        public string IAmPrinting(Game someobj)
        {
            return someobj.ToString();
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
