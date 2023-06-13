using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb14
{
    static public class GetProcess
    {
        public static void GetAllProcess()
        {
            var process = Process.GetCurrentProcess();
            Console.WriteLine($"Текущий процесс:\nID: {process.Id} Имя: {process.ProcessName}  Используемая виртуальная память: {process.VirtualMemorySize64}");
            Console.WriteLine($"---------------------------");

            foreach (var proc in Process.GetProcesses()) //возвращает массив всех запущенных процессов
            {
                Console.WriteLine("Имя потока: " + proc.ProcessName);
                Console.WriteLine("Id потока: " + proc.Id);
                Console.WriteLine("Приоритет потока: " + proc.BasePriority);
                //////////////////////////  текущее состояние, сколько всего времени использовал процессор
                try
                {
                    Console.WriteLine("Start time: " + proc.StartTime);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine();
            }
        }
    }
}
