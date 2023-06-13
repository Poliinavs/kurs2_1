using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb17
{
    interface IWork
    {
        void Need();
    }

    class NeedWork : IWork
    {
        public void Need()
        {
            Console.WriteLine("Сегодня  надо учиться");
        }
    }

    class DontNeed : IWork
    {
        public void Need()
        {
            Console.WriteLine("Сегодня не надо учиться");
        }
    }
    class Work
    {
        protected string model; // модель автомобиля

        public Work( string model, IWork mov)
        {
            this.model = model;
            Movable = mov;
        }
        public IWork Movable { private get; set; }
        public void Need()
        {
            Movable.Need();
        }
    }
}
