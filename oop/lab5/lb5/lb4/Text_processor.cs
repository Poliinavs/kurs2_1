using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb4
{
    public sealed class Text_processor : WORD
    {
        private string kind;
        public string Kind
        {
            get { return kind; }
            set { kind = value; }
        }
        public Text_processor(string _type, string _po_name, string _kind)
        {
            kind = _kind;
            Type = _type;
            PO_name = _po_name;

        }
        public Text_processor()
        { }
        public override void Print()
        {
            Console.WriteLine($"Тип: {Type},Название: {PO_name},Вид: {Kind}");
        }
        public override string ToString()
        {
            string rez = "Информация: " + this.Type + " " + this.PO_name + " " + this.Kind;
            return rez;
        }

    }
}
