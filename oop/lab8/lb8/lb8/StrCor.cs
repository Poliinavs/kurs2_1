using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb8
{
    public class StrCor
    {
        public Action<string> CorrectStr;

        delegate bool Predicate<in T> (T obj);

        public bool FindSymb(string str)
        {
            char t = '!';
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] == t)
                    return true;
            }
            return false;
        }

        public void  Del_punc(string str)
        {
            str = str.Replace("!", "");
            str = str.Replace(".", "");
            str = str.Replace(",", "");
            str = str.Replace(":", "");
            str = str.Replace(";", "");
            str = str.Replace("?", "");
            Console.WriteLine("строка без знаком препинания: " + str);
        }
        public void UpperCase(string str)
        {
            str = str.ToUpper();
            Console.WriteLine("Строка в верхнем регистре: " + str);
        }

        public void DelSpace(string str)
        {
            str = str.Replace(" ", "");
            Console.WriteLine("Строка без пробелов: " + str);
        }


    }

  
}
