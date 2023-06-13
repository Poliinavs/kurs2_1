using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb17
{
    class Student : CourseFactory
    {
        public Information Information { get; set; }
        public void Info(int id,string Fio)
        {
            Information = Information.getInfo(id,Fio);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (Information != null)
                sb.Append(Information.id + " " + Information.FIO + "\n");
            return sb.ToString();
        }
        public void CreateStudent()
        {
            Student student = new Student();
        }
        public override Check CheckCourse()
        {
            Console.Write("Полная инфомация: " + Information.id + " " + Information.FIO +'\t');
            return new CkeckInf();
        }
        // // ADAPTER
        public void get_course(InewCourse newCourse)
        {
            newCourse.enroll_Course();
        }
    }
    //singleton
    class Information
    {
        private static Information instance;

        public string FIO { get; private set; }
        public int id { get; private set; }

        protected Information(int id,string name)
        {
            this.FIO = name;
            this.id = id;
        }

        public static Information getInfo(int id, string name)
        {
            if (instance == null)
                instance = new Information(id,name);
            
            return instance;
        }
    }
 

    // Адаптер от Camel к InewCourse
    class MathTonewCourseAdapter : InewCourse
    {
        Math math;
        public MathTonewCourseAdapter(Math c)
        {
            math = c;
        }

        public void enroll_Course()
        {
            math.Move();
        }
    }




}
