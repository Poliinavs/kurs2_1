using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb12
{
  /*  . Количестве файлов
b.Время создания
c.Количестве поддиректориев
d.Список родительских директориев
e.Продемонстрируйте работу класса*/
    public class APVDirInfo
    {
        private const string path = @"C:\instit\kurs2\oop\lab12\lb12";

        public static string GetDirInfo()
        {
            if (path is null)
            {
                throw new ArgumentNullException(nameof(path));
            }
            var dirInf = new DirectoryInfo(path);
            string str = "";
            
            str += "Путь:" + dirInf.FullName + '\n';
            str += "Количество файлов " + dirInf.GetFiles().Length + '\n';
            str += "Количестве поддиректориев " + dirInf.GetDirectories().Length + '\n';                     //папки
            str += "Список родительских директориев " + dirInf.Parent + '\n';
            str += "Дата создания " + dirInf.CreationTime + '\n';
            return str;
        }

    }
}
