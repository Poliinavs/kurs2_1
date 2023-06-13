using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{

        public class Developer
        {
            public int id;
            public string fio;

            public Developer(int id, string fio)
            {
                this.id = id;
                this.fio = fio;
            }
        public override string ToString()
        {
            return $"Владелец - ID: {id}, ФИО: {fio}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Developer m = obj as Developer; // возвращает null если объект нельзя привести к типу Money
            if (m as Developer == null)
                return false;

            return m.id == this.id && m.fio == this.fio;
        }

    }

    //static public class StatisticOperation
    //{
    //    static public int differen(ARR sett) //разница между макс и мин
    //    {
    //        return sett.Arr.Max() - sett.Arr.Min();
    //    }
    //    static public int sum(ARR sett) //разница между макс и мин
    //    {
    //        return sett.Arr.Sum();
    //    }
    //    static public int amount(ARR sett) //разница между макс и мин
    //    {
    //        return sett.Arr.Length;
    //    }
    //    public static int CountOfWords(this string str) //количество элементов
    //    {
    //        int count = 0;
    //        string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    //        count += words.Length;
    //        return count;
    //    }
    //}
}
