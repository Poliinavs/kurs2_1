using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb10
{
    public class detals
    {
        public string kind { get; set; }
        public string Mark { get; set; }
        public detals(string kind, string name)
        {
            this.kind = kind;
            Mark = name;
        }
    }
}
