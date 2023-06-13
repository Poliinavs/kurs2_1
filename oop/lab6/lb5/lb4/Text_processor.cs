using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb4
{
    public sealed class Text_processor : WORD
    {
        static string [] kinds={ "Applied", "Soft", "Program"};
        private string kind;
        public string Kind
        {
            get { return kind; }
            set
            {
                for(int i = 0; i < 3; i++)
                {
                    if (String.Equals(kinds[i], value))
                    {
                        kind = value;
                    }
                }
                if(String.Equals(kind, value)==false)
                    throw new NameException();

            }
        }
        public Text_processor(string _type, string _po_name, string _kind)
        {
            Kind = _kind;
            Type = _type;
            PO_name = _po_name;

        }

        public  void Version (Text_processor Gm)
        {
            int vers = Convert.ToInt32(Gm.Type);
            if (vers != 13)
            {
                throw new ArgumentException(String.Format("Версия {0} не поддерживается", vers));
            }

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
