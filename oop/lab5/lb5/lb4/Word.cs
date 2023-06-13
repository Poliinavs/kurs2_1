using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb4
{
    public class WORD : Soft
    {
       
        public WORD(string _type, string _po_name)
        {
            PO_name = _po_name;
            Type = _type;
        }
        public WORD()
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
