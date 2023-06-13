using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace lb17
{

    class Teacher 
    {
        //Builder процесс создания объекта не зависит от того из чего он состоит
        public Subject subj(SubjectBuilder SubjectBuilder) //создаем класс уичтель в котором добавляем предметы и возвращаем заполенную инфу о курсе
        {
            SubjectBuilder.CreateSubject();
            SubjectBuilder.SetMark();
            SubjectBuilder.SetCharacterist();
            return SubjectBuilder.Subject;
        }
       
    }
    class Subject : CourseFactory //может быть Mark b  Characterist а может и не быть 
    {
        public Mark mark { get; set; }
        public Characterist characterist { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (mark != null)
                sb.Append(mark.control + " " + mark.test + "\n");
            if (characterist != null)
                sb.Append("Характеристика: " + characterist.Behavior + " \n");
            
            return sb.ToString();
        }
        public override Check CheckCourse()
        {
            Console.Write("Оценки: " + mark.test + " " + mark.control + " Поведение: " + characterist.Behavior);
            return new CkeckInf();
        }
    }

    abstract class SubjectBuilder: MethodsTeacher //все функционал+ создаем предмет
    {
        public Subject Subject { get; private set; }
        public void CreateSubject()
        {
            Subject = new Subject();
        }
    }
    class Mark
    {
        public int control { get; set; }
        public int test { get; set; }
    }

    class Characterist
    {
        public string Behavior { get; set; }
    }

    
    class Biology: SubjectBuilder, InewCourse
    {
        public override void SetMark()
        {
           this.Subject.mark = new Mark { control = 9, test = 5 };
        }

        public override void SetCharacterist()
        {
            this.Subject.characterist = new Characterist  { Behavior = "Хорошо" };
        }
        public override void GetEveragy()
        {
            int everagy = (this.Subject.mark.control + this.Subject.mark.test) / 2;
            Console.WriteLine("Средний балл по биологии: " + everagy);
        }
        public void enroll_Course()
        {
            Console.WriteLine("Вы записаны на биологию");
        }
    }
    class Math : SubjectBuilder, IMath
    {
        public override void SetMark()
        {
            this.Subject.mark = new Mark { control = 8, test = 10 };
        }

        public override void SetCharacterist()
        {
            this.Subject.characterist = new Characterist { Behavior = "Удовлетворительно" };
        }
        public override void GetEveragy()
        {
            int everagy = (this.Subject.mark.control + this.Subject.mark.test) / 2;
            Console.WriteLine("Средний балл по математике: " + everagy);
        }
        public void Move()
        {
            Console.WriteLine("Вы записаны на математику");
        }
    }
    [Serializable]
    class FioTeacher
    {
        public string Name { get; set; }
        public string Patronymic { get; set; }
    }
    [Serializable]
    class InfTeacher 
    {
      
        public FioTeacher FioTeacher { get; set; }
        public InfTeacher( string x, string y)
        {

            this.FioTeacher = new FioTeacher { Name = x, Patronymic = y };
        }

        public object DeepCopy()
        {
            object figure = null;
            using (MemoryStream tempStream = new MemoryStream())
            {
                BinaryFormatter binFormatter = new BinaryFormatter(null,
                    new StreamingContext(StreamingContextStates.Clone));

                binFormatter.Serialize(tempStream, this);
                tempStream.Seek(0, SeekOrigin.Begin);

                figure = binFormatter.Deserialize(tempStream);
            }
            return figure;
        }
        public void GetInfo()
        {
            Console.WriteLine("Имя и отчество перподавателя:"+ FioTeacher.Name+" "+FioTeacher.Patronymic);
        }
    }
}
