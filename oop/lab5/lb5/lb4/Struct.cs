using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb4
{
    enum Game_name 
    {
        Pacman = 1999, GTA, Counter_strike
    }
    struct Video_game
    {
        public string name;
        public int year;
        static public string Kind_of_sof="Aplication";

        public void Print()
        {
            Console.WriteLine($"Название: {name},  Вид: {Kind_of_sof}, Год выпуска: {year}");
        }
    }
}
