using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public  partial class ARR
    {
        public class Production
        {
            public int id;
            public string name_org;

            public Production(int id, string name_org)
            {
                this.id = id;
                this.name_org = name_org;
            }

            public void GetInfo()
            {
                Console.WriteLine($" ID: {id}, Организауия: {name_org}");
            }
        }

        public class Developer
        {
            public int id;
            public string fio;

            public Developer(int id, string fio)
            {
                this.id = id;
                this.fio = fio;
            }

            public void GetInfo()
            {
                Console.WriteLine($"Владелец - ID: {id}, ФИО: {fio}");
            }
        }

       

    }
    static public class StatisticOperation
    {
        static public int differen(ARR sett) //разница между макс и мин
        {
            return sett.Arr.Max() - sett.Arr.Min();
        }
        static public int sum(ARR sett) //разница между макс и мин
        {
            return sett.Arr.Sum();
        }
        static public int amount(ARR sett) //разница между макс и мин
        {
            return sett.Arr.Length;
        }
        public static int CountOfWords(this string str) //количество элементов
        {
            int count = 0;
            string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            count += words.Length;
            return count;
        }
    }
}
