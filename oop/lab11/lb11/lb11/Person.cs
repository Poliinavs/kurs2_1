using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb11
{
    internal class Person
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Person() { }

        public Person(string name)
        {
            this.name = name;
        }
        private Person(string name, int n, double b)
        {
            this.name = name;
        }
        public void FIOS(List<string> nameorm)
        {
            foreach (string str in nameorm)
            {
                Console.WriteLine(str);
            }
        }
        private void Show2()
        {
            Console.WriteLine(name);
        }

        public override string ToString()
        {
            return "your name: " + name;
        }

    }
}
