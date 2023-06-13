using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb4
{
    public sealed class Number_of_operation : Soft
    {
        private int amount;
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public Number_of_operation(string _type, int _amount)
        {
            amount = _amount;
            Type = _type;
        }
        public Number_of_operation()
        { }
        public override string ToString()
        {
            string rez = "Информация: " + this.Type + " " + this.amount;
            return rez;
        }
        public override bool DoClone()
        {
            return false;
        }

    }
}
