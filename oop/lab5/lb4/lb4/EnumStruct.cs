using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb4
{
    public enum Operation
    {
        toSting,
        HashCode,
        equals
    }
    public abstract partial class Soft
    {
       

        public sealed partial class Saper : Game
        {

          
            private string kind;
            public string Kind
            {
                get { return kind; }
                set { kind = value; }
            }
            


            public override string ToString()
                {
                    string rez = "Переопределение toSting: " + this.Type + " " + this.PO_name + " " + this.Kind;
                    return rez;
                }
                public override int GetHashCode()
                {
                    return kind.Length / PO_name.Length;
                }
                public override bool Equals(object obj)
                {
                    if (obj == null)
                        return false;
                    Saper m = obj as Saper; // возвращает null если объект нельзя привести к типу Money
                    if (m as Saper == null)
                        return false;

                    return m.Type.Length == this.Type.Length && m.PO_name.Length == this.PO_name.Length && m.Kind == this.Kind;
                }

        }
    }
}
