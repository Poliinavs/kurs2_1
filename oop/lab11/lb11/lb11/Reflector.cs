using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Globalization;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace lb11
{
    public class Reflector
    {
     
        static string filePath = "C:\\instit\\kurs2\\oop\\lab11\\lb11\\inform.txt";
        static string filePathR = "C:\\instit\\kurs2\\oop\\lab11\\lb11\\fileRead.txt";
        public static StreamWriter file = new StreamWriter(filePath, false); //фйл надо перехаписыв =>false
        static StreamReader fileRead = new StreamReader(filePathR);
        public void Name_sbork(string name)
        {
            file.WriteLine("-------------------------------------------1");
            string TypeName = "lb11." + name;                                                            //чтобы указать в каком простр имен наход
            Type? myType = Type.GetType(TypeName, false, true);                                         //1.полн имя класса с простр имен 2.нужно ли генир ошибки если не нашли класс, 3 учит ли регистр ( true означает, что регистр игнорируется.)
            file.WriteLine($"Имя сбоки, в котор определен класс= {myType.Assembly}");
          

        }
        public void Publ_constr(string name) //есть ли публичные конструкторы;
        {
            file.WriteLine("-------------------------------------------2");
            string TypeName = "lb11." + name;
            Type myType = Type.GetType(TypeName, false, true);
            file.WriteLine("Публичные конструкторы: ");
           foreach (ConstructorInfo constr in myType.GetConstructors())
            {
                if (constr.IsPublic)
                {
                    file.WriteLine(constr);
                }
            }
       
        }
        public void Publ_class(string name)
        {
            file.WriteLine("-------------------------------------------3");
            string TypeName = "lb11." + name;
            Type myType = Type.GetType(TypeName, false, true);
            file.WriteLine("Публичные методы: ");
            foreach (MethodInfo constr in myType.GetMethods())
            {
                if (constr.IsPublic)
                {
                    file.WriteLine(constr);
                }
            }
        }
        public void class_Interf(string name) 
        {
            file.WriteLine("-------------------------------------------4");
            string TypeName = "lb11." + name;
            Type myType = Type.GetType(TypeName, false, true);
            file.WriteLine("Интерфейсы: ");
            foreach (Type constr in myType.GetInterfaces())
            {
                    file.WriteLine(constr);
            }
          
        }
        /*      выводит по имени класса имена методов, которые содержат
      заданный(пользователем) тип параметра(имя класса передается
      в качестве аргумента)*/
        public void class_Method(string name, string parm)
        {
            file.WriteLine("-------------------------------------------6");

            string TypeName = "lb11." + name;
            Type myType = Type.GetType(TypeName, false, true);

            foreach (MethodInfo mi in myType.GetMethods())                                                 //по всем методам
            {
                ParameterInfo[] param = mi.GetParameters();                                             //по всем типам(string)
                for (int j = 0; j < param.Length/3; j++) 
                {
                    if (parm == param[j].ParameterType.Name)
                    {
                        file.WriteLine(mi);
                    }
                }
            }
            
        }
   /*     g.метод Invoke, который вызывает метод класса, при этом значения
для его параметров необходимо 1) прочитать из текстового файла
(имя класса и имя метода передаются в качестве аргументов) 2) 
сгенерировать, используя г  для каждого типа.
Параметрами метода Invoke должны быть : объект, имя метода,
массив параметров*/
   public void Invoke(string name_class, string name_meth)
        {
            file.WriteLine("-------------------------------------------7");
            List<string> args = new List<string>();
            args.Add(fileRead.ReadLine());
            args.Add(fileRead.ReadLine());
            args.Add(fileRead.ReadLine());
            object[] parms = new object[] { args };

            Type myType = Type.GetType(name_class, false, true);
 
            var SHOW = myType.GetMethod(name_meth);                                                                            // получаем метод Show
            object obj = Activator.CreateInstance(myType);                                                                      //Объект, для которого нужно вызвать метод или конструктор

            SHOW?.Invoke(obj, parms); // вызываем метод Show, передавая ему два аргумента
           
        }
      /*  Добавьте в Reflector обобщенный метод Create, который создает объект
переданного типа(на основе имеющихся публичных конструкторов) и возвращает
его пользователю*/
      public static object Create(string TypeName, object[] parm)
        {
       
            Type myType = Type.GetType(TypeName, false, true);
            object obj = Activator.CreateInstance(myType, parm);
            Console.WriteLine(obj.ToString());
            return obj;

        }



    }
}
