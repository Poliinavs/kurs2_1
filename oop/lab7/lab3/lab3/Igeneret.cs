using System;
using System.Collections.Generic;
using System.Text;

namespace lab3
{
        interface IGenericInterface<T> where T : class
        {
            void Add(T type);
            void Delete(T type);
            void Show();
        }
   
}
