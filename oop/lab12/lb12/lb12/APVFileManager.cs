using System;
using System.IO;
using System.IO.Compression;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*a.Прочитать список файлов и папок заданного диска. Создать 
директорий XXXInspect, создать текстовый файл 
xxxdirinfo.txt и сохранить туда информацию. Создать 
копию файла и переименовать его. Удалить 
первоначальный файл
b. Создать еще один директорий XXXFiles. Скопировать в 
него все файлы с заданным расширением из заданного 
пользователем директория. Переместить XXXFiles в 
XXXInspect.*/
namespace lb12
{
    public class APVFileManager
    {

    
        public static void MoveFiles(string? path)
        {
            if (path is null)
            {
                throw new ArgumentNullException(nameof(path));
            }
            if (!Directory.Exists(path))
                return;
            string[] dirs = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);

            path += @"\\APVInspect/";
            string generalPath = path;
            Directory.CreateDirectory(path);
            path += @"dirinfo.txt";

             using (StreamWriter sw = new StreamWriter(path, false, Encoding.Default))
               {
                   sw.WriteLine("Directories: ");
                   foreach (var s in dirs)
                       sw.WriteLine(s);
                   sw.WriteLine("Files: ");
                   foreach (var s in files)
                       sw.WriteLine(s);
               }
            generalPath += @"\\newName.txt";

            if (File.Exists(generalPath))
                File.Delete(generalPath);

            File.Copy(path, generalPath);
            File.Delete(path);

        }
        public static void MoveDirectoriesByExtension(string? path, string extension)
        {
            if (path is null)
            {
                throw new ArgumentNullException(nameof(path));
            }
            if (!Directory.Exists(path))
                return;

            string generalPath = path; 
            path += @"\\APVFiles/";
            Directory.CreateDirectory(path);

            DirectoryInfo directory = new DirectoryInfo(generalPath);
            FileInfo[] files = directory.GetFiles().Where(s => s.Extension == extension).ToArray();
            foreach (var f in files)
            {
                if (File.Exists(path))
                    File.Delete(path);
                File.Move(f.FullName, path + f.Name);
            }
            generalPath += @"\\APVInspect\Files";
            if (Directory.Exists(generalPath))
                Directory.Delete(generalPath, true);
            Directory.Move(path, generalPath);
        }

        public static void ToZip(string? path)
        {
            if (path is null)
            {
                throw new ArgumentNullException(nameof(path));
            }
            string generalPath = path + @"\\APVInspect\Files";
            path += @"\\APVInspect\Files";
            DirectoryInfo directory = new DirectoryInfo(generalPath);
            var files = directory.GetFiles();
            path += @"Files.zip";
            using (System.IO.FileStream zipToOpen = new System.IO.FileStream(path, System.IO.FileMode.OpenOrCreate))
            {
                using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                {
                    foreach (var f in files)
                        archive.CreateEntryFromFile(f.FullName, f.Name);
                }
            }
        }
        public static void FromZip(string? path)
        {
            if (path is null)
            {
                throw new ArgumentNullException(nameof(path));
            }
            string generalPath = path + @"\\APVInspect\Fromzip";
            path += @"\\APVInspect\Files";
            path += @"Files.zip";
            if (Directory.Exists(generalPath))
                Directory.Delete(generalPath, true);
            ZipFile.ExtractToDirectory(path, generalPath);

        }




    }
}
