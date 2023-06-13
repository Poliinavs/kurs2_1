using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb9
{
    public class Car
    {
        public string country;
        public string Mark;

        public Car(string country, string Mark)
        {
            this.country = country;
            this.Mark = Mark;
        }
        public override string ToString()
        {
            return this.Mark+ " Country -> "+ country;
        }
    }
}
