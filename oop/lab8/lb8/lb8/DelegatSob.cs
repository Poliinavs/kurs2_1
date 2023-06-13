using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb8
{
   public class User
    {
        public int position;
        public int salary;

        public delegate void Move(User obj, int position);
        public delegate void Compress(User obj, int salary, string profes);

        public event Move move;
        public event Compress compress;

        public User(int position, int salary)
        {
            this.position = position;
            this.salary = salary;
        }

        public void add(int position, int salary, string profes)
        {
            Console.WriteLine();
            Console.WriteLine("Объект до изменения: ");
            Console.WriteLine(ToString());
            Console.Write("Объект после изменения: ");

            if (position != null)
            {
                move(this, position);
            }
            else
            {
                Console.Write("Позиция не изменена. ");
            }

            if (salary != null)
            {
                compress(this, salary, profes);
            }
            else
            {
                Console.Write("Зарплата не изменена. ");
            }

         
            Console.WriteLine(ToString());
            Console.WriteLine();
        }

        public override string ToString()
        {
            return "Person: " + this.position + " Зарплата: " + this.salary;
        }



    }
}
