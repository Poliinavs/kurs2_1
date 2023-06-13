using System;
namespace lb17
{
    class Class1
    {
        static void Main(string[] args)
        {
            /*  Course elf = new Course(new ElfFactory());
              elf.Hit();
              elf.Hit();
              elf.Run();

              Course voin = new Course(new VoinFactory());
              voin.Hit();
              voin.Run();

              Console.ReadLine();*/
            // содаем объект пекаря
            Console.WriteLine("Биология");
            Teacher Teacher = new Teacher();
            // создаем билдер для ржаного хлеба
            SubjectBuilder subj = new Biology();
            // инициализир предмет
            Subject initBiol = Teacher.subj(subj);
            Console.Write(initBiol.ToString());
            subj.GetEveragy();

            // оздаем билдер для пшеничного хлеба
            Console.WriteLine();
            Console.WriteLine("Математика");
            subj = new Math();
            Subject InfSubject = Teacher.subj(subj);
            Console.Write(InfSubject.ToString());
            subj.GetEveragy();

            
            Console.WriteLine("Ученик1:"); //Singleton
            Student student = new Student();
            student.Info(1,"Иванов Иван Иванович");
            Console.Write(student.ToString());

            Course elf = new Course(student, InfSubject );
            //Course voin = new Course(student);
            ///
            Console.WriteLine();
            InfTeacher figure = new InfTeacher("Сергей", "Серегеевич");
            // применяем глубокое копирование
            InfTeacher clonedFigure = figure.DeepCopy() as InfTeacher;
            figure.FioTeacher.Name = "Федор";
            figure.GetInfo();
            clonedFigure.GetInfo();

           // Console.ReadLine();
            /////////////////////////////////
            // путешественник
           // Student driver = new Student();
            // ADAPTER
            Biology biology = new Biology();
            // записываемся на один курс
            student.get_course(biology);
            // надо записаться на другой
            Math math = new Math();
            // используем адаптер
            InewCourse newCourseMath = new MathTonewCourseAdapter(math);
            // продолжаем путь по пескам пустыни
            student.get_course(newCourseMath);

            //  Console.Read();
            Console.WriteLine();
            Timetable monday = new Monday();
            monday = new FirstMonday(monday); // Понедельник по первым неделям 
            Console.WriteLine("Название: {0}", monday.Name);
            Console.WriteLine("Количество уроков: {0}", monday.getAmountLessons());

            Timetable Timetable2 = new Monday();
            Timetable2 = new SecondMonday(Timetable2);// понедельник по вторым неделям
            Console.WriteLine("Название: {0}", Timetable2.Name);
            Console.WriteLine("Количество уроков: {0}", Timetable2.getAmountLessons());

            Console.WriteLine();
            Timetable Timetable3 = new Tusday();
            Timetable3 = new FirstMonday(Timetable3);
            Timetable3 = new SecondMonday(Timetable3);// вторник как понедельник по первмы+ понед по вторым
            Console.WriteLine("Название: {0}", Timetable3.Name);
            Console.WriteLine("Количество уроков: {0}", Timetable3.getAmountLessons());
            //Command
            Console.WriteLine();
            InfTime infTime1 = new InfTime();
            Monday monday1 = new Monday();
            infTime1.SetCommand(new MondayCommand(monday1));
            infTime1.FacultInf();
            infTime1.TimeInf();

            //Memento
            Console.WriteLine();
            Homework Homework = new Homework();
            Homework.Lesson(); // делаем урок, осталось 5 патронов
            LessonHistory homework = new LessonHistory();
            homework.History.Push(Homework.SaveState()); // сохраняем игру
            Homework.Lesson(); //делаем урок, осталось 4 патронов
            Homework.RestoreState(homework.History.Pop());
            Homework.Lesson(); //делаем урок, осталось 5 патронов
            Console.WriteLine();

            //Strategy
            Work auto = new Work( "Saturday", new NeedWork());
            auto.Need();
            auto.Movable = new DontNeed();
            auto.Need();

            Console.ReadLine();



        }
    }
}