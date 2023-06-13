using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lb12
{
    // методами записи в текстовый файл, чтения, поиска нужной   информации
    public class APVLog
    {
        private const string path = @"C:\instit\kurs2\oop\lab12\lb12\APVLog.txt";
        public static StreamWriter fw;

        static APVLog() => fw = new StreamWriter(path, false, Encoding.Default);  //true инф добавл в конце 

        public static void Write(string str) => fw.WriteLine(str);

        public static int GetRecordCount()//Посчитайте количество записей
        {
            fw.Close();
            int res = 0;
            using (StreamReader sr = new StreamReader(path, Encoding.Default))
            {
                res = sr.ReadToEnd().Split('\n').Where(s => s.StartsWith("Get") == true).Count();

            }
            fw = new StreamWriter(path, true, Encoding.Default);

            return res;
        }


  

        /*      действиях пользователя за определенный день/ диапазон времени/по
      ключевому слову*/
        public static void GetInfoByDay(string date, int from, int to, string key)
        {
            fw.Close();

           // string date1 = date.ToShortDateString();
            string res = "";

            using (StreamReader sr = new StreamReader(path, Encoding.Default))
            {
                
                string[] infos = sr.ReadToEnd().Split('\n');
                string str = "";
                Console.WriteLine("Действия пользователя за определенный день: ");
                foreach (var s in infos)
                {
                    str += s;
                    str += '\n';
                    if (s.Contains(date))
                    {
                        Console.WriteLine(str);
                        str = "";
                    }
                  
                }
                str = "";
                int k = 0;
                foreach (var s in infos)
                {     
                    if (s.Contains(key))
                    {
                        Console.WriteLine("\nИнформация по ключевому слову:");
                        while (infos[k] != "\r")
                        {
                            Console.WriteLine(infos[k]);
                            k ++;
                        }
                    }
                    k++;
                }
                Console.WriteLine("\nДействия пользователя за промежуток времени: ");
                for(int i = from; i <=to; i++)
                {
                    string time = i.ToString();
                    time += ".";
                    k = 0;
                    foreach (var s in infos)
                    {
                        if (s.Contains(time))
                        {
                            int buf = k;
                            while (infos[k] != "\r" && k != 0)
                            {
                                Console.WriteLine(infos[k]);
                                k--;
                            }
                            k = buf;
                        }
                        k++;
                    }
                    time = "";
                }


            }
            fw = new StreamWriter(path, true, Encoding.Default);
        }

        public static void Del(string time)
        {
            string hours = time.Substring(0, 2);
            fw.Close();
            int k = 0;
            string str = "";
            using (StreamReader sr = new StreamReader(path, Encoding.Default))
            {
                string[] infos = sr.ReadToEnd().Split('\n');

               
                foreach (var s in infos)
                {
                    if (s.Contains(hours))
                    {
                        int buf = k;
                        while (infos[k] != "\r" && k != 0)
                        {
                            str += infos[k];
                            str += "\n";
                            k--;

                        }
                        k = buf;
                    }
                    k++;
                }
                Console.WriteLine("=======================================================================");
        }
            
            fw = new StreamWriter(path, false, Encoding.Default);
            fw.WriteLine(str);
           // fw.Close();

        }



    }




}
