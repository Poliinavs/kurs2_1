using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb8
{
   public class methods
    {
        public void DOmove(User obj, int position)=> obj.position = position;
        public void DOcomp(User obj, int salary) => obj.salary = salary;
        public void DOcompress(User obj, int salary, string profes)
        {
            obj.salary = obj.salary - obj.salary * salary / 100;
            Console.WriteLine("Профессия: " + profes);
        }


    }
}
