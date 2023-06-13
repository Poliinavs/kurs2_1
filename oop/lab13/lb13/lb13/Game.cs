using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Xml;


namespace lb13
{
    [Serializable]
    public class Game : Soft
    {

        public string po_name;
        public string PO_name
        {
            get { return po_name; }
            set { po_name = value; }
        }
        
        [NonSerialized]
        public string game_name;

        public string Game_name
        {
            get { return game_name; }
            set { game_name = value; }
        }

        public Game(string _type, string _po_name, string Gme_name)
        {
            po_name = _po_name;
            Type = _type;
            Game_name=Gme_name;
        }
        public Game()
        { }
        public override string ToString()
        {
            string rez = "SOFT: " + this.Type+"   Name: " +this.po_name + "   Game: "+ this.Game_name;
            return rez;
        }
    }

}
