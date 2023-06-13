using System;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.IO;
using System.Linq;
using System.Collections;
namespace lb11
{
    class Class1
    {
        static void Main(string[] args)
        {
        Reflector reflector = new Reflector();
            reflector.Name_sbork("testClass");
            reflector.Publ_constr("testClass");
            reflector.Publ_class("testClass");
            reflector.class_Interf("testClass");
            reflector.class_Method("testClass", "String");
            reflector.Invoke("lb11.testClass", "Show");
            object[] ls = new object[] { "Inform" };
            object ts1 = Reflector.Create("lb11.testClass", ls);

            reflector.Name_sbork("Person");
            reflector.Publ_constr("Person");
            reflector.Publ_class("Person");
            reflector.class_Interf("Person");
            reflector.class_Method("Person", "String");
            reflector.Invoke("lb11.Person", "FIOS");
            object[] ls1 = new object[] { "Katya" };
            object ts2 = Reflector.Create("lb11.Person", ls1);


            Reflector.file.Close();

        }
    }
}