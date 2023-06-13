using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb4
{
    public sealed class soft_creator : Soft, IClonable
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public soft_creator(string _type, string _name)
        {
            name = _name;
            Type = _type;
        }
        public soft_creator()
        { }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($" Создатель: {Name}");
        }
        public override string ToString()
        {
            string rez = "Информация: " + this.Type + " " + this.name;
            return rez;
        }
        public override bool DoClone()
        {
            return false;
        }
        bool IClonable.DoClone()
        {
            return false;
        }
    }
}
