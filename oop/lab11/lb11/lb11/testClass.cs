using System;
using System.Collections.Generic;
using System.Reflection;
using System.IO;
using System.Linq;
using System.Collections;

namespace lb11
{
    public class testClass : Interface1
    {
        private string inf;
        public string Inf
        {
            get { return inf; }
            set { inf = value; }
        }
        public testClass() { }

        public testClass(string name)
        {
            this.inf = name;
        }
        private testClass(string name, int n)
        {
            this.inf = name;
        }
            public void Show(List<string> inform)
        {
            foreach (string str in inform)
            {
                Console.WriteLine(str);
            }
        }
        private void Show2()
        {
            Console.WriteLine(inf);
        }

        public override string ToString()
        {
            return "you inform " + inf+ "\n";
        }


    }
}
