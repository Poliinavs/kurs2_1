using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb17
{
  

abstract class Timetable
{
    public Timetable(string n)
    {
        this.Name = n;
    }
    public string Name { get; protected set; }
    public abstract int getAmountLessons();
       
}

class Monday : Timetable //конкретная реализация и в нее с помощиью декоратора добавляем доп функционал
{
    public Monday() : base("Понедельник")
    { }
    public override int getAmountLessons()
    {
        return 3;
    }
        //Command
        public void INF()
        {
            Console.WriteLine("Понедельник:4 урока");
        }

        public void Facult()
        {
            Console.WriteLine("После уровков нет факультативов");
        }
    }
class Tusday : Timetable
{
    public Tusday()
        : base("Вторник")
    { }
    public override int getAmountLessons()
    {
        return 6;
    }
}

abstract class TimetableDecorator : Timetable
{
    protected Timetable Timetable;
    public TimetableDecorator(string n, Timetable Timetable) : base(n)
    {
        this.Timetable = Timetable;
    }
}

class FirstMonday : TimetableDecorator
{
    public FirstMonday(Timetable p)
        : base(p.Name + " Биология  Математика  Физика ", p)
    { }

    public override int getAmountLessons()
    {
        return Timetable.getAmountLessons();
    }
}

class SecondMonday : TimetableDecorator
{
    public SecondMonday(Timetable p)
        : base(p.Name + " Немецкий  Химия Физика ", p)
    { }

    public override int getAmountLessons()
    {
        return Timetable.getAmountLessons();
    }
}
    //Command
 
    class MondayCommand : ICommand
    {
        Monday tv;
        public MondayCommand(Monday mnSet)
        {
            tv = mnSet;
        }
        public void Execute()
        {
            tv.INF();
        }
        public void Undo()
        {
            tv.Facult();
        }
    }

    // Invoker - инициатор
    class InfTime
    {
        ICommand command;

        public InfTime() { }

        public void SetCommand(ICommand com)
        {
            command = com;
        }

        public void FacultInf()
        {
            command.Execute();
        }
        public void TimeInf()
        {
            command.Undo();
        }
    }

}
