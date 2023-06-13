using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Xml;

namespace lb13
{
    [Serializable]
    public  class Soft
    {

        private string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public override string ToString()
        {
            string rez = "SOFT: " + this.Type;
            return rez;
        }
    }
}
