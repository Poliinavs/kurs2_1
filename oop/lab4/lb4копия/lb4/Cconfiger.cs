using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb4
{
    public sealed class CConficker : Virus
    {
        private string kind;
        public string Kind
        {
            get { return kind; }
            set { kind = value; }
        }
        public CConficker(string _type, string _po_name, string _kind)
        {
            kind = _kind;
            Type = _type;
            PO_name = _po_name;
        }
        public CConficker()
        { }
        public override string ToString()
        {
            string rez = "Переопределение toSting: " + this.Type + " " + this.PO_name + " " + this.Kind;
            return rez;
        }
    }
}
