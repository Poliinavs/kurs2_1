using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb12
{
  /*  Полный путь
b.Размер, расширение, имя
c.Дата создания, изменения*/

    public class APVFileInfo
    {
        public static string GetFileInfo()
        {

            FileInfo fileInf = new FileInfo(@"C:\instit\kurs2\oop\lab12\lb12\APVLog.txt");
            string st = "";
            st += "Путь:"+fileInf.FullName+'\n';
            st += "Размер " + fileInf.Length + '\n';
            st += "Расширение " + fileInf.Extension + '\n';
            st += "Имя " + fileInf.Name + "\n";
            st += "Дата последнего изменения " + fileInf.LastWriteTime + "\n";
            st += "Дата создания " + fileInf.CreationTime + '\n';
            return st;

        }
    }
}
