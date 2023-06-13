using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb4
{
    class Container
    {
           public List<object> mainList = new List<object>();

        public List<object> list
        {
            get { return mainList; }
            set
            {
                if (value == null) { Console.WriteLine("Ошибка добавления"); }
                else { mainList = value; }
            }
        }

        public void Remove(int num)
        {
            list.RemoveAt(num);
        }

        public void Add(object element)
        {
            list.Add(element);
        }

        public void PrintElems()
        {
            foreach (object item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
