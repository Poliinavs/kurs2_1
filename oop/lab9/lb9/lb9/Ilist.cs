using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb9
{
    internal interface IList <T, Y>
    {
        void Add(T key, Y value);
        void Remove(T key);
        void Show(); 
    }
}
