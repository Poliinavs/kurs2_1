using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb17
{
    //Memento для сохранения состояния

// Originator
class Homework
{
    private int amount = 6; // кол-во патронов
    private int Hour = 4; // кол-во жизней

    public void Lesson()
    {
        if (amount > 0)
        {
            amount--;
            Hour--;
                Console.WriteLine("Делаем урок. Еще надо сделать {0} уроков за врямя {1}", amount, Hour);
            }
        else
            Console.WriteLine("Патронов больше нет");
    }
    // сохранение состояния
    public HomeworkMemento SaveState()
    {
        Console.WriteLine("Урок сделан отправляем на проверку. Параметры: {0} надо сделать, {1} осталось часов", amount, Hour);
        return new HomeworkMemento(amount, Hour);
    }

    // восстановление состояния
    public void RestoreState(HomeworkMemento memento)
    {
        this.amount = memento.amount;
        this.Hour = memento.Hour;
        Console.WriteLine("Урок не приняли, надо переделать. Параметры: {0}  надо сделать, {1} осталось часов", amount, Hour);
    }
}
// Memento
class HomeworkMemento
{
    public int amount { get; private set; }
    public int Hour { get; private set; }

    public HomeworkMemento(int amount, int Hour)
    {
        this.amount = amount;
        this.Hour = Hour;
    }
}

// Caretaker
class LessonHistory
    {
    public Stack<HomeworkMemento> History { get; private set; }
    public LessonHistory()
    {
        History = new Stack<HomeworkMemento>();
    }
}
}
