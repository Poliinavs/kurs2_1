using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb17
{
    class Course
    {
        //не зависит от того что было создано все равно перераспред функционал
       // огда система не должна зависеть от способа создания и компоновки новых объектов
        //Когда создаваемые объекты должны использоваться вместе и являются взаимосвязанным 
        private Check Check;
        public string subj { get; set; }
        public Course(CourseFactory factory, CourseFactory factory1)
        {
                 Check = factory.CheckCourse();
                Check = factory1.CheckCourse();
        }

    }
    abstract class Check
    {
        public abstract void CheckCourse();
    }
    class CkeckInf : Check
    {
        public override void CheckCourse()
        {
            Mark mark = new Mark();
            Console.WriteLine("Полная инфомация: " + mark.test + " " + mark.control );
        }
  
    }
    
    abstract class CourseFactory
    {
        public abstract Check CheckCourse();
    }
  
   

}
