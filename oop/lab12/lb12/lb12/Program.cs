using System;
using System.IO;

namespace lb12
{
    class Class1
    {
        static void Main(string[] args)
        {
            string path = @"C:\instit\kurs2\oop\lab12";


            Console.WriteLine(APVDiskInfo.GetDiskInfo());
            APVLog.Write("GetDiskInfo");
            APVLog.Write(APVDiskInfo.GetDiskInfo());
            APVLog.Write("Session:"+ DateTime.Now.ToString() +'\n');

          Console.WriteLine();
            Console.WriteLine(APVFileInfo.GetFileInfo());
            APVLog.Write("GetFileInfo");
            APVLog.Write(APVFileInfo.GetFileInfo());

            Console.WriteLine(APVDirInfo.GetDirInfo());
            APVLog.Write("GetDirInfo");
            APVLog.Write(APVDirInfo.GetDirInfo());

           APVFileManager.MoveFiles(path);
           APVFileManager.MoveDirectoriesByExtension(path, ".js"); 
           APVFileManager.ToZip(path);
           APVFileManager.FromZip(path);


            Console.WriteLine("============= FROM FILE ==============");
            Console.WriteLine($"============= COUNT: {APVLog.GetRecordCount()}================");
            Console.WriteLine("======================================\n");

           
           APVLog.GetInfoByDay("30.10.2022", 10, 13, "GetFileInfo");

            
           APVLog.Del( DateTime.Now.ToShortTimeString().ToString());
            APVLog.fw.Close();

        }
    }
}