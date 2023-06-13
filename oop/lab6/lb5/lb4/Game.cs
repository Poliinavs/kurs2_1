using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb4
{
    public class Game : Soft
    {
        private string po_name;
        public string PO_name
        {
            get { return po_name; }
            set {
                if (value.Length > 20)
                    throw new LenghtException("Привышена длина названия ПО ", value);
                else
                    po_name = value;
            }
        }
        public int Devise_member;
        private int po_member;
        public int PO_member
        {
            get { return po_member; }
            set {
                if (value > Devise_member)
                    throw new MemberException("нехватка памяти ", value- Devise_member);
                else
                    po_member = value;
            }
        }
        public Game(string _type, string _po_name, int _po_member, int devise_member)
        {
            PO_name = _po_name;
            Type = _type;
            Devise_member = devise_member;
            PO_member = _po_member;
           
        }
        public Game()
        { }
        public override string ToString()
        {
            string rez = "Информация: " + this.Type + " " + this.PO_name +" " + this.PO_member;
            return rez;
        }
        public override bool DoClone()
        {
            return false;
        }
    }
}
