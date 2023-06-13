using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb10
{
    public class Car
    {
        public int year { get; set; }
        public string Name { get; set; }
       public Car(int year, string name)
        {
            this.year = year;
            Name = name;
        }
    }
}
