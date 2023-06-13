using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb4
{
    public class Virus : Soft
    {
        private string po_name;
        public string PO_name
        {
            get { return po_name; }
            set { po_name = value; }
        }
        public Virus(string _type, string _po_name)
        {
            po_name = _po_name;
            Type = _type;
        }
        public Virus()
        { }
        public override string ToString()
        {
            string rez = "Информация: " + this.Type + " " + this.PO_name;
            return rez;
        }
        public override bool DoClone()
        {
            return false;
        }
    }
}
